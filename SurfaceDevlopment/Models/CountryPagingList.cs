using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurfaceDevlopment.Models
{
  public class CountryPagingList
  {
    public Pagination Pagination { get; set; }
    public List<Country> CountryList { get; set; }
  }
}
