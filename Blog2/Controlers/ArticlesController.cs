using Blog2.Models;
using Blog2.Models.Developpement_Blog.Models;
using Blog2.Services;
using Blog2.Services.Developpement_Blog.Services;
using Microsoft.AspNetCore.Mvc;

namespace Blog2.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ArticlesController : ControllerBase
{
    private readonly ArticleService _articleService;

    public ArticlesController(ArticleService articleService)
    {
        _articleService = articleService;
    }


    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        // On suppose que ta méthode s'appelle GetAllArticlesAsync
        var articles = await _articleService.GetAllArticlesAsync();
        return Ok(articles);
    }
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var success = await _articleService.DeleteArticleAsync(id);
        if (!success) return NotFound("L'article n'existe pas.");

        return NoContent(); // Réponse standard 204 pour une suppression réussie
    }
    [HttpPost]
    public async Task<IActionResult> Create(Article article)
    {
        var newArticle = await _articleService.CreateArticleAsync(article);
        return CreatedAtAction(nameof(GetAll), new { id = newArticle.Id }, newArticle);
    }
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, Article article)
    {
        var success = await _articleService.UpdateArticleAsync(id, article);
        if (!success) return NotFound();
        return NoContent();
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var article = await _articleService.GetByIdWithCommentsAsync(id);
        if (article == null)
            return NotFound(new { message = $"L'article avec l'id {id} est introuvable." });

        return Ok(article);
    }
}