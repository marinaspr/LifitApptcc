using LifitApp.Models;
using LifitApp.Services;

namespace LifitApp.Views
{
    public partial class CriarPostagem : ContentPage
    {
        public CriarPostagem()
        {
            InitializeComponent();
        }

        private async void OnPostarClicked(object sender, EventArgs e)
        {
            var postagem = new Postagem
            {
                Titulo = TituloEntry.Text,
                Descricao = DescricaoEntry.Text,
                Local = LocalEntry.Text,
                Horario = HorarioEntry.Text
            };

            await new PostagemService().AddPostagemAsync(postagem);
            await DisplayAlert("Sucesso", "Postagem criada!", "OK");
        }
    }
}
