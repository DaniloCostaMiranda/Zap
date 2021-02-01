using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZapApp.Models;

namespace ZapApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListagemUsuarios : ContentPage
    {
        public ListagemUsuarios()
        {
            InitializeComponent();
            
        }

        
    }

    public class ListagemUsuariosViewModel
    {
        public List<Usuario> Usuarios { get; set; }
        public ListagemUsuariosViewModel()
        {
            Usuarios = MockUsuarios();
        }

        private List<Usuario> MockUsuarios()
        {
            return new List<Usuario>(){
                new Usuario { Nome = "Danilo", Email = "Danilo@hotmail.com", Senha = "123456", IsOnline = false },
                new Usuario { Nome = "dan", Email = "dan@hotmail.com", Senha = "123456", IsOnline = false },
                new Usuario { Nome = "Maria", Email = "Maria@hotmail.com", Senha = "123456", IsOnline = false },
                new Usuario { Nome = "Gio", Email = "Gio@hotmail.com", Senha = "123456", IsOnline = false }

        };

        }
    }
}