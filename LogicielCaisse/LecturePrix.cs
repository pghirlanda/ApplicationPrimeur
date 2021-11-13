using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace LogicielCaisse
{
    public class LecturePrix
    {
        private Dictionary<string, string> prixProduit;

        public LecturePrix()
        {
           prixProduit = new Dictionary<string, string>();
        }

        public Dictionary<string, string> LectureFichier(string filename)
        {
            prixProduit.Clear();
            try
            {
                string[] split;

                using (StreamReader sr = new StreamReader(filename))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        split = line.Split(';');
                        prixProduit.Add(split[0], split[1]);
                    }

                    sr.Close();
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            return prixProduit;
        }
    }
}