using System.Collections.Generic;
using LoraChat.Domain.Models;

namespace LoraChat.Domain.Interfaces.Services
{
    public interface IGitHubService
    {
        IEnumerable<RepositoriesResultViewModel> GetRepositories(string nameRepository);
    }
}