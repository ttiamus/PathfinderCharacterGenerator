using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DAL.Deity
{
    public class Deity
    {
        public ObjectId Id { get; set; }
    }
}
