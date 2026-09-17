using System;
using System.Collections.Generic;
using System.Text;

namespace TelefonApp
{
    internal class Okostelefon
    {
        public string Modell {  get; set; }
        public int Toltottseg { get;
            set 
            {
                if (value < 0)
                {
                    value = 0;
                }
                else if (value > 100)
                {
                    value = 100;
                }
            }
        }
    }
}
