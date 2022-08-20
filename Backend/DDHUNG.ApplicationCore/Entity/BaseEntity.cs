using DDHUNG.ApplicationCore.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDHUNG.ApplicationCore.Entity
{
    public class BaseEntity
    {
        #region Property

        /// <summary>
        /// Ngày tạo
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Được tạo bởi
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// Ngày sửa đổi
        /// </summary>
        public DateTime? ModifiedDate { get; set; }

        /// <summary>   
        /// Được Sửa đổi bởi
        /// </summary>
        public string ModifiedBy { get; set; }
        #endregion

    }
}
