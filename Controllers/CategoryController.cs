using Microsoft.AspNetCore.Mvc;
using VideoGamesStore.Data;
using VideoGamesStore.Models;


namespace VideoGamesStore.Controllers;

public class CategoryController : Controller
{
    
    private readonly VgsDbContext _dbContext;
    public CategoryController( VgsDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public IActionResult Index()
    {
        var objCategoryList = _dbContext.Categories.ToList();
        return View(objCategoryList);
    }

    public IActionResult Create()
    {
        return View();
    }

    /*[HttpPost]
    public async Task<ActionResult> Create(CreateCategoryDto newCategory)
    {
        
        return Ok();
    }*/
}