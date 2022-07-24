using DDHUNG.ApplicationCore.Entity;
using DDHUNG.ApplicationCore.Interface.Repository;
using DDHUNG.ApplicationCore.Interface.Service;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDHUNG.ApplicationCore.Service
{
    public class ProductOrderService : BaseService<ProductOrder>, IProductOrderService
    {

        #region Declare
            private readonly IProductOrderRepository _productOrderRepository;
            private readonly IProductOrderDetailRepository _productOrderDetailRepository;
        #endregion

        #region Constructor

        public ProductOrderService(IProductOrderRepository productOrderRepository, IProductOrderDetailRepository productOrderDetailRepository) : base(productOrderRepository)
        {
            _productOrderRepository = productOrderRepository;
            _productOrderDetailRepository = productOrderDetailRepository;
        }

        #endregion

        #region Method

        /// <summary>
        /// Tạo đơn hàng khi người dùng xác nhận
        /// </summary>
        /// <param name="productOrder">Thông tin đơn hàng</param>
        /// <param name="productOrderDetails">Thông tin chi tiết đơn hàng</param>
        /// <returns></returns>
        /// DDHung
        public async Task<int> CreateOrderProduct(ProductOrder productOrder, List<ProductOrderDetail> productOrderDetails)
        {
            // insert thông tin đơn hàng

            var rowAffects = await _productOrderRepository.AddEntity(productOrder);

            if (rowAffects > 0)
            {
                // insert thông tin chi tiết đơn hàng

                var productOrderDetailParam = JsonConvert.SerializeObject(productOrderDetails);

                rowAffects = await _productOrderDetailRepository.AddMultyEntity(productOrderDetailParam);

            }

            return rowAffects;
        }

        #endregion
    }
}
