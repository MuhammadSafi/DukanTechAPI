using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DukanTechAPI.Entities
{
    public class Products
    {
       
        public Guid Id { get; set; }

       
        public string BarCode { get; set; }

       
        public string Description { get; set; }

        public float Weight { get; set; }

       
        public int Status { get; set; }

    }
}
