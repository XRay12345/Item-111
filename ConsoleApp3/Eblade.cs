using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolClasses
{
    /*
     * klasa opisuj¹ca konkretny rodzaj itemu w sklepie
     */
    public class Eblade : Item
    {
        public Eblade)
        {
            //Nazwa itemu
            name = "Etherial.blade";
            // jego cene
            price = 4700;
            //Atrybut
            AddStat(Stat.AD, 60);
        }
    }
}