using System;

namespace HomeWork7._1
{
    class Program
    {
        //Задание 2.
        public static double somoniUsd;
        public static double somoniEur;
        public static double somoniRub;
        public static double dollar;
        public static double euro;
        public static double ruble;
        static void Main(string[] args)
        {
            //Задание 2.
            bool currency = true;
            while(currency){
                Console.ForegroundColor = ConsoleColor.White; 
                Console.WriteLine("");
                Console.WriteLine("Choise your converttaion:");
                Console.Write("\n1.Конвертация сомони к доллару\n2.Конвертация сомони к евро\n3.Конвертация сомони к рублю\n4.Конвертация доллара к сомони\n5.Конвертация евро к сомони\n6.Конвертация рублей к сомони\n7.Выход\t\nChoise:");
                
                string choice = Console.ReadLine();
                switch(choice){
                        case "1":{
                               Console.Write("Write somoni currency:");
                                somoniUsd = double.Parse(Console.ReadLine());
                               
                        }break;
                        case "2":{
                                Console.Write("Write somoni currency:");
                                 somoniEur=double.Parse(Console.ReadLine());
                               
                        };break;
                         case "3":{
                                Console.Write("Write somoni currency:");
                                 somoniRub=double.Parse(Console.ReadLine());
                               
                        };break;
                         case "4":{
                                Console.Write("Write usd currency:");
                                dollar = double.Parse(Console.ReadLine());
                        };break;
                        case "5":{
                                Console.Write("Write euro currency:");
                                euro = double.Parse(Console.ReadLine());
                        };break;
                        case "6":{
                                Console.Write("Write ruble currency:");
                                ruble = double.Parse(Console.ReadLine());
                        };break;
                        case "7": currency = false; break;

                        default: Console.ForegroundColor = ConsoleColor.Red; Console.Write("You are writed wrong number!!!");break;

                }
            
                
            Converter con = new Converter(10.2, 11.1, 0.13);
            if(somoniUsd > 0){
            con.ConvertSomoniToUsd(somoniUsd);
            }
            if(somoniEur > 0){
            con.ConvertSomoniToEur(somoniEur);
            }
            if(somoniRub > 0){
            con.ConvertSomoniToRub(somoniRub);
            }
            if(dollar > 0){
            con.ConverUsdToSomoni(dollar);
            }
            if(euro > 0){
            con.ConverEuroToSomoni(euro);
            }
            if(ruble>0){
            con.ConverRubToSomoni(ruble);
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
                Console.ForegroundColor = ConsoleColor.Green; 
                Console.WriteLine("-----------------------------");
                Console.WriteLine($"Covert from Somoni to Usd = {Math.Round((somoniUsd/usd),2)} usd");
        }
         public void ConvertSomoniToEur(double somoniEur){
                Console.ForegroundColor = ConsoleColor.Green; 
                 Console.WriteLine("-----------------------------");
                Console.WriteLine($"Covert from Somoni to Eur = {Math.Round((somoniEur/eur),2)} eur");
        }
        public void ConvertSomoniToRub(double somoniRub){
                Console.ForegroundColor = ConsoleColor.Green; 
                 Console.WriteLine("-----------------------------");
                Console.WriteLine($"Covert from Somoni to Rub = {Math.Round((somoniRub/rub),2)} rub");
        }
         public void ConverUsdToSomoni(double dollar){
                Console.ForegroundColor = ConsoleColor.Green; 
                Console.WriteLine("-----------------------------");
                Console.WriteLine($"Covert from Usd to Somoni = {Math.Round(dollar * usd),2} somoni");
        }
         public void ConverEuroToSomoni(double euro){
                Console.ForegroundColor = ConsoleColor.Green; 
                 Console.WriteLine("-----------------------------");
                Console.WriteLine($"Covert from Euro to Somoni = {Math.Round(euro * eur),2} somoni");
        }
        public void ConverRubToSomoni(double ruble){
                Console.ForegroundColor = ConsoleColor.Green; 
                 Console.WriteLine("-----------------------------");
                Console.WriteLine($"Covert from Ruble to Somoni = {Math.Round(ruble * rub),2} somoni");
        }

    }
 
   
   
}
