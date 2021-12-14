using System;
using System.Collections.Generic;
using LoraChat.Domain.Interfaces.Services;
using LoraChat.Domain.Models;
using LoraChat.Shared.Constants;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

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
        
        /// <summary>
        /// Responsável por buscar repositórios referente a tecnologia C# 
        /// </summary>
        /// <param name="repositoryName">Nome do repositório GitHub a ser buscado</param>
        /// <returns>Retorna uma lista com os repositórios</returns>
        [SwaggerResponse(statusCode: 200, description: "Sucesso ao obter resultados")]
        [SwaggerResponse(statusCode: 400, description: "Campos obrigatórios")]
        [SwaggerResponse(statusCode: 500, description: "Erro Interno")]
        [HttpGet("Csharp/{repositoryName}")]
        public ActionResult<IEnumerable<RepositoriesResultViewModel>> GetRepositoriesGitHub(string repositoryName)
        {
            if (String.IsNullOrEmpty(repositoryName)) return BadRequest("Atributo repositoryName é obrigatório");
            return Ok(_gitHubService.GetRepositories(nameRepository: repositoryName, language: Language.Csharp));
        }
    }

}