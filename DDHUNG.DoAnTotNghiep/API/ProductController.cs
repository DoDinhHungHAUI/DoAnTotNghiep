using DDHUNG.ApplicationCore.Entity;
using DDHUNG.ApplicationCore.Enum;
using DDHUNG.ApplicationCore.Interface.Service;
using DDHUNG.ApplicationCore.Param;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DDHUNG.DoAnTotNghiep.API
{
    public class ProductController : BaseEntitiesController<Product>
    {

        #region Declare

        /// <summary>
        /// Service sản phẩm
        /// </summary>
        IProductService _productService;

        IProductCategoryService _productCategoryService;

        private readonly IHostingEnvironment _hostingEnvironment;

        #endregion

        #region Constructor

        public ProductController(IProductService productService, IProductCategoryService productCategoryService, IHostingEnvironment hostingEnvironment) : base(productService)
        {
            _productService = productService;
            _productCategoryService = productCategoryService;
            _hostingEnvironment = hostingEnvironment;
        }

        #endregion


        #region Method

        [HttpGet("getProduct")]
        public IActionResult GetProductApi()
        {
            var products = _productService.GetApiProducts().Result;

            return Ok(products);
        }


        /// <summary>
        /// Thêm sản phẩm
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        [HttpPost("AddNewProduct")]
        public IActionResult AddNewProduct()//[FromBody]Product product
        {
            string sPath = "";

            // Lấy thông tin sản phẩm

            var productJson = HttpContext.Request.Form["product"];

            var product = JsonConvert.DeserializeObject<Product>(productJson);

            // Lấy thông tin danh mục sản phẩm

            var productCategories = _productCategoryService.GetEntities().Result;

            var productCategory = productCategories.Where(x => x.ProductCategoryId == product.CategoryID).FirstOrDefault();

            if(productCategory.DisplayOrder == (int)TypeProduct.Phone)
            {
                sPath = "Images/ImageProduct/DienThoai";
            }    
            else if(productCategory.DisplayOrder == (int)TypeProduct.Laptop)
            {
                sPath = "Images/ImageProduct/Laptop";
            }    
            else if(productCategory.DisplayOrder == (int)TypeProduct.Tablet)
            {
                sPath = "Images/ImageProduct/MayTinhBang";
            }   

            string imageName = null;

            //Đọc file 
            IFormFile fileImage = HttpContext.Request.Form.Files["formFile"];

            
            //create custom filename
            imageName = new String(Path.GetFileNameWithoutExtension(fileImage.FileName).Take(10).ToArray()).Replace(" ", "-");
            imageName = imageName + DateTime.Now.ToString("yymmssfff") + Path.GetExtension(fileImage.FileName);

            var uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, sPath);

            string filePath = Path.Combine(uploadsFolder, imageName);

            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                fileImage.CopyTo(fileStream);
            }

            // thực hiện insert sản phẩm

            product.ProductId = Guid.NewGuid();
            product.Image = imageName;
            product.TypeProduct = productCategory.DisplayOrder;
            var serviceresult = _productService.AddEntity(product);

            return StatusCode(201, serviceresult);
        }


        #endregion

    }
}
