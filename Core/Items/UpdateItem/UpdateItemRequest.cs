using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Items.UpdateItem
{
    public class UpdateItemRequest
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }           //In gp
        public decimal Weight { get; set; }         //In lbs
    }
}
