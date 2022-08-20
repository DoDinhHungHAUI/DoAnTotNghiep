using DDHUNG.ApplicationCore.Entity;
using DDHUNG.ApplicationCore.Interface.Repository;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDHUNG.Infrastructure
{
    public class ProductOrderDetailRepository : BaseRepository<ProductOrderDetail>, IProductOrderDetailRepository
    {
        #region Constructor
        public ProductOrderDetailRepository(IConfiguration configuration) : base(configuration)
        {

        }
        #endregion
    }
}
