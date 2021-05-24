using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using CardioLibrary;
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
    /// Logica di interazione per BattitiRiposo1.xaml
    /// </summary>
    public partial class BattitiRiposo1 : Window
    {
        public BattitiRiposo1()
        {
            InitializeComponent();
        }

        private void btnCalcola_Click(object sender, RoutedEventArgs e)
        {
            if (txtBattiti.Text != "")
            {
                try
                {
                    int battiti = int.Parse(txtBattiti.Text);
                    string Frequenza = DataCardio.BattitiRiposo(battiti);
                    lblStampa.Content = Frequenza;
                }
                catch (Exception ex)
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
