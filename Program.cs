using System.ComponentModel;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Nokia:");
Smartphone Nokia = new Nokia(numero: "1234567",modelo: "Modelo 1",imei: "111111111", memoria: 64);
Nokia.Ligar();
Nokia.InstalarAplicativo("Clash Royale");


Console.WriteLine("\nIphone:");
Smartphone Iphone = new Iphone(numero: "1234567",modelo: "Modelo 1",imei: "111111111", memoria: 64);
Iphone.ReceberLigacao();
Iphone.InstalarAplicativo("Netflix");