using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Models.ViewModels
{
    public class SalesRecordFormViewModel
    {
        public SalesRecord SalesRecord { get; set; }
        public ICollection<Seller> Sellers { get; set; }
        public SelectList Teste { get; set; }

        /*public SelectList Teste()
        {
            var directions = from SaleStatus d in Enum.GetValues(typeof(SaleStatus))
                             select new { Id = (int)d, Name = d.ToString() };
            return new SelectList(directions, "Id", "Name");
        }*/
    }
}
