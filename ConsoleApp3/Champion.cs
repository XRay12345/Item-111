using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolClasses
{
    /*
     * Klasa zawiera definicje dla championa
     */

    class Champion
    {
        // imię postaci
        public string name;
        // maksymalne hp
        public float hp;
        //tablica zawierajaca kupione itemy
        public Item[] items;

        /*
         * Konstruktor 
         */
        public Champion()
        {
            //ustaw puste imie bo nie wiemy jaki to jest champ
            name = "";
            //domyslne hp = 0 z tego samego powodu
            hp = 0;
            //zainicjuj tablice na 
            items = new Item[6];
            //wyświetl komunikat
            Console.WriteLine("Konstruktor klasy Champion");
        }
        /*
         * Funkcja służy to zapisania do postaci kupionego ze sklepu itemu
         */
        public void buyItem(Item i)
        {
            //wyświetlamy kto i co kupił
            Console.WriteLine(name.ToString() + " kupuje " + i.name.ToString());
            for(int j = 0; j < items.Length; j++)
            {
                if(items[j] == null)
                {
                    //wolne miejsce na item - zapisz
                    items[j] = i;
                    //TODO: odejmij pieniądze za item
                    break;
                }
            }
            //stary kod
            //items[0] = i;

            //todo: poprawić tą proteze
            
        }
        /*
         * f-cja wyswietla na ekranie ilość hp postaci
         */
        public void showHP()
        {
            Console.WriteLine("Postać ma " + this.getHP().ToString() + "HP");
        }
        public float getHP()
        {
            //pobierz bazowe i dodaj z itemów;
            float finalHp = hp;
            for(int i = 0; i < items.Length; i++)
            {
                if(items[i]!=null)
                    finalHp += items[i].GetStat(Stat.HP);
            }
            return finalHp;

        }
    }
}
