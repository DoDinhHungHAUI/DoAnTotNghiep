using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDHUNG.ApplicationCore.Enum
{

    /// <summary>
    /// Misa code để xác định trạng thái của việc validate
    /// </summary>
    public enum DDHUNGEnum
    {
        /// <summary>
        /// Dữ liệu hợp lệ
        /// </summary>
        IsValid = 100,
        /// <summary>
        /// Dự liệu không hợp lệ
        /// </summary>
        NotValid = 900,
        /// <summary>
        /// Thành công
        /// </summary>
        Success = 200,
        /// <summary>
        /// Exception   
        /// </summary>
        Exception = 500
    }


    /// <summary>
    /// Xác định trạng thái của Object
    /// </summary>
    public enum EntityState
    {
        /// <summary>
        /// Thêm mới bản ghi
        /// </summary>
        AddNew = 1,
        /// <summary>
        /// Cập nhật bản ghi
        /// </summary>
        Update = 2,
        /// <summary>
        /// Xóa bản ghi
        /// </summary>
        Delete = 3

    }

    /// <summary>
    /// Loại sản phẩm
    /// </summary>
    public enum TypeProduct
    {
        /// <summary>
        /// Điện thoại
        /// </summary>
        Phone = 1,
        
        /// <summary>
        /// Laptop
        /// </summary>
        Laptop = 2,

        /// <summary>
        /// Máy tính bảng
        /// </summary>
        Tablet  = 3


    }

    /// <summary>
    /// Phân quyền người dùng
    /// 1. admin
    /// 2. User 
    /// </summary>
    public enum UserRole
    {
        Admin = 1,
        User = 2
    }

}
