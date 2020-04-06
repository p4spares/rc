#ifndef _SIMRADIO_H
#define _SIMRADIO_H

#include "Radio.h"

class SimRadio : public Radio
{
  public:
  SimRadio(RunSettings *settings, Transceiver *transceiver);
  void startListen() override;
  bool hasMessage() override;
  void readMessage(byte *msg) override;
};

#endif
