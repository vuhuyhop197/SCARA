clc
THETA1_MAX = deg2rad(180);
THETA1_MIN = deg2rad(0);
THETA2_MAX = deg2rad(180);
THETA2_MIN = deg2rad(-180);
d1_MAX = 15;
d1_MIN = 11;
a1 = 10;
a2 = 10.6;
d4 = 11;
d1_min = 11;
d1_max = 23.5;
syms d1 q1 q2 q3;
L1 = Link([0 0 0 0 1]);
L2 = Link([0 0 a1 0 0]);
L3 = Link([0 0 a2 pi 0]);
L4 = Link([0 d4 0 0 0]);
L1.qlim = [11 23.5];
Scara = SerialLink([L1 L2 L3 L4]);
Scara.name = 'Scara';
%forword kinetic
%calculate joint Ai
A1 = Ai_Mat([0 d1 0 0]);
A2 = Ai_Mat([q1 0 a1 0]);
A3 = Ai_Mat([q2 0 a2 180]);
A4 = Ai_Mat([q3 d4 0 0]);
%calculate homogeneous transformations
T = A1*A2*A3*A4;
subs(T,{d1,q1,q2,q3},{10,7,3,0})
%inverse kinetic
syms px py pz anpha;
c2 = (px^2+py^2-a1^2-a2^2)/(2*a1*a2);
s2_1 = sqrt(1-c2^2);
s2_2 = -sqrt(1-c2^2);
theta2 = atan2(s2_1,c2);
theta1 = atan2(py,px)-atan2(a2*sin(theta2),a1+a2*cos(theta2));
theta4 = theta1 + theta2 - anpha;
d1_inv= pz+d4;
%Check result
joint=[d1_inv theta1 theta2 theta4];
subs(joint,{px,py,pz,anpha},{10,7,3,0})*360/(2*pi)
hold on; 
grid on;
view([-37.5 30])
axis([-20 50 -20 50 0 50])
xlabel('x');
xlabel('y');
xlabel('z');
time = -9;
theta1=-8*pi/15;
theta2=-9*pi/15;
while 1
    time = time +1;
    theta2=time*pi/15;
    if time == 10
        theta1=theta1+pi/15;
        theta2=-9*pi/15;
        time =-9;
    end
    if theta1>=8*pi/15
        theta1=-8*pi/15;
        d1_MIN=d1_MIN+0.3;
        if d1_MIN==d1_MAX
            d1_MIN=11;
        end
    end
X=a1*cos(theta1)+a2*cos(theta1+theta2);
Y=a1*sin(theta1)+a2*sin(theta1+theta2);
Z=d1_MIN;
figure(1)
title('Quy dao cua khau tac dong cuoi trong bai toan thuan')
hold on
grid on
plot3(X,Y,Z,'.');
pause(0.05)
end
% Scara.teach([11 0 0 0]);