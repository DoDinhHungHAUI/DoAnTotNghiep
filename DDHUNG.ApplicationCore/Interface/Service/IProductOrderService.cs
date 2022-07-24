using DDHUNG.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDHUNG.ApplicationCore.Interface.Service
{
    public interface IProductOrderService : IBaseService<ProductOrder>
    {

        /// <summary>
        /// Method xử lý lưu thông tin đơn hàng
        /// </summary>
        /// <param name="productOrder">Đơn hàng</param>
        /// <param name="productOrderDetails">Chi tiết đơn hàng</param>
        /// <returns></returns>
        /// DDHung 23/07/2022
        Task<int> CreateOrderProduct(ProductOrder productOrder, List<ProductOrderDetail> productOrderDetails);

    }
}
