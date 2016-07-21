using Core.Alignments;
using Core.Weapons;

namespace Core.Deites
{
    public class Deity
    {
        public string Id { get; set; }
        public string Description { get; set; }
        //List<DomainOption> Domains { get; set }
        public Alignment Alignment { get; set; }
        public Weapon FavoredWeapon { get; set; }
    }
}
