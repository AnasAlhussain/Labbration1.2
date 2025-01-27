﻿
using Schemssystem_modell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schemasystem_funktionalliet
{
    public class InMemoryDatabase
    {
        public List<Person> Personer { get; set; } = new List<Person>();
        public List<Kurs> Kurser { get; set; } = new List<Kurs>();
        public List<Schema> Schemar { get; set; } = new List<Schema>();
        public List<SchemaRad> SchemaRader { get; set; } = new List<SchemaRad>();
        public List<Lärare> Lärarer { get; set; } = new List<Lärare>();
        public List<KursTillfälle> KursTillfäller { get; set; } = new List<KursTillfälle>();
        public List<Lokal> Lokaler { get; set; } = new List<Lokal>();
        public List<Utibildning> Utibildninger { get; set; } = new List<Utibildning>();


        public List<Lärare> HämtaLärare()
        {
            List<Lärare> Lärarer = new List<Lärare>()
            {
                new Lärare ("V123", "Varto", "Kaka", "varto.kaka@hotmail.com", 072458448, "VK123"),
                new Lärare ("O123", "Osama", "Alhusasin","osama.alhussain@hotmail.com", 0724584765, "OA123")
               

            };
            foreach (var lärare in Lärarer)
            {
                Console.WriteLine("ID :{0}  , Name : {1} {2} , E-amil: {3}, Phone: {4}, signatur: {5}",
                    lärare.LärareID, lärare.FörNamn, lärare.EfterNamn, lärare.Epost, lärare.TelefonNr, lärare.Signatur);
            }

            return Lärarer;
        }
        public List<Schema> HämtaSchemar()
        {
            List<Schema> Schemar = new List<Schema>()
            {
                //new Schema(){SchemaNamn = "Schema1", SchemaRader = HämtaSchemaRader() },
                //new Schema(){SchemaNamn = "Schema2", SchemaRader = HämtaSchemaRader() },
                //new Schema(){SchemaNamn = "Schema3", SchemaRader = HämtaSchemaRader() },
                //new Schema(){SchemaNamn = "Schema4", SchemaRader = HämtaSchemaRader() },
            };

           
            return Schemar;
        }
        //  method that returns a list ofSchemaRader
        public List<SchemaRad> HämtaSchemaRader()
        {
            List<SchemaRad> SchemaRader = new List<SchemaRad>()
            {
                //new SchemaRad() { StartDatum = new DateTime(2021, 9, 11), SlutDatum = new DateTime(2021, 9, 11), Moment = "tenta" },
                //new SchemaRad() { StartDatum = new DateTime(2021, 9, 11), SlutDatum = new DateTime(2021, 9, 11), Moment = "tenta" },

            };

           
            return SchemaRader;
        }

        public List<Kurs> HämtaKurser()
        {
            List<Kurs> Kurser = new List<Kurs>()
            {
                new Kurs(){KursNamn ="C#", Akronym ="C#123"},
                new Kurs(){KursNamn ="C#", Akronym ="C#123"}
            };
            foreach (var kurs in Kurser)
            {
                Console.WriteLine("KursNamn :{0}  , Akronym : {1} ",
                    kurs.KursNamn, kurs.Akronym);
            }
            return Kurser;
        }

        public List<Utibildning> HämtaUtbildningar()
        {
            List<Utibildning> Utibildninger = new List<Utibildning>()
            {
                //new Utibildning(){UtbildningsNamn = "C#", Akronym = "C#", Kurser = HämtaKurser() },
                //new Utibildning(){UtbildningsNamn = "C#", Akronym = "C#", Kurser = HämtaKurser() },
                //new Utibildning(){UtbildningsNamn = "C#", Akronym = "C#", Kurser = HämtaKurser() },
                //new Utibildning(){UtbildningsNamn = "C#", Akronym = "C#", Kurser = HämtaKurser() },
            };

            foreach (var utibildning in Utibildninger)
            {
                Console.WriteLine("UtbildningsNamn :{0}  , Akronym : {1} , Kurser: {2}",
                    utibildning.UtbildningsNamn, utibildning.Akronym, utibildning.Kurser);
            }
            return Utibildninger;
        }
        public List<KursTillfälle> HämtaKursTillfällen()
        {
            List<KursTillfälle> KursTillfäller = new List<KursTillfälle>()
            {
                //new KursTillfälle(){StartPeriod = new DateTime(2021,09,01), SlutPeriod = new DateTime(2021,12,01)},
                //new KursTillfälle(){StartPeriod = new DateTime(2021,09,01), SlutPeriod = new DateTime(2021,12,01)},

            };
           

            return KursTillfäller;

        }
        public List<Lokal> HämtaLokaler()
        {
            List<Lokal> Lokaler = new List<Lokal>()
            {
                new Lokal( ){LokalNummer = "A123", Plaster = 200},
               new Lokal {LokalNummer = "A123", Plaster = 200},
                new Lokal{LokalNummer = "A123", Plaster = 200}

            };

           
            return Lokaler;
        }




        public static void WelcomeMenu()
        {
            Console.Beep();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n         Welcome to School System" +
            "\n         ----------------------------" +
            "\n                 _ _.-'`-._ _\r\n                ;.'________'.;\r\n     _________n.[____________].n_________\r\n    |\"\"_\"\"_\"\"_\"\"||==||==||==||\"\"_\"\"_\"\"_\"\"]\r\n    |\"\"\"\"\"\"\"\"\"\"\"||..||..||..||\"\"\"\"\"\"\"\"\"\"\"|\r\n    |LI LI LI LI||LI||LI||LI||LI LI LI LI|\r\n    |.. .. .. ..||..||..||..||.. .. .. ..|\r\n    |LI LI LI LI||LI||LI||LI||LI LI LI LI|\r\n ,,;;,;;;,;;;,;;;,;;;,;;;,;;;,;;,;;;,;;;,;;,,\r\n;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;");

            Console.WriteLine("\nPress Enter to Log in!");
            Console.ReadKey();
        }

    }
}
