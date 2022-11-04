#include <Adafruit_NeoPixel.h>
#ifdef __AVR__
#include <avr/power.h>
#include <EEPROM.h>
#endif

// The code uses parts from Adafruit_NeoPixel tutorial

#define PIN 6
int NUM_LED = 57;

int speed = 20;

// Parameter 1 = number of pixels in strip
// Parameter 2 = Arduino pin number (most are valid)
// Parameter 3 = pixel type flags, add together as needed:
//   NEO_KHZ800  800 KHz bitstream (most NeoPixel products w/WS2812 LEDs)
//   NEO_KHZ400  400 KHz (classic 'v1' (not v2) FLORA pixels, WS2811 drivers)
//   NEO_GRB     Pixels are wired for GRB bitstream (most NeoPixel products)
//   NEO_RGB     Pixels are wired for RGB bitstream (v1 FLORA pixels, not v2)
//   NEO_RGBW    Pixels are wired for RGBW bitstream (NeoPixel RGBW products)
Adafruit_NeoPixel* strip;
int effect = 0, red = 0, green = 0, blue = 0;
int tred = 255, tgreen = 255, tblue = 255, teffect = 0;

// IMPORTANT: To reduce NeoPixel burnout risk, add 1000 uF capacitor across
// pixel power leads, add 300 - 500 Ohm resistor on first pixel's data input
// and minimize distance between Arduino and first pixel.  Avoid connecting
// on a live circuit...if you must, connect GND first.
void setup() {
  // This is for Trinket 5V 16MHz, you can remove these three lines if you are not using a Trinket
#if defined (__AVR_ATtiny85__)
  if (F_CPU == 16000000) clock_prescale_set(clock_div_1);
#endif
  // End of trinket special code
  strip = new Adafruit_NeoPixel(NUM_LED, PIN, NEO_GRB + NEO_KHZ800);
  Serial.begin(38400);
  strip->begin();
  strip->show(); // Initialize all pixels to 'off'
  //Read saved configuration
  doEEPROMread();

}

void loop() {

  switch (effect) {
    case 0:
      colorWipe(strip->Color(red, green, blue), 30);
      effect = -1;
      break;
    case 1:
      theaterChase(strip->Color(red, green, blue), 30);
      break;
    case 2:
      rainbowCycle(speed);
      break;
    case 3:
      flashRandom(3, 2, 500);
      break;
    case 254: //notification
      theaterChaseNotification(strip->Color(tred, tgreen, tblue), 50,10);
      effect = teffect;
      break;
    case 255:
      //delay(7000);
      colorWipe(strip->Color(tred, tgreen, tblue), 30);
      effect = -1;
      break;

  }
  // Some example procedures showing how to display to the pixels:
  
  while (Serial.available() > 0) {
    
    //Default values
    int readred = 0;
    int readgreen = 0;
    int readblue = 0;
    int readeffect = 0;
    int readSpeed = 0;
    int readLedCount = 0;

    // 4 integers are sent via serial ( R, G, B, effect)
    readred = Serial.parseInt();
    readgreen = Serial.parseInt();
    readblue = Serial.parseInt();
    readeffect = Serial.parseInt();
    readSpeed = Serial.parseInt();
    readLedCount =  Serial.parseInt();
    speed = readSpeed;

    if(readLedCount != NUM_LED)
    {
      NUM_LED = readLedCount;
      strip = new Adafruit_NeoPixel(NUM_LED, PIN, NEO_GRB + NEO_KHZ800);
    }

    if (Serial.read() == '\n') {
      setStrip(readred, readblue, readgreen, readeffect);
      break;
    }

  }
}

void setStrip(int readred, int readblue, int readgreen, int readeffect) {
  if (readeffect == 255) { //Pc shutdown/sleep
    Serial.print(effect);
    teffect = effect;
    //Save new configuration to EEPROM
    EEPROM.write(0, red);
    EEPROM.write(1, green);
    EEPROM.write(2, blue);
    EEPROM.write(3, effect);
    EEPROM.write(4, 1); // 1 means to be loaded on restart (hardcoded)
    tred = readred;
    tgreen = readgreen;
    tblue = readblue;
    effect = readeffect;
  }
  else if (readeffect == 254) {

    tred = readred;
    tgreen = readgreen;
    tblue = readblue;
    teffect = effect;
    effect=readeffect;
  }
  else {
    effect = readeffect;
    red = readred;
    green = readgreen;
    blue = readblue;
    if (effect == 2)
      return;
  }
  if(teffect==-1)
    teffect=0;
  // constrain the values to 0 - 255 and invert
  // if you're using a common-cathode LED, just use "constrain(color, 0, 255);"
    red = constrain(red, 0, 255);
    green = constrain(green, 0, 255);
    blue = constrain(blue, 0, 255);
    tred = constrain(tred, 0, 255);
    tgreen = constrain(tgreen, 0, 255);
    tblue = constrain(tblue, 0, 255);
  //colorWipe(strip->Color(red, green, blue), 30);

}

