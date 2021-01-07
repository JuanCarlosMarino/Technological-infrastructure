using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnologicalInfrastructure.Entities
{
    class Registro
    {
        public int ID { get; set; }

        public int AP_ID { get; set; }

        public int EQ_ID { get; set; }

        public DateTime Fecha { get; set; }

        public int Puerto { get; set; }

        public Registro()
        {
        }
    }
}
