using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCodeFirst.Entities
{
    public class Emploee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Phone { get; set; }
        


        public int Salary { get; set; }

        public ICollection<Facility> Facilities { get; set; }

        public virtual Occupation Occupation { get; set; }
    }
}
