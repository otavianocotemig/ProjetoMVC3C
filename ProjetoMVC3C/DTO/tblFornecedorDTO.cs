﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMVC3C.DTO
{
    class tblFornecedorDTO
    {
        private int id;
        private String nome, email, telefone;

        public int Id { get => id; set => id = value; }

        public string Nome
        {
            set
            {
                if (value != string.Empty)
                {
                    this.nome = value;
                }
                else
                {
                    throw new Exception("O campo Nome é obrigatório.");
                }
            }
            get { return this.nome; }
        }

        public string Email
        {
            set
            {
                if (value != string.Empty)
                {
                    this.email = value;
                }
                else
                {
                    throw new Exception("O campo Email é obrigatório.");
                }
            }
            get { return this.email; }
        }

        public string Telefone { get => telefone; set => telefone = value; }
       
    }
}
