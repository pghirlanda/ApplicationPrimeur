using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LogicielCaisse
{
    public partial class Form1 : Form
    {
        private LecturePrix fichier;
        private Dictionary<string, string> data;
        private Ticket ticket;
        private string nomTicket;
        private CalculPrix calcul;
        private AccessControl acces;

        public Form1()
        {
            InitializeComponent();
            fichier = new LecturePrix();
            data = fichier.LectureFichier(fichierLabel.Text);
            ticket = new Ticket();
            calcul = new CalculPrix();
            acces = new AccessControl();
        }

        private void importerPrixButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            fichier.LectureFichier(openFileDialog1.FileName);
            fichierLabel.Text = openFileDialog1.FileName;

            importerPrixButton.Visible = false;
            nomTextBox.Text = "";
            mdpTextBox.Text = "";
        }

        private void nouveauPanierButton_Click(object sender, EventArgs e)
        {
            produitComboBox.DataSource = new BindingSource(data, null);
            produitComboBox.DisplayMember = "Key";
            produitComboBox.ValueMember = "Value";

            if (poidsTextBox.ReadOnly == false)
            {
                File.Delete(nomTicket);
                recapitulatifLabel.Text = "";
                poidsTextBox.Text = "";
                totalTextBox.Text = "0";
            }
            
            poidsTextBox.ReadOnly = false;

            nomTicket = ticket.CreationTicket();
        }

        private void validerButton_Click(object sender, EventArgs e)
        {
            double total = double.Parse(totalTextBox.Text);
            string recapitulatif = recapitulatifLabel.Text;

            if (poidsTextBox.Text == "")
            {
                MessageBox.Show("Veuillez rentrer un poids svp.");
            }
            else
            {
                total += calcul.calcul(produitComboBox.Text, double.Parse(poidsTextBox.Text), data);
                totalTextBox.Text = total.ToString();

                recapitulatifLabel.Text = recapitulatif + "\n" + poidsTextBox.Text + " kg de " + produitComboBox.Text.ToLower();

                ticket.Ecriture(produitComboBox.Text, poidsTextBox.Text, calcul.calcul(produitComboBox.Text, double.Parse(poidsTextBox.Text), data).ToString(), nomTicket);
            }
        }

        private void terminerButton_Click(object sender, EventArgs e)
        {
            ticket.Fermeture(nomTicket, Double.Parse(totalTextBox.Text));

            System.Diagnostics.ProcessStartInfo ouvertureTicket = new System.Diagnostics.ProcessStartInfo(nomTicket);
            System.Diagnostics.Process.Start(ouvertureTicket);

            poidsTextBox.ReadOnly = true;
            poidsTextBox.Text = "";
            recapitulatifLabel.Text = "";
            totalTextBox.Text = "0";
        }

        private void connectionButton_Click(object sender, EventArgs e)
        {
            if (acces.CheckNom(nomTextBox.Text) == true){
                if (acces.CheckMdp(nomTextBox.Text, mdpTextBox.Text) == false)
                {
                    MessageBox.Show("Mot de passe incorrect.");
                    mdpTextBox.Text = "";
                }
                else
                {
                    importerPrixButton.Visible = true;
                }
                
            }
            else
            {
                MessageBox.Show("Accès refusé.");
                nomTextBox.Text = "";
                mdpTextBox.Text = "";
            }
        }
    }
}
