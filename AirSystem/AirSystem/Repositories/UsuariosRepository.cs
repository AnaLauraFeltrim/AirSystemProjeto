using AirSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirSystem.Repositories
{
    class UsuariosRepository
    {
        private static List<Usuario> Usuarios;

        public UsuariosRepository()
        {
            if (Usuarios == null)
            {
                Usuarios = new List<Usuario>();

                Usuarios.Add(new Usuario
                {
                    Nome = "Ana Laura",
                    Sobrenome = "Feltrim",
                    DataNascimento = Convert.ToDateTime("09/08/2001"),
                    Endereco = "asdfg",
                    Numero = "123",
                    UsuarioNome = "AnaLaura",
                    Senha = "PoteDeFeijao666",
                    TipoUsuario = true 
                });
                Usuarios.Add(new Usuario
                {
                    Nome = "Eduardo",
                    Sobrenome = "Eduardo",
                    DataNascimento = Convert.ToDateTime("13/01/2003"),
                    Endereco = "Itaquera",
                    Numero = "123",
                    UsuarioNome = "Eduardo",
                    Senha = "Eduardo123",
                    TipoUsuario = false 
                });

            }
        }

        public List<Usuario> BuscarTodos()
        {
            return Usuarios;
        }
        public void Adicionar(Usuario usuario)
        {
            Usuarios.Add(usuario);
        }
        public Usuario Login(string Usuario, String Senha)
        {
            return Usuarios.Find(u => u.UsuarioNome == Usuario && u.Senha == Senha);
        }
        
    }
}
