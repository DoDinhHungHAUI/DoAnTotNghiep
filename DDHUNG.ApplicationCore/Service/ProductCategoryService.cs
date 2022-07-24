using DDHUNG.ApplicationCore.Entity;
using DDHUNG.ApplicationCore.Interface.Repository;
using DDHUNG.ApplicationCore.Interface.Service;
using DDHUNG.ApplicationCore.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDHUNG.ApplicationCore.Service
{
    public class ProductCategoryService : BaseService<ProductCategory>,IProductCategoryService
    {

        #region Declare
        private readonly IProductRepository _productRepository;
        private readonly IProductCategoryRepository _productCategoryRepository;
        #endregion

        #region Constructor
        public ProductCategoryService(IProductCategoryRepository productCategoryRepository, IProductRepository productRepository) : base(productCategoryRepository)
        {
            _productRepository = productRepository;
            _productCategoryRepository = productCategoryRepository;
        }

        /// <summary>
        /// Lấy tất cả sản phẩm
        /// </summary>
        /// <returns></returns>
        /// DDHung 17/07/2022
        public async Task<ProductCategoryViewModel> getAllProductCategory(Guid? ProductCategoryId, int page, int pageSize)
        {
            ProductCategoryViewModel productCategoryViewModel = new ProductCategoryViewModel();

            //Lấy danh sách sản phẩm
            var productData = await _productRepository.GetEntities() as List<Product>;

            productData = productData.Where(x => x.CategoryID == ProductCategoryId).ToList();

            // Lấy danh mục
            var productCategoryData = await _productCategoryRepository.GetEntities() as List<ProductCategory>;

            var productGetByPages = productData.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            if (productCategoryData.Count > 0)
            {
                productCategoryData = productCategoryData.OrderBy(x => x.DisplayOrder).ToList();
            }    

            productCategoryViewModel.products = productGetByPages;
            productCategoryViewModel.productCategories = productCategoryData;
            productCategoryViewModel.TotalProducts = productData.Count;
            productCategoryViewModel.productCategoryActive = productCategoryData.Where(x => x.ProductCategoryId == ProductCategoryId).FirstOrDefault();

            return productCategoryViewModel;

        }



        #endregion
    }
}
