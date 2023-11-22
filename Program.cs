using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "1234", modelo: "Modelo 1", imei: "121314151", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "5555", modelo: "Modelo 2", imei: "232425262", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
