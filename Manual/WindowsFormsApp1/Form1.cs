using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using ZedGraph;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int TickStart, intMode = 1;
        private void Form1_Load(object sender, EventArgs e)
        {
            forward_kinetic(Convert.ToDouble(trackBarX.Value), Convert.ToDouble(trackBarY.Value), Convert.ToDouble(trackBarZ.Value));
        }
        private void PbConnect_Click(object sender, EventArgs e)
        {
            if (LbStatus.Text == "Disconnect")
            {

                Com.PortName = CbSecCom.Text;
                Com.Open();
                LbStatus.Text = "Connect";
                PbConnect.Text = "Disconnect";
                TickStart = Environment.TickCount;

            }
            else
            {
                Com.Close();
                LbStatus.Text = "Disconnect";
                PbConnect.Text = "Connect";
            }
        }
        int intlen = 0;
        double[] joints = new double[4];
        double a1 = 10.0, a2 = 10.3, d4 = 11;
        double x_cur, y_cur, z_cur;
        int step=0;
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            if (intlen != ports.Length)
            {
                intlen = ports.Length;
                for (int j = 0; j < intlen; j++)
                {
                    CbSecCom.Items.Add(ports[j]);
                }

            }
            //Reset flag return default
            if (reset)
            {
                if (X_pos == 1441 && Y_pos == -359)
                {
                    reset = false;
                    Val_x_set = X_pos;
                    Val_y_set = Y_pos;
                }
            }
            
            if (Convert.ToInt16(Val_x_set) == X_pos && Convert.ToInt16(Val_y_set) == Y_pos && Convert.ToInt16(Val_z_set) == Z_pos)
            {
                if (flag_buffer == 1)
                {
                    Com.WriteLine("setY:" + Convert.ToString(Convert.ToInt16(Val_y_set)) + ":");
                }
            }
            if (check_box_mode.CheckState ==CheckState.Checked )
            {
                if (Convert.ToInt16(Val_x_set) == X_pos && Convert.ToInt16(Val_y_set) == Y_pos && Convert.ToInt16(Val_z_set) == Z_pos)
                {
                    if (flag_buffer==1)
                    {
                        Com.WriteLine("setY:" + Convert.ToString(Convert.ToInt16(Val_y_set)) + ":");
                        flag_buffer = 0;
                    }
                    step++;
                    switch (step)
                    {
                        case 1:
                            Btn_Grap.Text = "Grap";
                            Com.WriteLine("GRAPX.DROP:");
                            txt_InvZ.Text = Convert.ToString(Convert.ToDouble(txt_InvZ.Text) + 1);
                            Inverse_kinetic();
                            break;
                        case 2:
                            txt_InvZ.Text = Convert.ToString(Convert.ToDouble(txt_InvZ.Text) - 1);
                            Inverse_kinetic();
                            break;
                        case 3:
                            Btn_Grap.Text = "Drop";
                            Com.WriteLine("GRAPX.TAKE:");
                            break;
                        case 4:
                            txt_InvZ.Text = Convert.ToString(Convert.ToDouble(txt_InvZ.Text) + 1);
                            Inverse_kinetic();
                            break;
                        case 5:
                            txt_InvX.Text = "10";
                            txt_InvY.Text = "-10";
                            Inverse_kinetic();
                            break;
                        case 6:
                            Btn_Grap.Text = "Grap";
                            Com.WriteLine("GRAPX.DROP:");
                           
                            step = 0;
                            check_box_mode.CheckState = CheckState.Unchecked;
                            break;
                            
                    }
                    
                }
            }
        }
        private void OnCom(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                string temp;
                temp = Com.ReadLine();
                Display(temp);
            }
            catch (System.IO.IOException error)
            {
                return;
            }
            catch (System.InvalidOperationException error)
            {
                return;
            }
        }
        private delegate void DlDisplay(string s);

        

        private void BTN_For_Click(object sender, EventArgs e)
        {
            //forward_kinetic(Convert.ToDouble(txtTheta1.Text), Convert.ToDouble(txtTheta2.Text), Convert.ToDouble(txtd1.Text));
            trackBarX.Value = Convert.ToInt16(txtTheta1.Text);
            trackBarY.Value = Convert.ToInt16(txtTheta2.Text);
            trackBarZ.Value = Convert.ToInt16(txtd1.Text);
        }

        private void Btn_Grap_Click(object sender, EventArgs e)
        {
            if (Btn_Grap.Text == "Grap")
            {
                Btn_Grap.Text = "Drop";
                Com.WriteLine("GRAPX.TAKE:");
            }
            else if(Btn_Grap.Text == "Drop")
            {
                Btn_Grap.Text = "Grap";
                Com.WriteLine("GRAPX.DROP:");
            }
        }

        private void Btn_reset_Click(object sender, EventArgs e)
        {

        }

        private void forward_kinetic(double theta1, double theta2, double d1)
        {
            theta1 = theta1 / 360 * (2 * Math.PI) ;
            theta2 = theta2 / 360 * (2 * Math.PI) ;
            x_cur = a1 * Math.Cos(theta1) + a2 * Math.Cos(theta1 + theta2);
            y_cur = a1 * Math.Sin(theta1) + a2 * Math.Sin(theta1 + theta2);
            z_cur = d1 - d4;
            txt_xcur.Text = string.Format("{0:0.00}", x_cur);
            txt_ycur.Text = string.Format("{0:0.00}", y_cur);
            txt_zcur.Text = string.Format("{0:0.00}", z_cur);
        }

        private void Pb_Inv_Click(object sender, EventArgs e)
        {
            if (LbStatus.Text == "Connect")
            {
                Inverse_kinetic();
                
            }

        }
        void Inverse_kinetic()
        {
            double c2, s2_1, s2_2;
            double[] temp = new double[2];
            double x, y, z;
            x = Convert.ToDouble(txt_InvX.Text);
            y = Convert.ToDouble(txt_InvY.Text);
            z = Convert.ToDouble(txt_InvZ.Text);
            c2 = (Math.Pow(x, 2) + Math.Pow(y, 2) - Math.Pow(a1, 2) - Math.Pow(a2, 2)) / (2 * a1 * a2);
            s2_1 = Math.Sqrt(1 - Math.Pow(c2, 2));
            s2_2 = -Math.Sqrt(1 - Math.Pow(c2, 2));
            joints[0] = z + d4;
            joints[2] = Math.Atan2(s2_1, c2);
            joints[1] = Math.Atan2(y, x) - Math.Atan2(a2 * Math.Sin(joints[2]), a1 + a2 * Math.Cos(joints[2]));
            //joints[3] = joints[1] + joints[2] - anpha;
            temp[0] = Math.Atan2(s2_2, c2);
            temp[1] = Math.Atan2(y, x) - Math.Atan2(a2 * Math.Sin(temp[0]), a1 + a2 * Math.Cos(temp[0]));
            if ((Math.Abs(temp[0]) + Math.Abs(temp[1])) < (Math.Abs(joints[1]) + Math.Abs(joints[2])))
            {
                joints[2] = temp[0];
                joints[1] = temp[1];
            }
            joints[1] = joints[1] * 360 / (2 * Math.PI);
            joints[2] = joints[2] * 360 / (2 * Math.PI);
            //Com.WriteLine("GRAPX.DROP:");
            if (x_cur != joints[1])
            {
                trackBarX.Value = Convert.ToInt16(joints[1]);
                //Com.WriteLine("setX:" + Convert.ToString(Convert.ToInt32(joints[0]) + ":"));
            }
            if (y_cur != joints[2])
            {
                trackBarY.Value = Convert.ToInt16(joints[2]);
                //Com.WriteLine("setY:" + Convert.ToString(Convert.ToInt32(joints[1]) + ":"));
            }
            if (z_cur != joints[0])
            {
                trackBarZ.Value = Convert.ToInt16(joints[0]);
                //Com.WriteLine("setZ:" + Convert.ToString(Convert.ToInt32(joints[2]) + ":"));
            }
            forward_kinetic(joints[1], joints[2], joints[0]);
        }
        double Val_x_set=1441, Val_y_set=-359, Val_z_set=22000;

        private void TB_theta4_ValueChanged(object sender, EventArgs e)
        {
            if (LbStatus.Text == "Connect")
            {
                Txt_theta4.Text = Convert.ToString(TB_theta4.Value);
                Com.WriteLine("ORTX:" + Txt_theta4.Text + ":");
                //forward_kinetic(Convert.ToDouble(trackBarX.Value), Convert.ToDouble(trackBarY.Value), Convert.ToDouble(trackBarZ.Value));
            }
        }
        bool reset=false;
        private void Btn_Home_Click(object sender, EventArgs e)
        {
            Com.WriteLine("HOMEX:");
            X_pos = 1441;
            Y_pos = -359;
            reset = true;
            trackBarX.Value = 100;
            trackBarY.Value = -133;
        }

        private void txt_InvZ_TextChanged(object sender, EventArgs e)
        {

        }

        private void check_box_mode_CheckedChanged(object sender, EventArgs e)
        {
            if (check_box_mode.Checked == true)
            {
                
            }
        }
        double flag_buffer=0;
        private void trackBarY_ValueChanged(object sender, EventArgs e)
        {
            if (LbStatus.Text == "Connect")
            {
                txtTheta2.Text = Convert.ToString(trackBarY.Value);
                Val_y_set = Val_x_set + (Convert.ToDouble(trackBarY.Value) / 1.8) * (62.0 / 16.0) * 8.0 / 1.2;
                if (reset == false)
                {
                    Com.WriteLine("setY:" + Convert.ToString(Convert.ToInt16(Val_y_set)) + "/");
                }
                forward_kinetic(Convert.ToDouble(trackBarX.Value), Convert.ToDouble(trackBarY.Value), Convert.ToDouble(trackBarZ.Value));
            }
        }
        private void trackBarZ_ValueChanged(object sender, EventArgs e)
        {
            if (LbStatus.Text == "Connect")
            {
                txtd1.Text = Convert.ToString(trackBarZ.Value);
                txtTheta1.Text = Convert.ToString(trackBarX.Value);
                Val_z_set = (trackBarZ.Value / 0.8) * 200*8;
                Com.WriteLine("setZ:" + Convert.ToString(Convert.ToInt16(Val_z_set)) + "/");
                forward_kinetic(Convert.ToDouble(trackBarX.Value), Convert.ToDouble(trackBarY.Value), Convert.ToDouble(trackBarZ.Value));
            }
        }
        private void trackBarX_ValueChanged(object sender, EventArgs e)
        {
            if (LbStatus.Text == "Connect")
            {
              
                txtTheta1.Text = Convert.ToString(trackBarX.Value);
                Val_x_set = (Convert.ToDouble(trackBarX.Value) / 1.8) * (62.0 / 16.0) * 8.0 / 1.2;
                Val_y_set = Val_x_set + (Convert.ToDouble(trackBarY.Value) / 1.8) * (62.0 / 16.0) * 8.0 / 1.2;
                forward_kinetic(Convert.ToDouble(trackBarX.Value), Convert.ToDouble(trackBarY.Value), Convert.ToDouble(trackBarZ.Value));
                if (reset == false)
                {
                    Com.WriteLine("setX:" + Convert.ToString(Convert.ToInt16(Val_x_set) + "/"));
                    Com.WriteLine("setY:" + Convert.ToString(Convert.ToInt16(Val_y_set)) + "/");
                }
            }
        }
        double X_pos = 1441, Y_pos = -359, Z_pos = 22000;
        private void Display(string s)
        {
            if (Txt_Data.InvokeRequired)
            {
                DlDisplay sd = new DlDisplay(Display);
                Txt_Data.Invoke(sd, new object[] { s });
            }
            else
            {
                try
                {
                    //txtPid.Text += s;
                    //[] X_pos = s.Split(sstring stringSeparators tringSeparators, StringSplitOptions.None);
                    if (s.Contains("X.stop:"))
                    {
                        string[] temp = s.Split(new char[] { ':' });
                        X_pos = Convert.ToDouble(temp[1]);
                    }
                    else if (s.Contains("Y.stop:"))
                    {
                        string[] temp = s.Split(new char[] { ':' });
                        Y_pos = Convert.ToDouble(temp[1]);
                    }
                    else if (s.Contains("Z.stop:"))
                    {
                        string[] temp = s.Split(new char[] { ':' });
                        Z_pos = Convert.ToDouble(temp[1]);
                    }
                    Txt_Data.Text = X_pos.ToString() + "/n" + Y_pos.ToString() + "/n";
                }   
                catch (IndexOutOfRangeException)
                {
                    return;
                }
                
            }
        }

    }
}
