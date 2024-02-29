using Microsoft.AspNetCore.Mvc;
using VideoGamesStore.Data;

namespace VideoGamesStore.Controllers;

public class CategoryController : Controller
{
    private readonly VgsDbContext _dbContext;
    public CategoryController(VgsDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public IActionResult Index()
    {
        var objCategoryList = _dbContext.Categories.ToList();
        return View(objCategoryList);
    }
}