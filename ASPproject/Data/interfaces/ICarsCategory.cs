using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPproject.Data.Models.interfaces
{
    public interface ICarsCategory
    {
       IEnumerable<Category> AllCategories { get; }
    }
}
