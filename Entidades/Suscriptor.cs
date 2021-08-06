using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Suscriptor
    {
        private int IdSuscriptor;
        private string Nombre;
        private string Apellido;
        private long NumeroDocumento;
        private int TipoDocumento;
        private string Direccion;
        private string Telefono;
        private string Email;
        private string NombreUsuario;
        private string Password;

        public int IdSuscriptor1 { get => IdSuscriptor; set => IdSuscriptor = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Apellido1 { get => Apellido; set => Apellido = value; }
        public long NumeroDocumento1 { get => NumeroDocumento; set => NumeroDocumento = value; }
        public int TipoDocumento1 { get => TipoDocumento; set => TipoDocumento = value; }
        public string Direccion1 { get => Direccion; set => Direccion = value; }
        public string Telefono1 { get => Telefono; set => Telefono = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string NombreUsuario1 { get => NombreUsuario; set => NombreUsuario = value; }
        public string Password1 { get => Password; set => Password = value; }
    }
}
