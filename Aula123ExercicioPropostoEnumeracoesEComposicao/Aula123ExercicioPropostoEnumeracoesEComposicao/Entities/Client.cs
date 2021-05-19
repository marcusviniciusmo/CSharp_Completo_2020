﻿using System;
using System.Text;

namespace Aula123ExercicioPropostoEnumeracoesEComposicao.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client()
        {
        }

        public Client(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            str.Append($"{Name}, ({BirthDate.ToString("dd/MM/yyyy")})");
            str.Append($" - {Email}");

            return str.ToString();
        }
    }
}
