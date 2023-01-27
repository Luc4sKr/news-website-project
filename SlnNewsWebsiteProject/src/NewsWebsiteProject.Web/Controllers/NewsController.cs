using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NewsWebsiteProject.Domain.DTO;
using NewsWebsiteProject.Domain.IServices;

namespace NewsWebsiteProject.Web.Controllers
{
    public class NewsController : Controller
    {
        private readonly ILogger<NewsController> logger;
        private readonly INewsService _newsService;
        private readonly ICategoryService _categoryService;

        public NewsController(ILogger<NewsController> logger,
                              INewsService newsService,
                              ICategoryService categoryService)
        {
            this.logger = logger;
            _newsService = newsService;
            _categoryService = categoryService;
        }

        #region GET
        [HttpGet]
        public IActionResult Index()
        {
            return View(_newsService.FindAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewData["categoryId"] = new SelectList(_categoryService.FindAll(), "id", "name", "Select...") ;
            return View();
        }
        #endregion

        #region POST
        [HttpPost]
        [HttpPost]
        public async Task<IActionResult> Create([Bind("id, title, description, contents, createdOn, published, categoryId")] NewsDTO newsDTO)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (await _newsService.Save(newsDTO) > 0)
                    {
                        TempData["SuccessMessage"] = "Successfully registered news";
                        return RedirectToAction("Index");
                    }
                }

                ViewData["categoryId"] = new SelectList(_categoryService.FindAll(), "id", "name", "Select...");
                return View(newsDTO);
            }
            catch (Exception error)
            {
                TempData["ErrorMessage"] = $"Unable to register news, try again. Error detail: {error.Message}";
                return RedirectToAction("Index");
            }
        }
        #endregion
    }
}
