﻿namespace APIVENDAS.Models
{
    public class Cliente
    {


        public int Id { get; set; }
        public string Nome { get; set; }
        public int EnderecoId { get; set; }
        public string ComplementoEndereco { get; set; }

        public List<TelefoneCliente> TelefonesCliente { get; set; }


    }
}
