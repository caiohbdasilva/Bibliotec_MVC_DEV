using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bibliotec_MVC_DEV.Interfaces;
using Bibliotec_MVC_DEV.Models;
using Bibliotec_MVC_DEV.Repositories;

namespace Bibliotec_MVC_DEV.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public async Task<Usuario?> AutenticarUsuario(string email, string senha)
        {
            return await _usuarioRepository.BuscarPorEmailSenha(email, senha);
        }
    }
}