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
    /// Logica di interazione per CalorieBruciate.xaml
    /// </summary>
    public partial class CalorieBruciate : Window
    {
        public CalorieBruciate()
        {
            
            InitializeComponent();
        }
        

        private void btnCalcola_Click(object sender, RoutedEventArgs e)
        {
            if (txtBattiti.Text != "" && txtEta.Text != "" && txtPeso.Text != "" && txtDurata.Text != "")
            {
                try
                {
                    int battiti = int.Parse(txtBattiti.Text);
                    int eta = int.Parse(txtEta.Text);
                    double durata = double.Parse(txtDurata.Text);
                    float peso = float.Parse(txtPeso.Text);
                    bool isUomo = false;
                    if (rbtUomo.IsChecked == true)
                    {
                        isUomo = true;
                    }
                    else
                    {
                        isUomo = false;
                    }
                    double calorie = DataCardio.CalorieBruciate(isUomo, battiti, peso, eta, durata);
                    lblStampa.Content = $"hai bruciato : {calorie} calorie";

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
