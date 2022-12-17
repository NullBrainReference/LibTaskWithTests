using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTask
{
    public class TriangleExistenceException: Exception
    {
        public TriangleExistenceException(): base("Trianle doesn't exist")
        {
            
        }
    }
}
