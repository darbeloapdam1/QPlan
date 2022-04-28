using System;
using System.Collections.Generic;
using System.Text;

namespace QPlan.Models
{
    public class SearchParameters
    {
        Dictionary<string, bool> categorias = new Dictionary<string, bool>();
        Dictionary<string, bool> tipoLugar = new Dictionary<string, bool>();

        string[] categoriasNombre = { "Deporte", "Concierto", "Musical", "Fiesta", "Teatro", "Cultura"};
        string[] tipoLugarNombres = { "Cubierto", "Al aire libre", "Por la calle", "Fuera de la ciudad"};

        public SearchParameters()
        {
            foreach(string cat in categoriasNombre)
            {
                categorias.Add(cat, false);
            }
            foreach(string lug in tipoLugarNombres)
            {
                tipoLugar.Add(lug, false);
            }
        }

        public Dictionary<string, bool> Categorias
        {
            get { return categorias; }
        }
        public Dictionary<string, bool> TipoLugar
        {
            get { return tipoLugar; }
        }
        public bool Deporte
        {
            get {
                return Categorias["Deporte"];
            }
            set
            {
                Categorias["Deporte"] = value;
            }
        }
        public bool Concierto
        {
            get { return Categorias["Concierto"]; }
            set { Categorias["Concierto"] = value; }
        }
        public bool Musical
        {
            get { return Categorias["Muscical"]; }
            set { Categorias["Muscial"] = value; }
        }
        public bool Fiesta
        {
            get { return Categorias["Fiesta"]; }
            set { Categorias["Fiesta"] = value; }
        }
        public bool Teatro
        {
            get { return Categorias["Teatro"]; }
            set { Categorias["Teatro"] = value; }
        }
        public bool Cultura
        {
            get { return Categorias["Cultura"]; }
            set { Categorias["Cultura"] = value; }
        }
        public bool Cubierto
        {
            get { return TipoLugar["Cubierto"]; }
            set { TipoLugar["Cubierto"] = value; }
        }
        public bool AireLibre
        {
            get { return TipoLugar["Al aire libre"]; }
            set
            {
                TipoLugar["Al aire libre"] = value;
            }
        }
        public bool PorCalle
        {
            get { return TipoLugar["Por la calle"]; }
            set { TipoLugar["Por la calle"] = value; }
        }
        public bool FueraCiudad
        {
            get { return TipoLugar["Fuera de la ciudad"]; }
            set { TipoLugar["Fuera de la ciudad"] = value; }
        }
    }
}
