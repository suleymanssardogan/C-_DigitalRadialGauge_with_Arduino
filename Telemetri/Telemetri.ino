
//potansiyummetre değerlerini tanıtma
int pot;
int pot2;

void setup() {
  // put your setup code here, to run once:
  //Potansiyummetrenin analog girişlerini tanıtma
  pinMode(A1,INPUT);
  pinMode(A2,INPUT);
  Serial.begin(9600);

  

}

void loop() {
  // put your main code here, to run repeatedly:

  //potansiyumetreden alınan değerleri C# radial gaugeye göre sınırlandırma
  pot = map(analogRead(A1),0,1024,0,120);
  pot2 = map(analogRead(A2),0,1024,0,120);
  
  Serial.print(pot);
  Serial.print("/");
  Serial.println(pot2);
 //15 milisaniye gecikme süresi
  delay(15);


}
