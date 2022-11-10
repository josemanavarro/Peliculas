using Peliculas.DTO;
using Peliculas.Logica;
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
using System.Windows.Shapes;

namespace Peliculas
{
    /// <summary>
    /// Lógica de interacción para DialogoPelicula.xaml
    /// </summary>
    public partial class DialogoPelicula : Window
    {
        private LogicaNegocio logicaNegocio;
        private Pelicula pelicula;
        private int indice;
        private bool modificar;      

        public DialogoPelicula(LogicaNegocio logicaNegocio)
        {
            InitializeComponent();
            this.logicaNegocio = logicaNegocio;
            this.pelicula = new Pelicula();
            this.DataContext = pelicula;
            modificar = false;
        }

        public DialogoPelicula(LogicaNegocio logicaNegocio, Pelicula pelicula, int indice)
        {
            InitializeComponent();
            this.logicaNegocio = logicaNegocio;
            this.indice = indice;
            this.pelicula = pelicula;
            this.DataContext = pelicula;
            modificar = true;
        }

        private void ButtonCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ButtonAceptar_Click(object sender, RoutedEventArgs e)
        {
            if (modificar)
                logicaNegocio.modificarPelicula(pelicula, indice);
            else
                logicaNegocio.addPelicula(pelicula);
            this.Close();
        }
    }
}
