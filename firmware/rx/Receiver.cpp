#include "Receiver.h"
#include "SimRadio.h"

bool bHasLastPacket = false;
RCMessage msg;

Receiver::Receiver(RunSettings *settings)
{
  _settings = settings;
}

void Receiver::initialize()
{
  // Initiate the Wire library
  _I2C = &Wire;
  _I2C->begin(); 

  _servoRudder.initialize(_settings, 0);
  //_servoRudder.attach(PA0);
  
  _gyroscope = new Gyroscope(_settings, this);
  _gyroscope->initialize();

  _radio = new SimRadio(_settings, this);
  _radio->startListen();
  
}

Gyroscope *Receiver::getGyroscope()
{
  return _gyroscope;
}

TwoWire *Receiver::getI2C()
{
  return _I2C;
}

Radio *Receiver::getRadio()
{
  return _radio;
}

CurrentState Receiver::processMessage()
{
  if (_radio->hasMessage())
  {
    _radio->readMessage((byte*)&msg);
    
    /* 0 - standard rc message */
    if (msg.Header.S2 == '0')
    {
      int nAtZero = 0;    

      if (msg.Packet.yaw == 127)
        nAtZero++;
      else if (msg.Packet.yaw != _servoRudder.read())
        _servoRudder.writeMap(msg.Packet.yaw);
      
      if (nAtZero==1 && msg.Packet.AUX1 == 1)
        return AUTOLEVEL;
      return PROCESSED;
    }
    else if (msg.Header.S2 == '1')
    {
      // 1 - calibrate
      _servoRudder.writeRaw(msg.RawServo.value);
    }
    else if (msg.Header.S2 == '2')
    {
      Serial.write((uint8*)&_settings->Settings, sizeof(SoftwareSettings));
    }
    else if (msg.Header.S2 == '3')
    {
      memcpy((uint8*)&_settings->Settings, &msg.WriteConfig.Config, sizeof(SoftwareSettings));
      _settings->save();
      Serial.println("OK");
    }
  }

  if (checkTimestampFail())
    return PROCESSED;
    
  return NOP;
}

bool Receiver::checkTimestampFail()
{
  return false;
}

void Receiver::failSafe()
{
  
}
void Receiver::autoLevel()
{
  GyroscopeData data;
  _gyroscope->read(&data);

/*
  Serial.print("Xa= ");
  Serial.print(data.X);
  Serial.print("   Ya= ");
  Serial.print(data.Y);
  Serial.print("   Za= ");
  Serial.println(data.Z);
*/

  _servoRudder.write(map(-data.X, -256, 256, 0, 180));
  
}
