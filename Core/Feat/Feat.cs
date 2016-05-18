using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Feat
{
    public class Feat
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public List<string> Requirements { get; set; }
        public string Effect { get; set; }
    }
}
