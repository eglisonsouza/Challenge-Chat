using System.Collections.Generic;
using LoraChat.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
namespace LoraChat.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class GitHubRepositoriesController : ControllerBase
    {
        private readonly IGitHubService _gitHubService;

        public GitHubRepositoriesController(IGitHubService gitHubService)
        {
            _gitHubService = gitHubService;
        }

        [HttpGet("Csharp/{repositoryName}")]
        public ActionResult<IEnumerable<dynamic>> GetRepositoriesGitHub(string repositoryName)
        {
            return Ok(_gitHubService.GetRepositories(nameRepository: repositoryName, language: "C#"));
        }
    }

}