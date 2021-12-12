using System.Collections.Generic;
using LoraChat.Domain.Models;

namespace LoraChat.Domain.Interfaces.Repositories
{
    public interface IGitHubRepository
    {
        IEnumerable<RepositoriesResultViewModel> GetRepositories(string nameRepository);
    }
}