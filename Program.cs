using System;

namespace HomeWork7._1
{
    class Program
    {
        static void Main(string[] args)
        {
           Converter con = new Converter();
        }
    }

    class Converter
    {
        public double converter{get;set;}
        public double usd{get;set;}
        public double eur{get;set;}
        public double rub{get;set;}

        public Converter(){
            
        }
        public Converter(double converter, double usd, double eur, double rub){
            this.converter = converter;
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        } 
    }
 
   
   
}
