using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCodeFirst.Entities
{
    public class Facility
    {


        
        public int Id { get; set; }

        
        public string Address { get; set; }

        public int Area { get; set; }

        public ICollection<Emploee> Emploes { get; set; }

    }
}
