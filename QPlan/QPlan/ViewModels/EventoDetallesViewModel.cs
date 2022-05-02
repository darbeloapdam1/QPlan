using QPlan.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace QPlan.ViewModels
{
    public class EventoDetallesViewModel : INotifyPropertyChanged
    {
        public bool isBusy = false;
        public Evento evento;

        public Command LoadEventoCommand { get; }
        public EventoDetallesViewModel(Evento evento)
        {            
            //LoadEventoCommand = new Command(async () => await ExecuteLoadEventoAsync());
            Evento = evento;
        }

        public Evento Evento
        {
            get { return evento; }
            set
            {
                this.evento = value;
                OnPropertyChanged("Evento");
            }
        }

        public bool IsBusy
        {
            get { return isBusy; }
            set
            {
                this.isBusy = value;
                OnPropertyChanged("IsBusy");
            }
        }

        public int EventoId
        {
            get { return Evento.id; }
            set
            {
                Evento.id = value;
                OnPropertyChanged("EventoId");
            }
        }

        public string Titulo
        {
            get { return Evento.nombre; }
            set { Evento.nombre = value; }
        }

        public string Lugar
        {
            get { return Evento.nombre_establecimiento; }
            set { Evento.nombre_establecimiento = value; }
        }

        public string Descripcion
        {
            get { return Evento.descripcion; }
            set { Evento.descripcion = value; }
        }

        public DateTime DiaHoraRealizacion
        {
            get { return Evento.diaHoraRealizacion; }
            set { Evento.diaHoraRealizacion = value; }
        }

        public string Hora
        {
            get { return ""; }
        }

        public string Fecha
        {
            get { return ""; }
        }

        public double Precio
        {
            get { return Evento.precio; }
            set { Evento.precio = value; }
        }

        public string PrecioEuros
        {
            get { return Evento.precio + "€"; }
        }

        public string Foto
        {
            get { return Evento.foto; }
            set { Evento.foto = value; }
        }

        public void OnAppearing()
        {
            IsBusy = true;
        }

        //private async Task ExecuteLoadEventoAsync()
        //{
            
        //}

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
