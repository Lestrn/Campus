using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campus
{
    public static class  CampusExtension
    {
        public static void AddDiningroom(this Campus campus) // Extension Method
        {
            campus.RevenuePerMonth = campus.RevenuePerMonth + (campus.RevenuePerMonth * 0.20m); // + 20%
            campus.AmountOfPersonal += 5;
        }
    }
}
