using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using CardioLibrary;

namespace Cardio_fit_WPF
{
    /// <summary>
    /// Logica di interazione per BattitiRip2.xaml
    /// </summary>
    public partial class BattitiRip2 : Window
    {
        public BattitiRip2()
        {
            InitializeComponent();
        }

        private void btn_cerca_Click(object sender, RoutedEventArgs e)
        {
            bool risposta = false;
            if (int.Parse(txt_battitoDaRicercare.Text) >= 60 && int.Parse(txt_battitoDaRicercare.Text) <= 100)
            {
                risposta = DataCardio.BattitiRiposoFile(int.Parse(txt_battitoDaRicercare.Text));
            }
            else
            {
                MessageBox.Show("attenzione inserire un valore compreso tra 60 e 100", "attenzione", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            if (risposta)
                lbl_risultatoRicerca.Content = "il battito inserito è presente nel file";
            else
                lbl_risultatoRicerca.Content = "il battito inserito non è presente nel file";


        }
    }
}
