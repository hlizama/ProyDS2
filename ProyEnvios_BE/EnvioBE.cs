using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyEnvios_BE
{
    public class EnvioBE
    {
        private string _correo;
        public string Correo
        {
            get { return _correo; }
            set { _correo = value; }
        }

        private string _idEnvio;
        public string IDEnvio
        {
            get { return _idEnvio; }
            set { _idEnvio = value; }
        }

        private string _nombre_cliente;
        public string Nombre_Cliente
        {
            get { return _nombre_cliente; }
            set { _nombre_cliente = value; }
        }

        private string _placa;
        public string Placa
        {
            get { return _placa; }
            set { _placa = value; }
        }
        //**
        private string _tipo_servicio;
        public string Tipo_Servicio
        {
            get { return _tipo_servicio; }
            set { _tipo_servicio = value; }
        }
        //***
        private string _estatus;
        public string Estatus
        {
            get { return _estatus; }
            set { _estatus = value; }
        }

        private System.DateTime _fechaEstimada;
        public System.DateTime FechaEstimada
        {
            get { return _fechaEstimada; }
            set { _fechaEstimada = value; }
        }

        //Consultas ConsEnvioCiudad
        //----------------------------------------------
        private string _razon_social;
        public string Razon_Social
        {
            get { return _razon_social; }
            set { _razon_social = value; }
        }

        private string _distrito;
        public string Distrito
        {
            get { return _distrito; }
            set { _distrito = value; }
        }

        private string _direccion;
        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        //-----ConsultarEmpleadoEnvioFecha
        //-----------------------

        private string _descripcion;
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        private string _tipoCargoNombre;
        public string TCNombre
        {
            get { return _tipoCargoNombre; }
            set { _tipoCargoNombre = value; }
        }

        private string _tipoServiNombre;
        public string TSNombre
        {
            get { return _tipoServiNombre; }
            set { _tipoServiNombre = value; }
        }

        private string _ciNombre;
        public string CINombre
        {
            get { return _ciNombre; }
            set { _ciNombre = value; }
        }

        private int _peso;
        public int Peso
        {
            get { return _peso; }
            set { _peso = value; }
        }
    }
}
