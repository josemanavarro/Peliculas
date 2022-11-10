using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
///     Clase que representa una película.
/// </summary>
/// <remarks>
///     Implementa la interfaz de notificación de cambios.
/// </remarks>
namespace Peliculas.DTO
{
    public class Pelicula : INotifyPropertyChanged
    {
        private string titulo;
        public string Titulo {
            get 
            {
                return titulo;
            } 
            set
            {
                titulo = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Titulo"));
            }
        }
        private string genero;
        public string Genero {
            get { 
                return genero; 
            } 
            set { 
                genero = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Genero"));
            }
        }
        private DateTime estreno;
        public DateTime Estreno { 
            get
            {
                return estreno;
            } 
            set
            {
                estreno = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Estreno"));
            }
        }

        public Pelicula(string titulo, string genero, DateTime estreno)
        {
            this.titulo = titulo;
            this.genero = genero;
            this.estreno = estreno;
        }

        public Pelicula()
        {
            this.estreno = DateTime.Now;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public override string ToString()
        {
            return this.titulo + " " + this.genero + " " + this.estreno;
        }
    }
}
