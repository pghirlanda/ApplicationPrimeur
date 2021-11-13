using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicielCaisse
{
    class CalculPrix
    {
        public CalculPrix()
        {

        }

        public double calcul(string produit, double poids, Dictionary<string, string> data)
        {
            return poids*double.Parse(data[produit]);
        }
    }
}
