using Core.Alignments;
using DAL.Weapons;
using MongoDB.Bson;

namespace DAL.Deities
{
    public class Deity
    {
        public ObjectId Id { get; set; }
        public string Description { get; set; }
        //List<DomainOption> Domains { get; set }
        public Alignment Alignment { get; set; }
        public Weapon FavoredWeapon { get; set; }
    }
}
