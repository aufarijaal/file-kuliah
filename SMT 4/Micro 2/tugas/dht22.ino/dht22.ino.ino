#include <DHT.h> 
#include <ThingerESP8266.h>
#include <ESP8266WiFi.h> 


//konfigurasi thinger.IO
#define USERNAME "aufarijaal" 
#define DEVICE_ID "NodeMCU_DHT22"
#define DEVICE_CREDENTIAL "MvruqJNcytKkW43$"

//variabel untuk led
#define LED_PIN 0 // pin D3

//variable untuk thinger.io
ThingerESP8266 thing(USERNAME, DEVICE_ID, DEVICE_CREDENTIAL);

//konfigurasi wifi
const char* ssid = "tanjungnet";
const char* password = "aripphb20";

#define DHT_PIN 4 //pin D2
#define DHTTYPE DHT22

//buat variable untuk sensor dht
DHT dht(DHT_PIN, DHTTYPE);

//variable untuk menampung nilai temperature dan humidity
float humidity, temperature;

void setup (){
  pinMode(LED_PIN, OUTPUT);

  //koneksi ke wifi
  WiFi.begin (ssid,password);
  //pengecekan koneksi wifi
  while (WiFi.status() != WL_CONNECTED)
{
  //lampu led mati/off
  digitalWrite(LED_PIN,LOW);
  delay(500);
}
  //apabila terkoneksi
   digitalWrite(LED_PIN,HIGH);
   //hubungkan nodeMCU ke Tinger,IO
   thing.add_wifi(ssid, password);

   //aktifkan sensor dht
   dht.begin();
  //kirim nilai sensor ke thinger.io
   thing["dht22"] >> [] (pson & out) {
    out ["humidity"] = humidity;
    out ["temperature"] = temperature;
   };
   
}
void loop (){
  thing.handle();

  //baca nilai humidity dan temperature
  humidity = dht.readHumidity();
  temperature = dht.readTemperature();
}
