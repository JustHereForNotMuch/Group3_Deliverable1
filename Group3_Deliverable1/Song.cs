using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group3_Deliverable1
{

    public class song
    {
        public string filePath { get; set; }
        public string fileName { get; set; }

        public override string ToString()
        {
            return fileName;
        }
    }
}