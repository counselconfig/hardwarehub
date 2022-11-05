using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COSE71197_DL.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories { get; }
    }
}
