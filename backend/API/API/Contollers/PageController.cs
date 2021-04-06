using API.Service;
using Microsoft.AspNetCore.Mvc;
using System;

namespace API.Contollers
{
    /// <summary>
    /// Контроллер для получение страницы с фронта
    /// </summary>
    [ApiController]

    public class PageController : ControllerBase
    {
        private IPageService _pageService;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="peopleService"></param>
        public PageController(IPageService pageService)
        {
            this._pageService = pageService;
        }


        /// <summary>
        /// Получение страницы
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        [HttpPost("api/pageitems")]
        public IActionResult GetString([FromBody]string page)
        {
            Console.WriteLine($"Введенный URL: {page}");
            var str = this._pageService.GetString(page);

            return this.Ok(str);
        }
    }
}
