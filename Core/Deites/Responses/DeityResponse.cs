using System.Collections.Generic;
using Core.Alignments;
using Core.Domains.Responses;
using Core.Weapons.Responses;

namespace Core.Deites.Responses
{
    public class DeityResponse
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public IEnumerable<DomainResponse> Domains { get; set; }
        public Alignment Alignment { get; set; }
        public WeaponResponse FavoredWeapon { get; set; }
    }
}
