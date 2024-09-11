using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VytvoreniXML
{
    internal class CarBazar
    {
        /// <summary>
        /// Název modelu auta, get - pro čtení, set - pro zápis, privátní, aby uživatel nemohl měnit obsah
        /// </summary>
        public string NazevModelu { get; private set; }

        /// <summary>
        /// Datum, kdy bylo auto prodáno
        /// </summary>
        public DateTime DatumProdeje {  get; private set; }

        /// <summary>
        /// Cena automobilu, za kterou byl prodán
        /// </summary>
        public double Cena {  get; private set; }

        /// <summary>
        /// Daň z přidané hodnoty, která se v tom roce vztahovala na prodej aut
        /// </summary>
        public double Dph { get; private set; }

        /// <summary>
        /// inicializace atributu(vlastností)
        /// </summary>
        /// <param name="nazevModelu"></param>
        public CarBazar(string nazevModelu, DateTime datumProdeje, double cena, double dph) 
        {
            NazevModelu = nazevModelu;
            DatumProdeje = datumProdeje;
            Cena = cena;
            Dph = dph;
        }

        public override string ToString()
        {
            return NazevModelu + DatumProdeje + Cena + ",-" + Dph;
        }
    }
}
