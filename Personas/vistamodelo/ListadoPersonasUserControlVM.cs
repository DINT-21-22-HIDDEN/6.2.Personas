using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Personas
{
    class ListadoPersonasUserControlVM : ObservableObject
    {
        private PersonasService servicioPersonas;
        
        private ObservableCollection<Persona> listaPersonas;

        public ObservableCollection<Persona> ListaPersonas
        {
            get { return listaPersonas; }
            set { listaPersonas = value; }
        }

        public ListadoPersonasUserControlVM()
        {
            servicioPersonas = new PersonasService();
            ListaPersonas = servicioPersonas.ObtenerPersonas();
        }
    }
}
