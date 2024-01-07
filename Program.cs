using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

System.Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123321", modelo: "Modelo 1", imei: "12344321", memoria:64 );
nokia.Ligar();
nokia.InstalarAplicativo("whats");

System.Console.WriteLine("\n");

System.Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "12332134", modelo: "Modelo 13", imei: "1234432123", memoria:128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("telegram");


