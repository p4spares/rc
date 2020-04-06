#ifndef RCPACKET_H
#define RCPACKET_H

#include <Arduino.h>
#include "RunSettings.h"

struct RCPacket {
  byte S1;
  byte S2; // always '0'
  byte throttle;
  byte yaw;
  byte pitch;
  byte roll;
  byte AUX1;
  byte AUX2;
  byte SE;
};

struct RCRawServo {
  byte S1;
  byte S2; // always '1'
  byte servo;
  byte value;
  byte SE;
};

struct RCHeader {
  byte S1;
  byte S2; // depending on message
};

struct RCWriteConfig {
  byte S1;
  byte S2; // always '3'
  SoftwareSettings Config;
  byte SE;
};

union RCMessage
{
  RCHeader Header;
  RCPacket Packet;
  RCRawServo RawServo;
  RCWriteConfig WriteConfig;
};

#endif
