using DDHUNG.ApplicationCore.Entity;
using DDHUNG.ApplicationCore.Interface.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DDHUNG.DoAnTotNghiep.API
{
    public class ProductCategoryController : BaseEntitiesController<ProductCategory>
    {

        #region Declare

        /// <summary>
        /// Service danh mục sản phẩm
        /// </summary>
        IProductCategoryService _productCategoryService;

        #endregion


        #region Constructor 

        public ProductCategoryController(IProductCategoryService productCategoryService) : base(productCategoryService)
        {
            _productCategoryService = productCategoryService;
        }

        #endregion
    }
}
