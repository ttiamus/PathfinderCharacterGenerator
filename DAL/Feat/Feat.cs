using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DAL.Feat
{
    public class Feat
    {
        public ObjectId Id { get; set; }
        public string Description { get; set; }
        public List<string> Requirements { get; set; }
        public string Effect { get; set; }
    }
}
