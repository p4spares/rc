#include "SimRadio.h"

int nIndex = 0;
int nSize = -1;
char readData[sizeof(RCMessage)];//The character array is used as buffer to read into.

SimRadio::SimRadio(RunSettings *settings, Transceiver *transceiver) : Radio(settings, transceiver)
{
}

void SimRadio::startListen()
{
  // nothing to do
}

bool SimRadio::hasMessage()
{
  if (nIndex == nSize)
    return true;
  
  if (Serial.available())
  {
    char c = Serial.read();
    if (nIndex == 0 && c != '!')
      return false;
    else if (nIndex == 1)
    {
       if (c == '0') nSize = sizeof(RCPacket);
       else if (c == '1') nSize = sizeof(RCRawServo);
       else if (c == '2') nSize = sizeof(RCRawServo);
       else if (c == '3') nSize = sizeof(RCWriteConfig);
       else {
        nIndex = 0;
        return false;
       }
    }
    readData[nIndex] = c;
    nIndex++;
  }
  
  return false;
}

void SimRadio::readMessage(byte *msg)
{
  memcpy(msg, &readData, nIndex);
  nIndex = 0;
}
