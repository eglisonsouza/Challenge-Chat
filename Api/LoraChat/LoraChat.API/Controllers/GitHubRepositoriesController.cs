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

        [HttpGet]
        public ActionResult<IEnumerable<dynamic>> GetRepositoriesGitHub()
        {
            return Ok(_gitHubService.GetRepositories("takenet"));
        }
    }

}