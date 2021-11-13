using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LogicielCaisse
{
    class DataImport
    {
        private Dictionary<string, string> loginMdp;

        public DataImport()
        {
            loginMdp = new Dictionary<string, string>();
        }

        public Dictionary<string, string> lectureFichier()
        {
            loginMdp.Clear();
            try
            {
                string[] split;

                using (StreamReader sr = new StreamReader("userDatabase.csv"))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        split = line.Split(';');
                        loginMdp.Add(split[0], split[1]);
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
            return loginMdp;
        }
}
}
