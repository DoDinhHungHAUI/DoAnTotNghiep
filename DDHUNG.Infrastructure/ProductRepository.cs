using Dapper;
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
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        #region Constructor
        public ProductRepository(IConfiguration configuration) : base(configuration)
        {

        }

        #endregion

        #region Method

        /// <summary>
        /// Lấy sản phẩm theo id
        /// </summary>
        /// <param name="productId">Id sản phẩm</param>
        /// <returns>Sản phẩm được tìm thấy</returns>
        /// DDHung
        public virtual async Task<Product> GetProductById(Guid? productId)
        {
            var queryString = $"select * from {_tableName} where {_tableName}Id = @entityId";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@entityId", productId);
            var rowReader = await _dbConnection.QueryAsync<Product>(queryString, param: parameters, commandType: System.Data.CommandType.Text);
            return rowReader.FirstOrDefault();
        }


        #endregion



    }
}
