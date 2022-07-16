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
    public class SlideRepository : BaseRepository<Slide>,ISlideRepository
    {
        #region Constructor
        public SlideRepository(IConfiguration configuration) : base(configuration)
        {

        }
        #endregion
    }
}
