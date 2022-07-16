using DDHUNG.ApplicationCore.Entity;
using DDHUNG.ApplicationCore.Interface.Repository;
using DDHUNG.ApplicationCore.Interface.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDHUNG.ApplicationCore.Service
{
    public class ProductService : BaseService<Product>, IProductService
    {
        #region Constructor
        public ProductService(IProductRepository customerRepository) : base(customerRepository)
        {

        }
        #endregion
    }
}
