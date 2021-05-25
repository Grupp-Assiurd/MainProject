﻿using System;
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
    /// Logica di interazione per MediaBatGiornaliera.xaml
    /// </summary>
    public partial class MediaBatGiornaliera : Window
    {
        public MediaBatGiornaliera()
        {
            InitializeComponent();
        }

        private void btn_MostraMedia_Click(object sender, RoutedEventArgs e)
        {
            lbl_RisultatoMedia.Content = DataCardio.LetturafileMediaGiornaliera();
        }
    }
}
