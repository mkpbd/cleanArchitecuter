using FirstDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo.Persistence.Seeds
{
    internal static class StudentSeed
    {
        public static IList<Student> Students
        {
            get
            {
                return new List<Student>
                {
                    new Student { Id = 1, Name = "Jalaluddin", Cgpa = 2.0 },
                    new Student { Id = 2, Name = "Tareq", Cgpa = 3.0 },
                    new Student { Id = 3, Name = "Hasan", Cgpa = 3.2 },
                };
            }
        }
    }
}
