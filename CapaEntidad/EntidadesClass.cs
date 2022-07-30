using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EntidadesClass
    {
        //PROPIEDADES
        private int _IdChofer;
        private string _Nombre;
        private string _Apellido;
        private string _Nacimiento;
        private string _cedula;

        public int Id { get => _IdChofer; set => _IdChofer = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public string Nacimiento { get => _Nacimiento; set => _Nacimiento = value; }
        public string Cedula { get => _cedula; set => _cedula = value; }
    }

    public class EntidadAutobuses
    {
        private int _IdAutobus;
        private string _Marca;
        private string _Modelo;
        private string _Placa;
        private string _Color;
        private string _Año;

        public int Id { get => _IdAutobus; set => _IdAutobus = value; }
        public string Marca { get => _Marca; set => _Marca = value; }
        public string Modelo { get => _Modelo; set => _Modelo = value; }
        public string Placa { get => _Placa; set => _Placa = value; }
        public string Color { get => _Color; set => _Color = value; }
        public string Año { get => _Año; set => _Año = value; }
    }

    public class EntidadRutas
    {
        private int _IdRutas;
        private string _Rutas;

        public int Id { get => _IdRutas; set => _IdRutas = value; }
        public string Rutas { get => _Rutas; set => _Rutas = value; }
    }

    public class EntidadOcupados
    {
        private int _IdOcupados;
        private string _Nombre;
        private string _Cedula;
        private string _Marca;
        private string _Placa;
        private string _Ruta;

        public int Id { get => _IdOcupados; set => _IdOcupados = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Cedula { get => _Cedula; set => _Cedula = value; }
        public string Marca { get => _Marca; set => _Marca = value; }
        public string Placa { get => _Placa; set => _Placa = value; }
        public string Ruta { get => _Ruta; set => _Ruta = value; }
    }
}
