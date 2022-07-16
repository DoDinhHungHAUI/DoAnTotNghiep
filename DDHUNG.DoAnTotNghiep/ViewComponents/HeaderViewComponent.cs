using DDHUNG.ApplicationCore.Entity;
using DDHUNG.ApplicationCore.Interface.Service;
using DDHUNG.ApplicationCore.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DDHUNG.DoAnTotNghiep.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        #region Declare
        private readonly IMenuHeaderService _menuHeaderService;
        private readonly IProductCategoryService _productCategoryService;
        #endregion

        #region Constructor
        public HeaderViewComponent(IMenuHeaderService menuHeaderService, IProductCategoryService productCategoryService)
        {
            _menuHeaderService = menuHeaderService;
            _productCategoryService = productCategoryService;
        }
        #endregion

        public IViewComponentResult Invoke()
        {

            MenuHeaderViewModel menuHeader = new MenuHeaderViewModel();

            var menuHeaders = _menuHeaderService.GetEntities().Result as List<MenuHeader>;

            var productCategory = _productCategoryService.GetEntities().Result as List<ProductCategory>;

            menuHeader.ListMenuHeader = menuHeaders;
            menuHeader.ListProductCategory = productCategory;

            return View(menuHeader);
        }
    }
}
