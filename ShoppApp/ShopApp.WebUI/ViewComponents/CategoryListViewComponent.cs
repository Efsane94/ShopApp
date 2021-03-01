using Microsoft.AspNetCore.Mvc;
using ShopApp.Business.Abstract;
using ShopApp.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WebUI.ViewComponents
{
    public class CategoryListViewComponent : ViewComponent
    {
        private ICategoryService _categoryService;

        public CategoryListViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public IViewComponentResult Invoke()
        {
            string category = "";

            if (RouteData.Values["category"]!=null)
            {
                category = RouteData.Values["category"].ToString();
            }
           
            return View(new CategoryListViewModel()
            {
                SelectedCategory=category,
                Categories=_categoryService.GetAll()
            });
        }
    }
}
