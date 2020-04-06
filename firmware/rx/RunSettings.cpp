#include "RunSettings.h"
#include <EEPROM.h>

RunSettings::RunSettings()
{
}

void RunSettings::initialize()
{  
  
}

void RunSettings::save()
{
  byte *p = (byte*)&Settings;
  for(int i=0; i<sizeof(SoftwareSettings); i++)
  {
    EEPROM.write(i,*p);
    p++;
  }
}

void RunSettings::load()
{  
  byte *p = (byte*)&Settings;
  for(int i=0; i<sizeof(SoftwareSettings); i++)
  {
    *p = EEPROM.read(i);
    p++;
  }
}
