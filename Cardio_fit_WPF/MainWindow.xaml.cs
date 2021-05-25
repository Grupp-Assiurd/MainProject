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

namespace Cardio_fit_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(cbxScelta.SelectedIndex == 0)
            {
                BattitiMaxMin MaxMin = new BattitiMaxMin();
                MaxMin.Show();
                cbxScelta.SelectedIndex = -1;
            }
            else if (cbxScelta.SelectedIndex == 1)
            {
                BattitiRiposo1 BatRip = new BattitiRiposo1();
                BatRip.Show();
                cbxScelta.SelectedIndex = -1;
            }
            else if (cbxScelta.SelectedIndex == 2)
            {
                CalorieBruciate calorieBruciate = new CalorieBruciate();
                calorieBruciate.Show();
                cbxScelta.SelectedIndex = -1;
            }
            else if (cbxScelta.SelectedIndex == 3)
            {
                SpesaEnergetica spesaEnergetica = new SpesaEnergetica();
                spesaEnergetica.Show();
                cbxScelta.SelectedIndex = -1;
            }
            else if (cbxScelta.SelectedIndex == 4)
            {
                MediaBatGiornaliera mediaBatGiornaliera = new MediaBatGiornaliera();
                mediaBatGiornaliera.Show();
                cbxScelta.SelectedIndex = -1;
            }
            else if (cbxScelta.SelectedIndex == 5)
            {
                BattitiRip2 battitiRip2 = new BattitiRip2();
                battitiRip2.Show();
                cbxScelta.SelectedIndex = -1;
            }
            else if (cbxScelta.SelectedIndex == 6)
            {
                VariabilitaBattiti variabilitaBattiti = new VariabilitaBattiti();
                variabilitaBattiti.Show();
                cbxScelta.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Scegli qualcosa prima di premere il bottone", "Attenzione", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
