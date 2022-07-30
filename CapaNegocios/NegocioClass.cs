using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaEntidad;
using CapaDato;

namespace CapaNegocios
{
    public class NegocioClass
    {
        DatoClass objDato = new DatoClass();

        public List<EntidadesClass> ListarDatosChoferes(string buscar)
        {
            return objDato.ListarDatosChoferes(buscar);
        }

        public void InsertarDatosChoferes(EntidadesClass dato)
        {
            objDato.InsertarDatosChoferes(dato);
        }

        public void EliminarDatosChoferes(EntidadesClass dato)
        {
            objDato.EliminarDatosChoferes(dato);
        }


        //
        public List<EntidadAutobuses> ListarDatosAutobuses(string buscar)
        {
            return objDato.ListarDatosAutobuses(buscar);
        }       

        public void InsertarDatosAutobuses(EntidadAutobuses dato)
        {
             objDato.InsertarDatosAutobuses(dato);
        }

        public void EliminarDatosAutobuses(EntidadAutobuses dato)
        {
            objDato.EliminarDatosAutobuses(dato);
        }


        //
        public List<EntidadRutas> ListarDatosRutas(string buscar)
        {
            return objDato.ListarDatosRutas(buscar);
        }

        public void InsertarDatosRutas(EntidadRutas dato)
        {
            objDato.InsertarDatosRutas(dato);
        }

        public void EliminarDatosRuta(EntidadRutas dato)
        {
            objDato.EliminarDatosRuta(dato);
        }


        //
        public List<EntidadOcupados> ListarDatosOcupado(string buscar)
        {
            return objDato.ListarDatosOcupado(buscar);
        }

        public void InsertarDatosOcupado(EntidadOcupados dato)
        {
            objDato.InsertarDatosOcupado(dato);
        }

        //





    }
}
