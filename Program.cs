using DesafioPOO.Models;

Console.WriteLine("Smartphone nokia");
Smartphone nokia = new Nokia(numero: "123", modelo: "Modelo 1", imei: "111111111111", memoria: 24);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Google");

Console.WriteLine("\n");

Smartphone iphone = new Nokia(numero: "321", modelo: "Modelo 2", imei: "222222222222", memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Zap Zap");
