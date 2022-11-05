#include "strip.h"

#include <ArduinoJson.h>

#define PIN 6 // On Trinket or Gemma, suggest changing this to 1

#define NUMPIXELS 51 

Strip* strips[3]; // количество лент ставим 3

unsigned long timeWork = 0;

void setup() {
  // These lines are specifically to support the Adafruit Trinket 5V 16 MHz.
  // Any other board, you can remove this part (but no harm leaving it):
#if defined(__AVR_ATtiny85__) && (F_CPU == 16000000)
  clock_prescale_set(clock_div_1);
#endif
  Serial.begin(9600);
  strips[0] = new Strip(PIN, NUMPIXELS);
  strips[1] = new Strip(5, NUMPIXELS);
  strips[0]->setState(Strip::LightMode::rainbow);
  strips[1]->setState(Strip::LightMode::rainbow);
  Strip::RGB newColor;
  newColor.Red = 170;
  newColor.Blue = 255;
  newColor.Green = 50;
  strips[0]->setColor(newColor);
}

void loop() {
  auto ftime = millis() - timeWork;

  // Так мы увидим сколько времени занимает 1 цикл, и отнимем.
  timeWork = millis();

  // Глобальный цикл по всем не нулевым лентам.
  for (auto const& strip : strips)
  {
    if(strip)
    {
      strip->update(ftime);
    }
  }

  //Принимаемые данные:

  while (Serial.available() > 0) 
  {
    
    //Default values
    // "{condition.line},{condition.mode},{condition.Red},{condition.Green},{condition.Blue},{condition.brightness},{condition.breathing}"
    uint16_t readline = 0;
    uint16_t readmode = 0;
    uint16_t readred = 0;
    uint16_t readgreen = 0;
    uint16_t readblue = 0;
    uint16_t readbrightness = 0;
    uint16_t readbreathing = 0;

    // 4 integers are sent via serial ( R, G, B, effect)
    readline = Serial.parseInt();
    readmode = Serial.parseInt();
    readred = Serial.parseInt();
    readgreen = Serial.parseInt();
    readblue = Serial.parseInt();
    readbrightness = Serial.parseInt();
    readbreathing = Serial.parseInt();

    if (Serial.read() == '\n') 
    {
      Strip::LightMode lightMode = Strip::LightMode::staticLight;
      switch(readmode)
      {
        case 0:
        lightMode = Strip::LightMode::staticLight;
        break;
        case 1:
        lightMode = Strip::LightMode::filling;
        break;
        case 2:
        lightMode = Strip::LightMode::rainbow;
        break;
      }
      Strip::RGB newColor;
      newColor.Red = readred;
      newColor.Blue = readblue;
      newColor.Green = readgreen;
      if(auto const& strip = strips[readline])
      {
        strip->setBrightness(readbrightness);
        strip->setBreathing(readbreathing);
        strip->setColor(newColor);
        strip->setState(lightMode);
      }
      break;
    }

  }
}
