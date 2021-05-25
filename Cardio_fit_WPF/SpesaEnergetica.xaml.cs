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
    /// Logica di interazione per SpesaEnergetica.xaml
    /// </summary>
    public partial class SpesaEnergetica : Window
    {
        public SpesaEnergetica()
        {
            InitializeComponent();
        }

        private void btn_calcola_Click(object sender, RoutedEventArgs e)
        {
            if (double.Parse(txt_Km.Text) > 0 && double.Parse(txt_peso.Text) > 10)
            {
                if (rdb_camminata.IsChecked == true)
                    lbl_risultato.Content = DataCardio.CorsaCamminata(double.Parse(txt_peso.Text), double.Parse(txt_Km.Text), "camminata") + " cal";
                else
                    lbl_risultato.Content = DataCardio.CorsaCamminata(double.Parse(txt_peso.Text), double.Parse(txt_Km.Text), "corsa") + " cal";
                txt_Km.Clear();
                txt_peso.Clear();
            }
            else
            {
                MessageBox.Show("attenzione inverire valori validi", "Attenzione", MessageBoxButton.OK, MessageBoxImage.Error);
                txt_Km.Clear();
                txt_peso.Clear();
            }
        }
    }
}
