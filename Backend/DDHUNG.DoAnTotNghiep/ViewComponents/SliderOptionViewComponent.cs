using DDHUNG.ApplicationCore.Entity;
using DDHUNG.ApplicationCore.Interface.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DDHUNG.DoAnTotNghiep.ViewComponents
{
    public class SliderOptionViewComponent : ViewComponent
    {
        #region Declare
        private readonly ISlideService _slideService;
        #endregion

        #region Constructor
        public SliderOptionViewComponent(ISlideService slideService)
        {
            _slideService = slideService;
        }

        #endregion

        public IViewComponentResult Invoke()
        {
            var slides = _slideService.GetEntities().Result as List<Slide>;
            return View(slides);
        }
    }
}
