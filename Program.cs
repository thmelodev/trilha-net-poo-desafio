using DesafioPOO.Models;


Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia("123456789", "Nokia 3310", "111111", 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine('\n');

Console.WriteLine("Smartphone Iphone:");
Iphone iphone = new Iphone("987654321", "Iphone 13", "222222", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");


