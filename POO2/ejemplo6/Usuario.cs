using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_6
{
    class Usuario
    {
        private List<Factura> listaFacturas = new List<Factura>();
        public string nombre { get; set; }
        public int cedula { get; set; }

        public Usuario() { }
        public void setListaFacturas(List<Factura> _list)
        {
            this.listaFacturas = _list;
        }
        public List<Factura> getListaFacturas()
        {
            return this.listaFacturas;
        }

        public void asignarFactura(Factura _fact){
            this.listaFacturas.Add(_fact);
        }
    }
}