void doEEPROMread() {
  int readred = EEPROM.read(0);

  int readgreen = EEPROM.read(1);

  int readblue = EEPROM.read(2);
  int readeffect = EEPROM.read(3);
  EEPROM.write(4, 0); // Don't read next time
  //Apply LED config that was read
  setStrip(readred, readblue, readgreen, 0);
  //setStrip(255, 0, 0, 0);
}

/***** EFFECTS *****/

// Fill the dots one after the other with a color
void colorWipe(uint32_t c, uint8_t wait) {
  for (uint16_t i = 0; i < strip->numPixels(); i++) {
    strip->setPixelColor(i, c);
    strip->show();
    delay(wait);
  }
}

void flashRandom(int count, int times, int delayAfter) {
  int positions[count];
  for (int i = 0; i < count; i++) {
    positions[i] = random(0, NUM_LED - 1);
  }
  for (int t = 0; t < times; t++) {
    for (int i = 0; i < count; i++) {
      strip->setPixelColor(positions[i], strip->Color(255, 255, 255));
    }
    strip->show();
    if (Serial.available() > 0)
      break;
    delay(10);
    for (int i = 0; i < count; i++) {
      strip->setPixelColor(positions[i], strip->Color(red, green, blue));
    }
    strip->show();
    if (Serial.available() > 0)
      break;
    delay(100);
  }
  delay(delayAfter);

}

void rainbow(uint8_t wait) {
  uint16_t i, j;

  for (j = 0; j < 256; j++) {
    for (i = 0; i < strip->numPixels(); i++) {
      strip->setPixelColor(i, Wheel((i + j) & 255));
    }
    strip->show();
    if (Serial.available() > 0)
      break;
    delay(wait);
  }
}

// Slightly different, this makes the rainbow equally distributed throughout
void rainbowCycle(uint8_t wait) {
  uint16_t i, j;

  for (j = 0; j < 256 * 5; j++) { // 5 cycles of all colors on wheel
    for (i = 0; i < strip->numPixels(); i++) {
      strip->setPixelColor(i, Wheel(((i * 256 / strip->numPixels()) + j) & 255));
    }
    strip->show();
    if (Serial.available() > 0)
      break;
    delay(wait);
  }
}

//Theatre-style crawling lights.
void theaterChase(uint32_t c, uint8_t wait) {
  for (int j = 0; j < 20; j++) { //do 10 cycles of chasing
    for (int q = 0; q < 3; q++) {
      for (uint16_t i = 0; i < strip->numPixels(); i = i + 3) {
        strip->setPixelColor(i + q, c);  //turn every third pixel on
      }
      strip->show();
      
      delay(wait);

      for (uint16_t i = 0; i < strip->numPixels(); i = i + 3) {
        strip->setPixelColor(i + q, 0);      //turn every third pixel off
      }
      if (Serial.available() > 0)
      break;
    }
  }
}
//Theatre-style crawling lights.
void theaterChaseNotification(uint32_t c, uint8_t wait, uint8_t ledcount) {
  for (int j = 0; j < 20; j++) { //do 10 cycles of chasing
    for (int q = 0; q < 3; q++) {
      for (uint16_t i = 0; i < ledcount; i = i + 3) {
        strip->setPixelColor(i + q, c);  //turn every third pixel on
      }
      strip->show();
      
      delay(wait);

      for (uint16_t i = 0; i < ledcount; i = i + 3) {
        strip->setPixelColor(i + q, 0);      //turn every third pixel off
      }
      if (Serial.available() > 0)
      break;
    }
  }
}

//Theatre-style crawling lights with rainbow effect
void theaterChaseRainbow(uint8_t wait) {
  for (int j = 0; j < 256; j++) {   // cycle all 256 colors in the wheel
    for (int q = 0; q < 3; q++) {
      for (uint16_t i = 0; i < strip->numPixels(); i = i + 3) {
        strip->setPixelColor(i + q, Wheel( (i + j) % 255)); //turn every third pixel on
      }
      strip->show();

      delay(wait);

      for (uint16_t i = 0; i < strip->numPixels(); i = i + 3) {
        strip->setPixelColor(i + q, 0);      //turn every third pixel off
      }
    }
  }
}

// Input a value 0 to 255 to get a color value.
// The colours are a transition r - g - b - back to r.
uint32_t Wheel(byte WheelPos) {
  WheelPos = 255 - WheelPos;
  if (WheelPos < 85) {
    return strip->Color(255 - WheelPos * 3, 0, WheelPos * 3);
  }
  if (WheelPos < 170) {
    WheelPos -= 85;
    return strip->Color(0, WheelPos * 3, 255 - WheelPos * 3);
  }
  WheelPos -= 170;
  return strip->Color(WheelPos * 3, 255 - WheelPos * 3, 0);
}
