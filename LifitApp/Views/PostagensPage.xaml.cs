using LifitApp.Services;
using LifitApp.Models;

namespace LifitApp.Views
{
    public partial class PostagensPage : ContentPage
    {
        public PostagensPage()
        {
            InitializeComponent();
            LoadPostagens();
        }

        private async void LoadPostagens()
        {
            var postagens = await new PostagemService().GetPostagensAsync();
            PostagensList.ItemsSource = postagens;
        }
        private async void OnEditarClicked(object sender, EventArgs e)
        {
            var postagem = (sender as Button).BindingContext as Postagem;
            await Navigation.PushAsync(new EditarPostagem(postagem));
        }

        private async void OnExcluirClicked(object sender, EventArgs e)
        {
            var postagem = (sender as Button).BindingContext as Postagem;
            var confirm = await DisplayAlert("Confirmação", "Deseja excluir esta postagem?", "Sim", "Não");

            if (confirm)
            {
                await new PostagemService().DeletarPostagemAsync(postagem.Id);
                LoadPostagens(); // recarrega
            }
        }

    }
}
