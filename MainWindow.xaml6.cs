﻿using System;
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

namespace Exe006
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int atual = DateTime.Now.Year;
            int nasc;
            int.TryParse(txtNascimento.Text, out nasc);
            int idade = atual - nasc;

            lblMsg1.Content = $"Estamos no ano de {atual}.";
            lblMsg2.Content = $"Quem nasceu em {nasc:D}, em {atual} vai ter {idade:D} anos.";

            panResultado.Visibility = Visibility.Visible;
        }
    }
}
