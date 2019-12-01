using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Gyakorlati_feladat.Entities
{
    public class User
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public string FirstName;
        public string LastName;
        public string FullName { get; set; }
    }
}
