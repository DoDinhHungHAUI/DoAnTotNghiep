using DDHUNG.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDHUNG.ApplicationCore.Interface.Service
{
    public interface IUserService : IBaseService<User>
    {


        /// <summary>
        /// Check đăng nhập người dùng
        /// </summary>
        /// <param name="userEmail">Email người dùng</param>
        /// <param name="userPassWord">PassWord người dùng</param>
        /// <returns></returns>
        /// DDHung 24/07/2022
        Task<bool> checkLoginUser(string userEmail,string userPassWord);


        /// <summary>
        /// Lấy thông tin người dùng dựa vào userName và PassWord
        /// </summary>
        /// <param name="userEmail">Email người dùng</param>
        /// <param name="userPassWord">PassWord người dùng</param>
        /// <returns></returns>
        /// DDHung 24/07/2022
        Task<User> GetUserByNameAndPass(string userEmail, string userPassWord);


        /// <summary>
        /// Đăng ký tài khoản
        /// </summary>
        /// <param name="UserName">Tên người sử dụng</param>
        /// <param name="UserEmail">Email</param>
        /// <param name="PassWord">Mật khẩu </param>
        /// <param name="UserPhone">Điện thoại</param>
        /// <param name="Address">Địa chỉ</param>
        /// <returns></returns>
        /// DDHung 24/07/2022
        Task<bool> Register(string UserName, string UserEmail, string PassWord, string UserPhone, string Address);

    }
}
