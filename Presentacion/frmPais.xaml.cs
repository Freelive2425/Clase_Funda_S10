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
using System.Windows.Shapes;
using Entidades;
using Negocio;

namespace Presentacion
{
    /// <summary>
    /// Interaction logic for frmPais.xaml
    /// </summary>
    public partial class frmPais : Window
    {
        nPais paisneg = new nPais();
        ePais paisseleccionado;
        int codpais;
       
        public frmPais()
        {
            InitializeComponent();
            MostrarPaises();
        }
        private void MostrarPaises()
        {
            dgpaises.ItemsSource = paisneg.Listarpais();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (txtnombre.Text != "")
            {
                MessageBox.Show(paisneg.RegistrarPais(txtnombre.Text));
                MostrarPaises();
            }
            else
                MessageBox.Show("debe ingresar un nombre");
        }
    }
}
