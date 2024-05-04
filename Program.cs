using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia = new Nokia("1234567890", "3310", "11111", 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Maps");

Iphone iphone = new Iphone("0987654321", "IphoneX", "22222", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Waze");