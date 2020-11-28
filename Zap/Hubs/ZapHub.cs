using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zap.Database;
using Zap.Models;

namespace Zap.Hubs
{
    public class ZapHub : Hub
    {

        private readonly BancoContext _banco;
        public ZapHub(BancoContext banco)
        {
            _banco = banco;
        }
        public async Task Cadastrar(Usuario usuario)
        {
            bool IsExistUser = _banco.Usuarios.Where(a => a.Email == usuario.Email).Count() > 0;
            if (IsExistUser)
            {
                await Clients.Caller.SendAsync("ReceberCadastro", false, false, "E-mail ja cadastrado");
            }
            else
            {
                _banco.Usuarios.Add(usuario);
                _banco.SaveChanges();

                await Clients.Caller.SendAsync("ReceberCadastro", true, usuario, "Usuário cadastrado com sucesso");
            }
        }
        public async Task Login(Usuario usuario)
        {
            var usuarioDB =_banco.Usuarios.FirstOrDefault(a => a.Email == usuario.Email && a.Senha == usuario.Senha);
            if(usuarioDB == null)
            {
                await Clients.Caller.SendAsync("ReceberLogin", false, false, "Email ou senha não cadastrados!");
            }
            else
            {
                await Clients.Caller.SendAsync("ReceberLogin", true, usuarioDB, null);
            }
        }
    }

}
