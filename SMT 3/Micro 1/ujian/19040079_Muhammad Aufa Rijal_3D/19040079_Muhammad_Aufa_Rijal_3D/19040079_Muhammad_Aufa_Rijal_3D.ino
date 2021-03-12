#include <HCSR04.h>
#include <LiquidCrystal.h>
LiquidCrystal lcd(12,11,10,9,8,7);

const int trigPin = 6;
const int echoPin = 5;

long durasi;
int jarakCm;
void setup() {
  // put your setup code here, to run once:
//Serial.begin(9600);
lcd.begin(16,2);
pinMode(trigPin, OUTPUT);
pinMode(echoPin, INPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
    digitalWrite(trigPin, LOW);
    delayMicroseconds(2);
    digitalWrite(trigPin, HIGH);
    delayMicroseconds(10);
    digitalWrite(trigPin, LOW);

    durasi = pulseIn(echoPin, HIGH);
    jarakCm = microsecondsToCm(durasi);

    lcd.setCursor(0,0);
    lcd.print("NIM:19040079/3D");
    
    lcd.setCursor(0,1);
    lcd.print("Jarak: ");
    lcd.print(jarakCm);
    lcd.print(" cm");
    delay(10);
}
long microsecondsToCm(long ms) {
  return ms / 29 / 2;
}
