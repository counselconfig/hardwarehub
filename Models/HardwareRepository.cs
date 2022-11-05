using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COSE71197_DL.Models
{
    public class HardwareRepository : IHardwareRepository
    {
        private readonly AppDbContext _appDbContext;

        public HardwareRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Hardware> GetAllHardware
        {
            get
            {
                return _appDbContext.Hardwares.Include(h => h.Category);
            }
        }

        public IEnumerable<Hardware> GetHardwareOnSale
        {
            get
            {
                return _appDbContext.Hardwares.Include(h => h.Category).Where(p => p.IsOnSale);
            }
        }

        public Hardware GetHardwareByID(int hardwareId)
        {
            return _appDbContext.Hardwares.FirstOrDefault(h => h.HardwareId == hardwareId);
        }
    }
}


