using Classi_Personale;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Personale
{
    /// <summary>
    /// Logica di interazione per FormAzienda.xaml
    /// </summary>
    public partial class FormAzienda : Window
    {
        public FormAzienda(PersonaleAziendale pa)
        {
            InitializeComponent();
            this.pa = pa;
        }
        private string[] qualifiche = new string[] { "Dirigente", "Quadro", "Amministrativo", "Operaio" };

        private PersonaleAziendale pa;

        private void btn_inserisci_Click(object sender, RoutedEventArgs e)
        {  
            lsb_riepilogo.Items.Add(pa.ToString());
        }
    }
}
