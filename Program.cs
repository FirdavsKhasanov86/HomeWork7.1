using System;

namespace HomeWork7._1
{
    class Program
    {
        //Задание 2.
        public static double somoniUsd;
        public static double somoniEur;
        public static double dollar;
        
        public static double eur;
        static void Main(string[] args)
        {
            //Задание 2.
            bool currency = true;
            while(currency){
                Console.WriteLine("");
                Console.WriteLine("Choise your converttaion:");
                Console.Write("\n1.Конвертация сомони к доллару\n2.Конвертация сомони к евро\n3.Конвертация сомони к рублю\n4.Конвертация доллара к сомони\t\nChoise:");
                string choice = Console.ReadLine();
                switch(choice){
                        case "1":{
                               Console.Write("Write somoni currency:");
                                somoniUsd = double.Parse(Console.ReadLine());
                               
                        }break;
                        case "2":{
                                Console.WriteLine("Write usd currency:");
                                 somoniEur=double.Parse(Console.ReadLine());
                               
                        };break;
                         case "3":{
                                Console.WriteLine("Write eur currency:");
                                 eur=double.Parse(Console.ReadLine());
                               
                        };break;
                         case "4":{
                                Console.WriteLine("Write usd currency:");
                                dollar = double.Parse(Console.ReadLine());
                               
                        };break;

                }
            
                
            Converter con = new Converter(10.2, 11.1, 0.13);
            if(somoniUsd > 0){
            con.ConvertSomoniToUsd(somoniUsd);
            }
             if(somoniEur > 0){
            con.ConvertSomoniToEur(somoniEur);
            }

            if(dollar > 0){
            con.ConverUsdToSomoni(dollar);
            }

            }
           
            
            
            
            
        }
    }

    //Задание 2.
    class Converter
    {
       
        public double usd{get;set;}
        public double eur{get;set;}
        public double rub{get;set;}

        public Converter(){

        }
        public Converter( double usd, double eur, double rub ){
           
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        } 

        public void ConvertSomoniToUsd(double somoniUsd){
                
                Console.WriteLine($"Covert from Somoni to Usd = {Math.Round((somoniUsd/usd),2)} usd");
        }
         public void ConvertSomoniToEur(double somoniEur){
                
                Console.WriteLine($"Covert from Somoni to Eur = {Math.Round((somoniEur/eur),2)} eur");
        }
         public void ConverUsdToSomoni(double dollar){
                
                Console.WriteLine($"Covert from Usd to Somoni = {Math.Round(dollar * usd),2} somoni");
        }

    }
 
   
   
}
