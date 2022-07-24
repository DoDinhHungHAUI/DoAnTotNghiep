using Dapper;
using DDHUNG.ApplicationCore.Entity;
using DDHUNG.ApplicationCore.Interface.Repository;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDHUNG.Infrastructure
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity>, IDisposable where TEntity : BaseEntity
    {
        #region DECLARE

        /// <summary>
        /// Phục vụ cho việc lấy chuỗi kết nỗi được lưu trữ trong file appsetting.json
        /// </summary>
        IConfiguration _configuration;

        /// <summary>
        /// Chuỗi kết nối
        /// </summary>
        string _connectionString = string.Empty;

        /// <summary>
        /// Phục vụ cho việc mở kết nối xuống database
        /// </summary>
        protected IDbConnection _dbConnection = null;

        /// <summary>
        /// Tên table để biết được thao tác với table nào trong database
        /// </summary>
        protected string _tableName;

        #endregion

        #region Constructor
        public BaseRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("DoAnTotNghiepDBConnectionString");
            _dbConnection = new MySqlConnection(_connectionString);
            _dbConnection.Open();
            _tableName = typeof(TEntity).Name;
        }
        #endregion


        #region Method


        /// <summary>
        /// Thêm một bản ghi
        /// </summary>
        /// <param name="entity">Bản ghi cần thêm</param>
        /// <returns>Số lượng bản ghi bị ảnh hưởng</returns>
        ///  CreatedBy : DDHung (9/11/2021)
        public virtual async Task<int> AddEntity(TEntity entity)
        {
            var dynamicProps = new DynamicParameters();

            //Lấy ra các properties của đối tượng
            var props = entity.GetType().GetProperties();
            //Duyệt từng propertity
            foreach (var prop in props)
            {
                //Lấy tên của property
                var propName = prop.Name;
                var propValue = prop.GetValue(entity);
                var param = propName;
                dynamicProps.Add(param, propValue);
            }

            var rowAffects = 0;

            using (var transaction = _dbConnection.BeginTransaction())
            {
                rowAffects = await _dbConnection.ExecuteAsync($"Proc_Insert{_tableName}", dynamicProps, commandType: CommandType.StoredProcedure);
                transaction.Commit();
            }
            return rowAffects;
        }


        /// <summary>
        /// Thêm một bản ghi
        /// </summary>
        /// <param name="entity">Bản ghi cần thêm</param>
        /// <returns>Số lượng bản ghi bị ảnh hưởng</returns>
        ///  CreatedBy : DDHung (9/11/2021)
        public virtual async Task<int> AddMultyEntity(string lstEntity) 
        {
            var rowAffects = 0;

            using (var transaction = _dbConnection.BeginTransaction())
            {
                rowAffects = await _dbConnection.ExecuteAsync($"Proc_InsertMulty{_tableName}", new { lstEntity }, commandType: CommandType.StoredProcedure);
                transaction.Commit();
            }
            return rowAffects;
        }




        /// <summary>
        /// Xóa một bản ghi
        /// </summary>
        /// <param name="entityId">Id của bản ghi cần xóa</param>
        /// <returns>Số lượng bản ghi bị ảnh hưởng</returns>
        ///  CreatedBy : DDHung (9/11/2021)
        public virtual async Task<int> DeleteEntity(string entityId)
        {
            var rowAffects = 0;
            //_dbConnection.Open();
            using (var transaction = _dbConnection.BeginTransaction())
            {
                var queryString = $"delete from {_tableName} where {_tableName}Id = @entityId";
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@entityId", entityId);
                rowAffects = await _dbConnection.ExecuteAsync(queryString, param: parameters, commandType: CommandType.Text);
                transaction.Commit();
            }

            return rowAffects;
        }

        /// <summary>
        /// Lấy danh sách dữ liệu
        /// </summary>
        /// <returns>Danh sách dữ liệu</returns>
        /// CreatedBy : DDHung (9/11/2021)
        public virtual async Task<IEnumerable<TEntity>> GetEntities()
        {
            var entites = await _dbConnection.QueryAsync<TEntity>($"Proc_Get{_tableName}", commandType: CommandType.StoredProcedure);
            return entites;
        }


        /// <summary>
        /// Cập nhật một bản ghi
        /// </summary>
        /// <param name="entity">Bản ghi cần cập nhật</param>
        /// <returns>Số lượng bản ghi bị ảnh hưởng</returns>
        /// CreatedBy : DDHung (9/11/2021)
        public virtual async Task<int> UpdateEntity(TEntity entity)
        {
            var dynamicProps = new DynamicParameters();
            //Lấy ra các properties của đối tượng
            var props = entity.GetType().GetProperties();
            //Duyệt từng propertity
            foreach (var prop in props)
            {
                //Lấy tên của property
                var propName = prop.Name;
                var propValue = prop.GetValue(entity);
                var param = propName;
                dynamicProps.Add(param, propValue);
            }

            var rowAffects = 0;
            //_dbConnection.Open();
            using (var transaction = _dbConnection.BeginTransaction())
            {
                rowAffects = await _dbConnection.ExecuteAsync($"Proc_Update{_tableName}", entity, commandType: CommandType.StoredProcedure);
                transaction.Commit();
            }
            return rowAffects;
        }

        /// <summary>
        /// Dùng để đóng các kết nối với CSDL khi Object không còn sử dụng nữa.
        /// </summary>
        /// CreatedBy : DDHung (9/11/2021)
        public void Dispose()
        {
            if (_dbConnection.State == ConnectionState.Open)
                _dbConnection.Close();
        }

        #endregion

    }
}
