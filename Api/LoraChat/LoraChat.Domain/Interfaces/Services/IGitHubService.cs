using System.Collections.Generic;
using LoraChat.Domain.Models;

namespace LoraChat.Domain.Interfaces.Services
{
    public interface IGitHubService
    {
        List<RepositoriesResultViewModel> GetRepositories(string nameRepository, string language);
    }
}