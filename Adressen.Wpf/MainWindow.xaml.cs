using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;

namespace Adressen.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //Structuur array:
        //Straat - Huisnummer - Busnummer - Postcode - Gemeente

        const string adres1 = "Seringendreef;8;;8300;KNOKKE-HEIST";
        const string adres2 = "Kuiperscheeweg; 9; ; 8957; MESEN";
        const string adres3 = "Oude Zak; 25; ; 8800; ROESELARE";
        const string adres4 = "Oostendelaan;33;0303;8980;ZONNEBEKE";






        List<string[]> adressen;
        List<string> adresInfo;

        //Declaratie van de list van string arrays met de naam 'adressen'

        int lstAdressenIndex;

        public MainWindow()
        {
            InitializeComponent();

            adressen = new List<string[]>();
            //Instantiëring van de list van string arrays met de naam 'adressen'
            MaakAdressen();
            MaakAdresInfo();
        }

        void MaakAdressen()
        {
            VoegAdresToe(adres1);
            VoegAdresToe(adres2);
            VoegAdresToe(adres3);
            VoegAdresToe(adres4);
        }

        void VoegAdresToe(string csvAdres)
        {
            string[] adres;
            adres = csvAdres.Split(';');
            adressen.Add(adres);

        }

        void MaakAdresInfo()
        {
            adresInfo = new List<string>();

            //Elementen met index 0 en 4 uit de array worden opgehaald.
            //Dit gebeurt voor elk element uit de List
            adresInfo.Add($"{adressen[0][0]} - {adressen[0][4]}");
            adresInfo.Add($"{adressen[1][0]} - {adressen[1][4]}");
            adresInfo.Add($"{adressen[2][0]} - {adressen[2][4]}");
            adresInfo.Add($"{adressen[3][0]} - {adressen[3][4]}");

            KoppelLijst();
        }

        void KoppelLijst()
        {
            lstAdressen.ItemsSource = adresInfo;
            lstAdressen.Items.Refresh();

        }

        //Structuur array:
        //Straat - Huisnummer - Busnummer - Postcode - Gemeente

        private void btnOpslaan_Click(object sender, RoutedEventArgs e)
        {
            adressen[lstAdressenIndex][0] = txtStraat.Text;
            adressen[lstAdressenIndex][1] = txtHuisNr.Text;
            adressen[lstAdressenIndex][2] = txtBus.Text;
            adressen[lstAdressenIndex][3] = txtPostCode.Text;
            adressen[lstAdressenIndex][4] = txtGemeente.Text;
            adresInfo[lstAdressenIndex] = $"{adressen[lstAdressenIndex][0]} - {adressen[lstAdressenIndex][4]}";

            KoppelLijst();

            lstAdressen.SelectedItem = null;

        }

        private void lstAdressen_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (lstAdressen.SelectedItem != null)
            {
                lstAdressenIndex = lstAdressen.SelectedIndex;
                txtStraat.Text = adressen[lstAdressenIndex][0];
                txtHuisNr.Text = adressen[lstAdressenIndex][1];
                txtBus.Text = adressen[lstAdressenIndex][2];
                txtPostCode.Text = adressen[lstAdressenIndex][3];
                txtGemeente.Text = adressen[lstAdressenIndex][4];
                btnOpslaan.IsEnabled = true;
            }
            else
            {
                lstAdressenIndex = -1;
                txtStraat.Text = string.Empty;
                txtHuisNr.Text = string.Empty;
                txtBus.Text = string.Empty;
                txtPostCode.Text = string.Empty;
                txtGemeente.Text = string.Empty;
                btnOpslaan.IsEnabled = false;
            }
        }


        private void btnAnnuleren_Click(object sender, RoutedEventArgs e)
        {
            lstAdressen.SelectedItem = null;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            btnOpslaan.IsEnabled = false;
        }
    }
}

