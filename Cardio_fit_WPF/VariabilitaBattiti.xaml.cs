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
    /// Logica di interazione per VariabilitaBattiti.xaml
    /// </summary>
    public partial class VariabilitaBattiti : Window
    {
        public VariabilitaBattiti()
        {
            InitializeComponent();
        }

        private void Btn_MostraVariabiltà_Click(object sender, RoutedEventArgs e)
        {
            Lbl_risultatoVariabiltà.Content = DataCardio.Variabilità() + "ms";
        }
    }
}
