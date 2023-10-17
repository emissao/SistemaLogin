﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLogin
{
    static class CadastroUsuarios
    {
        private static Usuario[] usuarios = 
        { 
            new Usuario()  {Nome = "Emerson",Senha ="abc123"},
            new Usuario() {Nome ="Danny", Senha = "123abc"},
            new Usuario() {Nome ="Bruno", Senha = "abcd12345"},
        };
        private static Usuario _userLogado = null; 
        public static Usuario UsuarioLogado
        {
            get { return _userLogado; }
            private set { _userLogado = value; }
        }
        public static bool Login(string nome, string senha)
        {
            foreach(Usuario usuario in usuarios) 
            {
                if(usuario.Nome == nome && usuario.Senha == senha)
                {
                    UsuarioLogado = usuario;
                    return true;
                }
            }
            return false;
        }
    }
}
