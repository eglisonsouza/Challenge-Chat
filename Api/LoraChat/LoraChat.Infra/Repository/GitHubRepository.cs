using System.Collections.Generic;
using System.Text.Json;
using LoraChat.Domain.Models;
using LoraChat.Domain.Interfaces.Repositories;
using RestSharp;

namespace LoraChat.Infra.Repository
{
    public class GitHubRepository : IGitHubRepository
    {
        public IEnumerable<RepositoriesResultViewModel> GetRepositories(string nameRepository)
        {
            return JsonSerializer.Deserialize<IEnumerable<RepositoriesResultViewModel>>(RequestGitHub(nameRepository)
                    .Content);
        }

        private static IRestResponse RequestGitHub(string nameRepository)
        {
            return new RestSharp.RestClient($"https://api.github.com/users/{nameRepository}/repos")
                .Execute(request: new RestRequest(Method.GET));
        }
    }
}