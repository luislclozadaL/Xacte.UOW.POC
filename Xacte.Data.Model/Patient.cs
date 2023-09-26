using System;
using System.Linq;

namespace Xacte.Data.Model
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
