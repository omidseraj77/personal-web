using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using webme12.Models;


namespace webme12.VewComponet
{
    public class ArticleViewComponent : ViewComponent 
    {
        public IViewComponentResult Invoke()
        {
            var article = new List<Article>
            {
                new Article(1,"اموزش mvc ","mvc","blog-post-thumb-card-1.jpg"),
                new Article(2,"اموزش php ","php","blog-post-thumb-card-2.jpg"),
                new Article(3,"اموزش python ","python","blog-post-thumb-card-3.jpg"),
                new Article(4,"اموزش css ","css","blog-post-thumb-card-4.jpg")

            };
            
<<<<<<< HEAD
            omidseraj
=======

>>>>>>> 21fb0b0dbf5d2b6550804202214f9cd230aecfc5

            return View("_Atricles",article);
        }
    }
}
