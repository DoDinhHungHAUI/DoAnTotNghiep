using DDHUNG.ApplicationCore.Interface.Service;
using DDHUNG.DoAnTotNghiep.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DDHUNG.ApplicationCore.EtensionMethod;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DDHUNG.ApplicationCore.Entity;
using DDHUNG.ApplicationCore.ViewModel;
using DDHUNG.ApplicationCore.Enum;
using DDHUNG.ApplicationCore.Common;
using Microsoft.AspNetCore.Http;

namespace DDHUNG.DoAnTotNghiep.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserService _userService;
        private readonly IProductService _productService;


        public HomeController(ILogger<HomeController> logger, IUserService userService, IProductService productService)
        {
            _logger = logger;
            _userService = userService;
            _productService = productService;
        }

        public IActionResult Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel();

            homeViewModel = _productService.GetProducts().Result;

            return View(homeViewModel);
        }

        /// <summary>
        /// View sau khi tìm kiếm
        /// </summary>
        /// <param name="keyword">Text Search</param>
        /// <param name="page">Trang hiện tại</param>
        /// <returns></returns>
        /// DDHung
        public IActionResult Search(string keyword, int page = 1)
        {
            int pageSize = ConfigHelper.pageSize;

            if (HttpContext.Session.GetString(CommonConstant.SessionSearch) == null || HttpContext.Session.GetString(CommonConstant.SessionSearch) == "")
            {
                HttpContext.Session.SetString(CommonConstant.SessionSearch, keyword);
            }

            var keySearch = (keyword == null ? HttpContext.Session.GetString(CommonConstant.SessionSearch) : keyword);

            var productCategoryViewModel =  _productService.getAllProductSearch(keySearch, page, pageSize).Result;

            int totalPage = (int)Math.Ceiling((double)productCategoryViewModel.TotalProducts / pageSize);

            ViewBag.keyword = keyword;

            var paginationSet = new PaginationSet
            {
                Item = productCategoryViewModel,    
                MaxPage = ConfigHelper.MaxPage,
                Page = page,
                TotalCount = productCategoryViewModel.TotalProducts,
                TotalPages = totalPage
            };

            return View(paginationSet);
        }


        /// <summary>
        /// View đăng nhập
        /// </summary>
        /// <returns></returns>
        /// DDHung 24/07/2022
        public IActionResult Login()
        {
            return View();
        }


        /// <summary>
        /// Đăng ký
        /// </summary>
        /// <returns></returns>
        /// DDHung 24/07/2022
        public IActionResult Register()
        {
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
