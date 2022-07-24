using DDHUNG.ApplicationCore.Entity;
using DDHUNG.ApplicationCore.Enum;
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
    public class ProductService : BaseService<Product>, IProductService
    {
        #region Declare
        /// <summary>
        /// Service Product
        /// </summary>
        private readonly IProductRepository _productRepository;
        #endregion

        #region Constructor
        public ProductService(IProductRepository customerRepository, IProductRepository productRepository) : base(customerRepository)
        {
            _productRepository = productRepository;
        }
        #endregion

        #region Method

        /// <summary>
        /// Lấy danh sách sản phẩm lên cho phần trang chủ
        /// </summary>
        /// <returns></returns>
        /// DDHung 17/07/2022
        public async Task<HomeViewModel> GetProducts()
        {
            HomeViewModel homeViewModel = new HomeViewModel();

            var products = await _productRepository.GetEntities() as List<Product>;

            // Lấy ra điện thoại thoại mới nhất
            var phoneLatests = products.Where(x => x.TypeProduct == (int)TypeProduct.Phone).ToList();
            if (phoneLatests.Count >= 4)
            {
                phoneLatests = phoneLatests.OrderBy(x => x.CreatedDate).Skip(0).Take(3).ToList();
            }
            else
            {
                phoneLatests = phoneLatests.OrderBy(x => x.CreatedDate).ToList();
            }

            // Lấy ra laptop mơi nhất

            var laptopLatests = products.Where(x => x.TypeProduct == (int)TypeProduct.Laptop).ToList();
            if (laptopLatests.Count >= 4)
            {
                laptopLatests = laptopLatests.OrderBy(x => x.CreatedDate).Skip(0).Take(3).ToList();
            }
            else
            {
                laptopLatests = laptopLatests.OrderBy(x => x.CreatedDate).ToList();
            }

            // Lấy ra máy tính bảng mới nhất

            var tabletLatests = products.Where(x => x.TypeProduct == (int)TypeProduct.Tablet).ToList();
            if (tabletLatests.Count >= 4)
            {
                tabletLatests = tabletLatests.OrderBy(x => x.CreatedDate).Skip(0).Take(3).ToList();
            }
            else
            {
                tabletLatests = tabletLatests.OrderBy(x => x.CreatedDate).ToList();
            }

            homeViewModel.PhoneLatests = phoneLatests;
            homeViewModel.LaptopLatests = laptopLatests;
            homeViewModel.TabletLatests = tabletLatests;

            return homeViewModel;
        }



        /// <summary>
        /// Lấy tất cả sản phẩm
        /// </summary>
        /// <returns></returns>
        /// DDHung 17/07/2022
        public async Task<ProductCategoryViewModel> getAllProductSearch(string keySearch, int page, int pageSize)
        {
            ProductCategoryViewModel productCategoryViewModel = new ProductCategoryViewModel();

            //Lấy danh sách sản phẩm
            var productData = await _productRepository.GetEntities() as List<Product>;

            productData = productData.Where(x => x.ProductName.Contains(keySearch)).ToList();

            var productGetByPages = productData.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            productCategoryViewModel.products = productGetByPages;
            productCategoryViewModel.TotalProducts = productData.Count;
        
            return productCategoryViewModel;

        }

        /// <summary>
        /// Lấy sản phẩm theo id
        /// </summary>
        /// <param name="productId">Id sản phẩm</param>
        /// <returns>Sản phẩm được tìm thấy</returns>
        /// DDHung
        public async Task<Product> GetProductById(Guid? productId)
        {
            var product = await _productRepository.GetProductById(productId);

            return product;
        }

        /// <summary>
        /// Kiểm tra xem sản phẩm đã hết hàng hay chưa
        /// </summary>
        /// <param name="ProductId">Id sản phẩm</param>
        /// <param name="Quantity">Số lượng sản phẩm</param>
        /// <returns>
        /// True : Sản phẩm vẫn còn
        /// False : Sản phẩm đã hết hàng
        /// </returns>
        /// DDHung 23/07/2022
        public async Task<bool> SellProduct(Guid? ProductId, int? Quantity)
        {
            var product = await _productRepository.GetProductById(ProductId);
            if (product.Quantity < Quantity)
            {
                return false;
            }
            product.Quantity -= Quantity;

            //Update lại số lượng sản phẩm

            var _ = await _productRepository.UpdateEntity(product);

            return true;
        }

        #endregion

    }
}
