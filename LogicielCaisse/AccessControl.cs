using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicielCaisse
{
    class AccessControl
    {
        private DataImport loginMdp;

        public AccessControl()
        {
            loginMdp = new DataImport();
        }

        public Boolean CheckNom(String nom)
        {
            Boolean test = false;
            for (int i = 0; i < loginMdp.lectureFichier().Count; i++)
            {
                if (loginMdp.lectureFichier().ContainsKey(nom.ToLower()) == true)
                {
                    test = true;
                }
            }

            return test;
        }

        public Boolean CheckMdp(String nom, String mdp)
        {
            Boolean resultat = false;

            for (int i = 0; i < loginMdp.lectureFichier().Count; i++)
            {
                if (loginMdp.lectureFichier()[nom.ToLower()] == mdp)
                {
                    resultat = true;
                }
            }
            return resultat;
        }
    }
}
