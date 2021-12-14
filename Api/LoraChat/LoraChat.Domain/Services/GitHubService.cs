using System;
using System.Collections.Generic;
using System.Linq;
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

        public List<RepositoriesResultViewModel> GetRepositories(string nameRepository, string language)
        {
            try
            {
                return _gitHubRepository.GetRepositories(nameRepository).Where(repo => repo.Language == language)
                    .ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}