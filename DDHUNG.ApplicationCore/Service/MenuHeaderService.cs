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
    public class MenuHeaderService : BaseService<MenuHeader>,IMenuHeaderService
    {
        #region Constructor
        public MenuHeaderService(IMenuHeaderRepository menuRepository) : base(menuRepository)
        {

        }
        #endregion
    }
}
