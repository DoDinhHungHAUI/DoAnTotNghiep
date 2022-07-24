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
    public class UserService : BaseService<User>,IUserService
    {

        #region Declare

        private readonly IUserRepository _userRepository;

        #endregion

        #region Constructor
        public UserService(IUserRepository userRepository) : base(userRepository)
        {
            _userRepository = userRepository;
        }

        #endregion


        #region Method

        /// <summary>
        /// Check đăng nhập người dùng
        /// </summary>
        /// <param name="userEmail">Email người dùng</param>
        /// <param name="userPassWord">PassWord người dùng</param>
        /// <returns></returns>
        /// DDHung 24/07/2022
        public async Task<bool> checkLoginUser(string userEmail, string userPassWord)
        {
            var isCheck = false;
            var users = await _userRepository.GetEntities() as List<User>;
            
            if(users != null && users.Count > 0)
            {
                var userLogin = users.Where(x => x.UserEmail == userEmail && x.PassWord == userPassWord).ToList();

                if(userLogin != null && userLogin.Count > 0)
                {
                    isCheck = true;
                }    
            }

            return isCheck;
        }


        /// <summary>
        /// Lấy thông tin người dùng dựa vào userName và PassWord
        /// </summary>
        /// <param name="userEmail">Email người dùng</param>
        /// <param name="userPassWord">PassWord người dùng</param>
        /// <returns></returns>
        /// DDHung 24/07/2022
        public async Task<User> GetUserByNameAndPass(string userEmail, string userPassWord)
        {
            var users = await _userRepository.GetEntities() as List<User>;

            var userLogin = users.Where(x => x.UserEmail == userEmail && x.PassWord == userPassWord).ToList();

            return userLogin.FirstOrDefault();
        }


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
        public async Task<bool> Register(string UserName, string UserEmail, string PassWord, string UserPhone, string Address)
        {

            var userRegister = new User();
            userRegister.UserId = Guid.NewGuid();
            userRegister.UserName = UserName;
            userRegister.UserEmail = UserEmail;
            userRegister.PassWord = PassWord;
            userRegister.UserPhone = UserPhone;
            userRegister.Address = Address;
            userRegister.UserRole = (int)UserRole.User;

            var rowAffect = await _userRepository.AddEntity(userRegister);

            if(rowAffect > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }



        #endregion

    }
}
