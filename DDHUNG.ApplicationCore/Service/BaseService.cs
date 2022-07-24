using DDHUNG.ApplicationCore.Entity;
using DDHUNG.ApplicationCore.Enum;
using DDHUNG.ApplicationCore.Interface.Repository;
using DDHUNG.ApplicationCore.Interface.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDHUNG.ApplicationCore.Service
{
    /// <summary>
    /// Service thực hiện các nghiệp vụ dùng chung.
    /// </summary>
    /// <typeparam name="TEntity">Class truyền vào bắt buộc phải kế thừa từ class BaseEntity</typeparam>
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : BaseEntity
    {
        #region Declare

        /// <summary>
        /// Repository của phần base thực việc kết nối dữ liệu xuống database phục vụ cho việc xử lý các yêu cầu dùng chung
        /// </summary>
        protected IBaseRepository<TEntity> _baseRepository;

        /// <summary>
        /// Dùng để check xem mã code có bị trùng hay không
        /// </summary>
        protected bool isCheckDuplicateCode;

        /// <summary>
        /// Kết quả thống báo trả về chuẩn Resfull API
        /// </summary>
        protected ServiceResult _serviceResult;

        #endregion

        #region Constructor

        public BaseService(IBaseRepository<TEntity> baseRepository)
        {
            _baseRepository = baseRepository;
            _serviceResult = new ServiceResult() { DDHungCode = DDHUNGEnum.Success };
        }
        #endregion

        #region Method

        /// <summary>
        /// Thêm mới một bản ghi
        /// </summary>
        /// <param name="entity">Bản ghi cần thêm</param>
        /// <returns>Trả về thông báo kết quả sau khi thêm mới</returns>
        /// CreatedBy : DDHung(9/11/2021)
        public virtual async Task<ServiceResult> AddEntity(TEntity entity)
        {

            _serviceResult.Data = await _baseRepository.AddEntity(entity);
            return _serviceResult;

        }

        /// <summary>
        /// Thêm nhiều bản ghi
        /// </summary>
        /// <param name="lstEntity">Danh sách bản ghi được parse thành json</param>
        /// <returns></returns>
        /// CreatedBy : DDHung (23/07/2022)
        public virtual async Task<ServiceResult> AddMultyEntity(string lstEntity)
        {
            _serviceResult.Data = await _baseRepository.AddMultyEntity(lstEntity);
            return _serviceResult;
        }

        /// <summary>
        /// Lấy danh sách dữ liệu
        /// </summary>
        /// <returns>Danh sách dữ liệu</returns>
        /// CreatedBy : DDHung(9/11/2021)
        public virtual async Task<IEnumerable<TEntity>> GetEntities()
        {
            var entities = await _baseRepository.GetEntities();
            return entities;
        }


        /// <summary>
        /// Xóa một bản ghi
        /// </summary>
        /// <param name="entityId">Id bản ghi cần xóa</param>
        /// <returns>Số bản ghi bị ảnh hưởng</returns>
        /// CreatedBy : DDHung(9/11/2021)
        public async Task<int> DeleteEntity(string entityId)
        {
            return await _baseRepository.DeleteEntity(entityId);
        }


        /// <summary>
        /// Cập nhật một bản ghi
        /// </summary>
        /// <param name="entity">Bản ghi cần cập nhật</param>
        /// <returns>Trả về thông báo kết quả sau khi cập nhật</returns>
        /// CreatedBy : DDHung(9/11/2021)   
        public virtual async Task<ServiceResult> UpdateEntity(TEntity entity)
        {

            _serviceResult.Data = await _baseRepository.UpdateEntity(entity);

            return _serviceResult;
        }

       


        #endregion


    }
}
