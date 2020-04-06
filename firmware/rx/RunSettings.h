#ifndef RUNSETTINGS_H
#define RUNSETTINGS_H

#include <Wire.h>  // Wire library - used for I2C communication

struct ADXL345Config
{
  int I2CAddress = 0x53; // The ADXL345 sensor I2C address
};

enum PowerLevel
{
  Min,
  Max
};

struct RF24Config
{
  uint64_t Address = 0xF0F0F0F0E1LL;
  int CEPin = PB0;
  int CSPin = PA4;
  PowerLevel Power = Min;
};

enum ChannelBinding : byte
{
  DISABLED = 0,
  JOYLEFT_X, // joystick left, x axis
  JOYLEFT_Y, // joystick right, y axis
  JOYRIGHT_X, // joystick left, x axis
  JOYRIGHT_Y, // joystick right, y axis
  POTENTIOMETER_1, // potentiometer #1
  POTENTIOMETER_2, // potentiometer #1
};

enum ChannelMode : byte
{
  NORMAL = 0,
  EXPONENTIAL = 1
};

enum SinkMode : byte
{
  ESC = 0,
  SERVO_0,
  SERVO_1,
  SERVO_2,
  SERVO_3
};

struct ChannelSettings
{
  ChannelBinding Binding;
  SinkMode Sink;
  ChannelMode Mode;
  char Name[21];
  byte Inverted;
  byte MinValue;
  byte MaxValue;
  byte Zero;
};

struct HardwardConfig
{
  ADXL345Config Gyroscope;
  RF24Config  RF24;
};

struct SoftwareSettings
{
  ChannelSettings Servos[6];
};

class RunSettings
{
  public:
    HardwardConfig Hardware;
    SoftwareSettings Settings;
    
  private:
  
  public:
    RunSettings();
    void initialize();
    void save();
    void load();
    
};

#endif
