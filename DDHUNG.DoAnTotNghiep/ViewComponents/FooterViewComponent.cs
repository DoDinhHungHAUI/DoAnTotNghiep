using DDHUNG.ApplicationCore.Entity;
using DDHUNG.ApplicationCore.Interface.Repository;
using DDHUNG.ApplicationCore.Interface.Service;
using DDHUNG.ApplicationCore.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace DDHUNG.DoAnTotNghiep.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {
        #region Declare
        private readonly IFooterProductService _footerProductService;
        #endregion

        #region Constructor
        public FooterViewComponent(IFooterProductService footerProductService)
        {
            _footerProductService = footerProductService;
        }
        #endregion

        public IViewComponentResult Invoke()
        {

            FooterViewModel footerViewModel = new FooterViewModel();

            footerViewModel = _footerProductService.GetFooterProducts().Result;

            return View(footerViewModel);
        }
    }
}
