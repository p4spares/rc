#ifndef SERVOCONTROL_H
#define SERVOCONTROL_H

#include <Servo.h>
#include "RunSettings.h"

class ServoControl
{
  private:
    Servo _servo;
    ChannelSettings *_channelSettings;
    
  public:
    ServoControl();
    void initialize(RunSettings *settings, int cfgIndex);
    void write(byte value);
    void writeRaw(byte value);
    void writeMap(byte value, int fromLow, int fromHigh);
    void writeMap(byte value);
    byte read();

  private:
    byte applyLimits(byte value);
};

#endif
