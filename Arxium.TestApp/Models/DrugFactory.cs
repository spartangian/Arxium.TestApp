using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arxium.TestApp.Models
{
    public static class DrugFactory
    {
        public static Drug CreateDrug(string name)
        {
            return new Drug
            {
                Name = name,
                Id = Guid.NewGuid()
            };
        }
    }

}
