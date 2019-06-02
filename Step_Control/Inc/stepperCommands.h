#include <stdint.h>
#include <stdbool.h>

typedef enum {
  CMD_UNKNOWN   = 0,
  CMD_ADD       = 1,
  CMD_GET       = 2,
  CMD_SET       = 3,
  CMD_RESET     = 4,
	CMD_Grap 			= 5,
	CMD_Orient 		= 6,
	CMD_Home			= 7,
  __CMD_COUNT   = 8,
} request_commands;

typedef enum {
  PARAM_UNDEFINED       = 0,
  PARAM_ALL             = 1,
  PARAM_TARGETPOSITION  = 2,
  PARAM_CURRENTPOSITION = 3,
  PARAM_MINSPS          = 4,
  PARAM_MAXSPS          = 5,
  // readonlies
  PARAM_CURRENTSPS      = 6,
  PARAM_ACCSPS          = 7,
  PARAM_ACCPRESCALER    = 8,
  PARAM_STATUS          = 9,
	PARAM_TAKE						=	10,
	PARAM_DROP						= 11,
  __PARAM_COUNT         = 12
} request_params;

typedef struct {
  volatile char               stepper;
  volatile request_commands   command;
  volatile request_params     parameter;
  volatile int64_t            value;
  volatile bool               isNegativeValue;
} stepper_request;
extern void Grap_object(int state);
extern void Set_Orient(float angle);
extern void Set_Home();
void ExecuteRequest(stepper_request * r);
