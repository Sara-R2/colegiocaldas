using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using proyecto_caldas.Data;
using proyecto_caldas.Models;
using proyecto_caldas.Services;

namespace proyecto_caldas.Implementacion
{
    public class UsuarioService : IUsuarioService
    {
        private readonly DBContext dBContext;

        private readonly IPasswordServicio PasswordServicio;

        public UsuarioService(DBContext dBContext, IPasswordServicio PasswordServicio)
        {
            this.dBContext = dBContext;
            this.PasswordServicio = PasswordServicio;
        }
        public async Task CrerUsuario(UsuarioModel usuario)
        {
            if (usuario != null)
            {
                usuario.Usuario_Contrasena = PasswordServicio.HashPassword(usuario.Usuario_Contrasena);
                dBContext.Usuarios.Add(usuario);
                await dBContext.SaveChangesAsync();
            }
        }
    }
}