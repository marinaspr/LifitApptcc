using LifitApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LifitApp.Services
{
    public class PostagemService
    {
        private readonly HttpClient _httpClient;
        private const string Url = "http://localhost:5000/api/postagens";

        public PostagemService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<List<Postagem>> GetPostagensAsync()
        {
            var response = await _httpClient.GetStringAsync(Url);
            return JsonSerializer.Deserialize<List<Postagem>>(response);
        }

        public async Task AddPostagemAsync(Postagem postagem)
        {
            var json = JsonSerializer.Serialize(postagem);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            await _httpClient.PostAsync(Url, content);
        }

        public async Task DeletePostagemAsync(int id)
        {
            await _httpClient.DeleteAsync($"{Url}/{id}");
        }

        public async Task UpdatePostagemAsync(Postagem postagem)
        {
            var json = JsonSerializer.Serialize(postagem);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            await _httpClient.PutAsync($"{Url}/{postagem.Id}", content);
        }
        public async Task AtualizarPostagemAsync(Postagem postagem)
        {
            var url = $"{Url}/{postagem.Id}";
            await _httpClient.PutAsJsonAsync(url, postagem);
        }
        public async Task DeletarPostagemAsync(int id)
        {
            var url = $"{Url}/{id}";
            await _httpClient.DeleteAsync(url);
        }

    }

}
