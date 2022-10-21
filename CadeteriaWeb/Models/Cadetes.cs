using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadeteriaWeb.Models
{
    public class Cadetes
    {
        
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public List<Pedidos>? ListaPedidos { get; set; }

        public Cadetes(){}

        public Cadetes(int iD, string nombre, string direccion, string telefono)
        {
            ID = iD;
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
            ListaPedidos = new List<Pedidos>();
            
        }
    }
}