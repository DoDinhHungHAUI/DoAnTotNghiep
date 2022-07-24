using DDHUNG.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDHUNG.ApplicationCore.ViewModel
{
    public class HomeViewModel
    {
        /// <summary>
        /// List điện thoại mới nhất
        /// </summary>
        public IList<Product> PhoneLatests { set; get; }

        /// <summary>
        /// List Laptop mới nhất
        /// </summary>
        public IList<Product> LaptopLatests { set; get; }

        /// <summary>
        /// Máy tính bảng mới nhất
        /// </summary>
        public IList<Product> TabletLatests { set; get; }


    }
}
