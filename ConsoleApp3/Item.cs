using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolClasses
{
    /*
     * Typ wyliczeniowy - statystyki dla itemów
     */
    public enum Stat
    {
        HP,
        AP, 
        AD
    }
    /*
     * Klasa opisująca ogólnie wszystkie itemy które możemy kupić w sklepie
     */
    public class Item
    {
        //nazwa itemu
        public string name;
        //cena
        public int price;
        /*
         * Słownik (tablica asocjacyjna) opisująca wszystkie staty, które ten item dodaje naszej postaci
         */
        Dictionary<Stat, float> stats;
        /*
         * konstuktor
         */
        public Item()
        {
            //pusta nazwa
            name = "";
            //pusta cena
            price = 0;
            //inicjacja atrybutów itemu
            stats = new Dictionary<Stat, float>();
            
        }
        public void AddStat(Stat name, float value)
        {
            stats.Add(name, value);
        }
        public float GetStat(Stat name)
        {
            if(stats.ContainsKey(name))
            {
                return stats[name];
            } 
            else
            {
                return 0;
            }
        }
    }
}
