using LifitApp.Models;
using LifitApp.Services;

namespace LifitApp.Views
{
    public partial class EditarPostagem : ContentPage
    {
        private Postagem postagemAtual;

        public EditarPostagem(Postagem postagem)
        {
            InitializeComponent();
            postagemAtual = postagem;

            TituloEntry.Text = postagem.Titulo;
            DescricaoEntry.Text = postagem.Descricao;
            LocalEntry.Text = postagem.Local;
            HorarioEntry.Text = postagem.Horario;
        }

        private async void OnSalvarClicked(object sender, EventArgs e)
        {
            postagemAtual.Titulo = TituloEntry.Text;
            postagemAtual.Descricao = DescricaoEntry.Text;
            postagemAtual.Local = LocalEntry.Text;
            postagemAtual.Horario = HorarioEntry.Text;

            await new PostagemService().AtualizarPostagemAsync(postagemAtual);
            await DisplayAlert("Atualizado", "Postagem atualizada com sucesso!", "OK");
            await Navigation.PopAsync();
        }
    }
}
