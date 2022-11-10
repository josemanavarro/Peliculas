using Peliculas.DTO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peliculas.Logica
{
    public class LogicaNegocio
    {
        public ObservableCollection<Pelicula> listaPeliculas { get; set; }

        public LogicaNegocio()
        {
            listaPeliculas = new ObservableCollection<Pelicula>();
            listaPeliculas.Add(new Pelicula("Alien", "Terror", new DateTime(1980, 1, 1)));
        }
        public void addPelicula(Pelicula pelicula)
        {
            listaPeliculas.Add(pelicula);
        }
        public void modificarPelicula(Pelicula pelicula, int posicion)
        {
            listaPeliculas[posicion] = pelicula;
        }
    }
}
