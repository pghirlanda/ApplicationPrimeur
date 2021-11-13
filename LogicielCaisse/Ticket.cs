using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;

namespace LogicielCaisse
{
    class Ticket
    {
        public Ticket()
        {
        }

        public string CreationTicket()
        {
            
            string filename = "ticket_" + DateTime.Now.ToString("dd-MM-yyyy") + "_" + DateTime.Now.ToString("HH-mm-ss") + ".txt";
            try
            {
                File.Create(filename).Close();
                string[] lines = { "--------------------------------", 
                                   "Primeur de la côte",
                                   "Avenue de beaurivage",
                                   "64200 Biarritz", 
                                   "le " + DateTime.Now.ToString("dd/MM/yyyy"), 
                                   "à " + DateTime.Now.ToString("HH:mm") + "\n"};
                File.WriteAllLines(filename, lines);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return filename;
        }

        public void Ecriture(string produit, string poids, string prix, string fichier)
        {
            string filename = fichier;
            string ligne = produit + " - " + poids + " kg : " + prix + " €";

            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename, true))
                {
                    file.WriteLine(ligne);
                    file.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void Fermeture(string fichier, double total)
        {
            string filename = fichier;
            string ligne = "\nTOTAL TTC : " + total + " €\nTVA : " + total * 0.2 + " €\nMerci de votre visite et ...\n... Gardez la pêche !\n--------------------------------";

            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename, true))
                {
                    file.WriteLine(ligne);
                    file.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
