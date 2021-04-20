using Classi_Personale;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Personale
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LeggiFile();
            txt_cdf.Focus();
        }
        string[] tipo = new string[] { "Aziendale", "SubFornitore", "Fornitore", "Consulente" };
        private HashSet<string> codicifiscali = new HashSet<string>();
        List<Persona> persone = new List<Persona>();
        private void ButtonInserisci_Click(object sender, RoutedEventArgs e)
        {
            switch (cmb_tipo.SelectedIndex)
            {
                case 0:
                    if (txt_cognome.Text != "" && txt_nome.Text != "" && txt_cdf.Text != "")
                    {
                        if (codicifiscali.Contains(txt_cdf.Text))
                        {
                            PersonaleAziendale pa = new PersonaleAziendale(txt_nome.Text, txt_cognome.Text, txt_cdf.Text, cmb_tipo.SelectedItem.ToString());
                            FormAzienda Aziendale = new FormAzienda(pa);
                            Aziendale.ShowDialog();
                            codicifiscali.Add(pa.CodiceFiscale);
                        }
                        else
                        {
                            MessageBox.Show("Attenzione", "Il codice fiscale è già stato inseito!", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Attenzione", "Mancano alcuni dati", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    break;
                case 1:
                    MessageBox.Show("Informazione", "Work in progress", MessageBoxButton.OK, MessageBoxImage.Information);
                    break;
                case 2:
                    MessageBox.Show("Informazione", "Work in progress", MessageBoxButton.OK, MessageBoxImage.Information);
                    break;
                case 3:
                    MessageBox.Show("Informazione", "Work in progress", MessageBoxButton.OK, MessageBoxImage.Information);
                    break;
                case -1:
                    MessageBox.Show("Attenzione", "Inserisci una tipologia", MessageBoxButton.OK, MessageBoxImage.Error);
                    break;

            }


        }
        private void cmb_tipo_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (string s in tipo)
            {
                cmb_tipo.Items.Add(s);
            }
        }
        private void LeggiFile()
        {
            string line;
            StreamReader sr = new StreamReader(Costanti.DIRECTORY + Costanti.FILE);

            do
            {
                line = sr.ReadLine();
                if (line != null)
                {
                    string[] personale = line.Split(';');
                    codicifiscali.Add(personale[0]);
                }
            } while (line != null);

            sr.Close();
        }
    }
}

