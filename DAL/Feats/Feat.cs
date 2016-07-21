using System.Collections.Generic;
using MongoDB.Bson;

namespace DAL.Feats
{
    public class Feat
    {
        public ObjectId Id { get; set; }
        public string Description { get; set; }
        public List<string> Requirements { get; set; }
        public string Effect { get; set; }
    }
}
