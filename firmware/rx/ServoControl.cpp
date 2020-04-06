#include "ServoControl.h"

ServoControl::ServoControl()
{
  
}

void ServoControl::initialize(RunSettings *settings, int cfgIndex)
{
  _channelSettings = &settings->Settings.Servos[0];
  _servo.attach(PA0);
  delay(10);
  write(_channelSettings->MinValue);
  delay(1000);
  write(_channelSettings->MaxValue);
  delay(1000);
}

void ServoControl::writeRaw(byte value)
{
  _servo.write(value);
}

void ServoControl::write(byte value)
{
  value = applyLimits(value);
  writeRaw(value);
}

void ServoControl::writeMap(byte value, int fromLow, int fromHigh)
{
  byte m = map(value, _channelSettings->MinValue, _channelSettings->MaxValue, fromLow, fromHigh);
  write(m);
}

void ServoControl::writeMap(byte value)
{
  byte m = map(value, 0, 255, _channelSettings->MinValue, _channelSettings->MaxValue);
  write(m);
}

byte ServoControl::read()
{
  return _servo.read();
}

byte ServoControl::applyLimits(byte value)
{
  if (value < _channelSettings->MinValue)
   value = _channelSettings->MinValue;
  else if (value > _channelSettings->MaxValue)
   value = _channelSettings->MaxValue;
  return value;
}
