using System;
using System.Collections.Generic;

namespace FilmApp
{
    class Program
    {
        static void Main(string[] arg)
        {
            Film film1 = new Film();
            Film film2 = new Film();

            film1.Cim = "Breaking Bad";
            film1.HosszPercben = 190;

            Console.WriteLine("Adjon meg egy film címet:");
            film2.Cim = Console.ReadLine();
            Console.WriteLine("Adja meg a film hosszát");
            film2.HosszPercben = int.Parse(Console.ReadLine());



            film2.Cim = "Deadpool";
            film2.HosszPercben = 180;

            Console.WriteLine("1. Film címe: {0}, Hossza: {1}",film1.Cim,film1.HosszPercben);
            Console.WriteLine("2. Film címe: {0}, Hossza: {1}", film2.Cim, film2.HosszPercben);
        }
    }
    
    
}
