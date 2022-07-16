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
    public class UserService : BaseService<User>,IUserService
    {
        #region Constructor
        public UserService(IUserRepository customerRepository) : base(customerRepository)
        {

        }
        #endregion

    }
}
