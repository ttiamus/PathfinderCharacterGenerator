using System.Collections.Generic;
using Core.Alignments;
using DAL.Domains;
using DAL.Weapons;
using MongoDB.Bson;

namespace DAL.Deities
{
    public class Deity
    {
        public ObjectId Id { get; set; }
        public string Description { get; set; }
        public IEnumerable<Domain> Domains { get; set; }
        public Alignment Alignment { get; set; }
        public Weapon FavoredWeapon { get; set; }
    }
}
