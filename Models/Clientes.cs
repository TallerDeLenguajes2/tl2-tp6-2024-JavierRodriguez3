using System;

namespace clientes{
    public class Clientes{
        private int clienteId;
        private string nombreCliente ;
        private string emailCliente;
        private int telefonoCliente;


        public int ClienteId { get => clienteId; set => clienteId = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string EmailCliente { get => emailCliente; set => emailCliente = value; }
        public int TelefonoCliente { get => telefonoCliente; set => telefonoCliente = value; }
        public Clientes(int clienteId, string nombreCliente, string emailCliente, int telefonoCliente)
        {
            this.ClienteId = clienteId;
            this.NombreCliente = nombreCliente;
            this.EmailCliente = emailCliente;
            this.TelefonoCliente = telefonoCliente;
        }
    }
}