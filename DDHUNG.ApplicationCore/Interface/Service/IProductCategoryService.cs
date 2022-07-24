using DDHUNG.ApplicationCore.Entity;
using DDHUNG.ApplicationCore.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDHUNG.ApplicationCore.Interface.Service
{
    public interface IProductCategoryService : IBaseService<ProductCategory>
    {
        /// <summary>
        /// Lấy tất cả sản phẩm
        /// </summary>
        /// <returns></returns> 
        Task<ProductCategoryViewModel> getAllProductCategory(Guid? ProductCategoryId,int page, int pageSize);

    }
}
