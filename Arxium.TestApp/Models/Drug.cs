using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arxium.TestApp.Models
{
    public class Drug
    {
        public string Name { get; set; }
        public Guid Id { get; set; }
        private int Count = 0;
        private int PreviousCount = 0;

        public Drug()
        {
        }

        public void Increment(int count)
        {
            PreviousCount = Count;
            Count += count;
        }

        public string GetCount()
        {
            return Count.ToString();
        }

        public string GetPreviousCount()
        {
            return PreviousCount.ToString();
        }

        public void Reset()
        {
            PreviousCount = Count;
            Count = 0;
        }
    }
}
