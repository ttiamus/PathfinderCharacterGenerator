using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Alignment;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DAL.Deity
{
    public class Deity
    {
        public ObjectId Id { get; set; }
        public string Description { get; set; }
        //List<DomainOption> Domains { get; set }
        public Alignment Alignment { get; set; }
        public Weapon.Weapon FavoredWeapon { get; set; }
    }
}
