using Peliculas.DTO;
using Peliculas.Logica;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Peliculas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>    
    public partial class MainWindow : Window
    {        
        private LogicaNegocio logicaNegocio;
        public MainWindow()
        {
            InitializeComponent();
            logicaNegocio = new LogicaNegocio();
            //this.DataContext = this;
            dataGridPeliculas.DataContext = logicaNegocio;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            DialogoPelicula dPelicula = new DialogoPelicula(logicaNegocio);
            dPelicula.Show();
        }

        private void ButtonModificar_Click(object sender, RoutedEventArgs e)
        {
            Pelicula pelicula = (Pelicula)dataGridPeliculas.SelectedItem;
            DialogoPelicula dPelicula = new DialogoPelicula(logicaNegocio,pelicula, dataGridPeliculas.SelectedIndex);
            dPelicula.Show();
        }
    }
}
