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
using System.Windows.Navigation;
using System.Windows.Shapes;

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



        //Declaratie van de list van string arrays met de naam 'adressen'

        int lstAdressenIndex;

        public MainWindow()
        {
            InitializeComponent();

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


        }

        void MaakAdresInfo()
        {

        }

        void KoppelLijst()
        {

        }

        //Structuur array:
        //Straat - Huisnummer - Busnummer - Postcode - Gemeente

        private void btnOpslaan_Click(object sender, RoutedEventArgs e)
        {


        }


        private void lstAdressen_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            lstAdressenIndex = lstAdressen.SelectedIndex;

        }
    }
}
