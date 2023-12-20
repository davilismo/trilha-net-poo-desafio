﻿using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
    namespace DesafioPOO
 {
    class Program
    {
        static void Main(string[] args)
        {
            // Test Nokia
            Console.WriteLine("Smartphone Nokia:");
            Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", iMei: "111111", memoria: 64);
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("WhatsApp");

            Console.WriteLine("\n");
            // Test Iphone
            Console.WriteLine("Smartphone Iphone:");
            Smartphone iphone = new Iphone(numero: "4987", modelo: "111111", imei: "222222", memoria: 128);
            iphone.Ligar();
            iphone.InstalarAplicativo("Telegram");

            Console.ReadLine();

            }
        }
    }