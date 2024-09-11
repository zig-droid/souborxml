using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;


namespace VytvoreniXML
{
    internal partial class Program
    {
        private static void Main(string[] args)
        {
            /// <summary>
            /// Kolekce(seznam) kam se budou ukládat auta
            /// </summary>
            List<CarBazar> cars = new List<CarBazar>();

            /* Naplnění kolekce jednotlivými modely aut, včetně datumu prodeje, ceny a DPH */

            cars.Add(new CarBazar("Škoda Oktávia", new DateTime(2010, 12, 2), 500000, 20));
            cars.Add(new CarBazar("Škoda Felicia", new DateTime(2000, 12, 3), 210000, 20));
            cars.Add(new CarBazar("Škoda Fabia", new DateTime(2010, 12, 4), 350000, 20));
            cars.Add(new CarBazar("Škoda Oktávia", new DateTime(2010, 12, 4), 500000, 20));
            cars.Add(new CarBazar("Škoda Oktávia", new DateTime(2010, 12, 5), 500000, 20));
            cars.Add(new CarBazar("Škoda Fabia", new DateTime(2010, 12, 5), 350000, 20));
            cars.Add(new CarBazar("Škoda Fabia", new DateTime(2010, 12, 6), 350000, 20));
            cars.Add(new CarBazar("Škoda Forman", new DateTime(2000, 12, 4), 100000, 19));
            cars.Add(new CarBazar("Škoda Favorit", new DateTime(2000, 12, 5), 80000, 19));
            cars.Add(new CarBazar("Škoda Forman", new DateTime(2000, 12, 6), 100000, 19));
            cars.Add(new CarBazar("Škoda Felicia", new DateTime(2000, 12, 3), 210000, 19));
            cars.Add(new CarBazar("Škoda Felicia", new DateTime(2000, 12, 2), 210000, 19));
            cars.Add(new CarBazar("Škoda Oktávia", new DateTime(2010, 12, 7), 500000, 20));
            
            // Vytvoří stromovou strukturu
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            

            /* Samotné zapsání do XML souboru */
           
            using (XmlWriter xw = XmlWriter.Create("@prodana_auta.xml", settings))
            {
                // Hlavička dokumentu
                xw.WriteStartDocument();
                xw.WriteStartElement("TabulkaProdanýchAut");
                foreach (CarBazar a in cars)
                {

                    xw.WriteStartElement("Model");
                    xw.WriteValue(a.NazevModelu);
                    xw.WriteEndElement();
                    
                    xw.WriteStartElement("Prodej");
                    xw.WriteValue(a.DatumProdeje.ToShortDateString());
                    xw.WriteEndElement();
                    
                    xw.WriteStartElement("Cena");
                    xw.WriteValue(a.Cena);
                    xw.WriteEndElement();
                    
                    xw.WriteStartElement("DPH");
                    xw.WriteValue(a.Dph);
                    xw.WriteEndElement();
                }
                xw.WriteEndElement();
                xw.WriteEndDocument();
                xw.Close();
            }
        }
    }
}
