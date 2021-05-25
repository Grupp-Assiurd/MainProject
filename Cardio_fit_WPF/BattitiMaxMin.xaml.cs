using System;
using CardioLibrary;
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

namespace Cardio_fit_WPF
{
    /// <summary>
    /// Logica di interazione per BattitiMaxMin.xaml
    /// </summary>
    public partial class BattitiMaxMin : Window
    {
        public BattitiMaxMin()
        {
            InitializeComponent();
        }

        private void btnCalcola_Click(object sender, RoutedEventArgs e)
        {
            if(txtEta.Text != "")
            {
                try
                {
                    int eta = int.Parse(txtEta.Text);
                    if (eta <= 0 || eta > 120)
                    {
                        MessageBox.Show("Attenzione eta non valida", "Attenzione", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                    else
                    {
                        string freqMaxMin = DataCardio.btmMaxMin(eta);
                        lblStampa.Content = freqMaxMin;
                    }
                   
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Attenzione", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else
            {
                MessageBox.Show("Inserire tutti i campi", "Attenzione", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
