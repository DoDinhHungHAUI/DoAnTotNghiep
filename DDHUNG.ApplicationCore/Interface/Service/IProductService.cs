﻿using DDHUNG.ApplicationCore.Entity;
using DDHUNG.ApplicationCore.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDHUNG.ApplicationCore.Interface.Service
{
    public interface IProductService : IBaseService<Product>
    {
        #region Method


        /// <summary>
        /// Lấy danh sách sản phẩm lên cho phần trang chủ
        /// </summary>
        /// <returns></returns>
        Task<HomeViewModel> GetProducts();

        /// <summary>
        /// Lấy danh sách sản phẩm khi tìm kiếm
        /// </summary>
        /// <returns></returns>
        Task<ProductCategoryViewModel> getAllProductSearch(string keySearch, int page, int pageSize);

        /// <summary>
        /// Lấy sản phẩm theo id
        /// </summary>
        /// <param name="productId">Id sản phẩm</param>
        /// <returns>Sản phẩm được tìm thấy</returns>
        /// DDHung
        Task<Product> GetProductById(Guid? productId);

        /// <summary>
        /// Kiểm tra xem sản phẩm đã hết hàng hay chưa
        /// </summary>
        /// <param name="ProductId"></param>
        /// <param name="Quantity"></param>
        /// <returns></returns>
        Task<bool> SellProduct(Guid? ProductId, int? Quantity);


        #endregion

    }
}
