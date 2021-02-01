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
    public partial class ListagemMensagens : ContentPage
    {
        public ListagemMensagens()
        {
            InitializeComponent();
        }
    }
    public class ListagemMensagensViewModel
    {
        public List<Mensagem> Mensagens { get; set; }
        public ListagemMensagensViewModel()
        {
            Mensagens = MockMensagens();
        }

        private List<Mensagem> MockMensagens()
        {
            return new List<Mensagem>(){
                new Mensagem { NomeGrupo = "1", Texto = "America Verde1", Usuario = new Usuario{ Id = 1, Nome = "Elias Ribeiro" } },
                new Mensagem { NomeGrupo = "1", Texto = "Palmeiras2", Usuario = new Usuario{ Id = 2, Nome = "Danilo M" } },
                new Mensagem { NomeGrupo = "1", Texto = "America Verde3", Usuario = new Usuario{ Id = 1, Nome = "Elias Ribeiro" } },
                new Mensagem { NomeGrupo = "1", Texto = "America Verde4", Usuario = new Usuario{ Id = 2, Nome = "Danilo M" } },
                new Mensagem { NomeGrupo = "1", Texto = "America Verde5", Usuario = new Usuario{ Id = 1, Nome = "Elias Ribeiro" } },
                new Mensagem { NomeGrupo = "1", Texto = "America Verde6", Usuario = new Usuario{ Id = 2, Nome = "Danilo M" } },
                new Mensagem { NomeGrupo = "1", Texto = "America Verde7", Usuario = new Usuario{ Id = 2, Nome = "Danilo M" } },
                new Mensagem { NomeGrupo = "1", Texto = "America Verde8", Usuario = new Usuario{ Id = 2, Nome = "Danilo M" } },
                new Mensagem { NomeGrupo = "1", Texto = "America Verde9", Usuario = new Usuario{ Id = 2, Nome = "Danilo M" } },
             
                        };

        }
    }

    public class MensagemDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate EsquerdaTemplate { get; set; }
        public DataTemplate DireitaTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            //TODO - obter usuario logoda depois.
            Usuario usuarioLogado = new Usuario() { Id = 1, Nome = "Elias" };
            return ((Mensagem)item).Usuario.Id == usuarioLogado.Id ? DireitaTemplate : EsquerdaTemplate;
        }
    }
}