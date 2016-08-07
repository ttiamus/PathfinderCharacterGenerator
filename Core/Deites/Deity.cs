using Core.Alignments;
using Core.Weapons.Responses;

namespace Core.Deites
{
    public class Deity
    {
        public string Id { get; set; }
        public string Description { get; set; }
        //List<DomainOption> Domains { get; set }
        public Alignment Alignment { get; set; }
        public WeaponResponse FavoredWeapon { get; set; }
    }
}
