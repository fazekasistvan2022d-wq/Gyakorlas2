using System;
using System.Collections.Generic;
using System.Text;

namespace KavezogepApp
{
    internal class Kavezogep
    {
        private int vizKeszletML;
        public void VizTolt(int ml)
        {
            if(ml < 0)
            {
                Console.WriteLine("Rossz érték!");
                vizKeszletML = 0;
            }
            else
            {
                vizKeszletML = ml;
            }
        }

        public void KaveFozes()
        {
            if (vizKeszletML < 150)
            {
                Console.WriteLine("Nem lehet kávét főzni!");

            }
            else
            {
                Console.WriteLine("Víz szint csökkentése..");
                vizKeszletML -= 150;
            }
            
        }
    }
}
