using System.Collections.Generic;
using LoraChat.Domain.Interfaces.Repositories;
using LoraChat.Domain.Interfaces.Services;
using LoraChat.Domain.Models;

namespace LoraChat.Domain.Services
{
    public class GitHubService : IGitHubService
    {
        private readonly IGitHubRepository _gitHubRepository;

        public GitHubService(IGitHubRepository gitHubRepository)
        {
            _gitHubRepository = gitHubRepository;
        }

        public IEnumerable<RepositoriesResultViewModel> GetRepositories(string nameRepository)
        {
            var repositories = _gitHubRepository.GetRepositories(nameRepository);
            return repositories;
        }
    }
}