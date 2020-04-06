#ifndef RECEIVER_H
#define RECEIVER_H

#include "RCPacket.h"
#include "RunSettings.h"
#include "Radio.h"
#include "Transceiver.h"
#include "Gyroscope.h"
#include "ServoControl.h"

class Gyroscope;

enum CurrentState
{
  NOP,
  PROCESSED,
  FAILSAFE,
  AUTOLEVEL
};

class Receiver : public Transceiver
{
  private:
    RunSettings *_settings;

    /* radio */
    Radio *_radio;
    /* radio */

    /* servos */
    ServoControl _servoRudder;
    Servo *_servoElevator;
    Servo *_servoAileronLeft;
    Servo *_servoAileronRight;
    /* servos */

    /* I2C */
    TwoWire *_I2C;
    /* I2C */

    /* gyroscope */
    Gyroscope *_gyroscope;
        
  public:
    Receiver(RunSettings *settings);
    void initialize();
    Gyroscope *getGyroscope();
    TwoWire *getI2C();
    Radio *getRadio();
    CurrentState processMessage();
    void failSafe();
    void autoLevel();

  private:
    bool checkTimestampFail();

};

#endif
