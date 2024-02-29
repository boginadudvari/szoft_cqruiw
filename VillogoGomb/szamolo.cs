using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillogoGomb
{
    internal class Szamolo : Button
    {
        int szám = 1;
        public Szamolo()
        {
            Text=szám.ToString();
            MouseClick += Szamolo_MouseClick;
        }

        private void Szamolo_MouseClick(object? sender, MouseEventArgs e)
        {
            szám++;
            Text=szám.ToString();  


        }
    }
}
