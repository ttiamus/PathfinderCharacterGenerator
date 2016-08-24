using System.Collections.Generic;
using Core.V2.Alignments.Models.Data;
using Core.V2.Domains.Models.Responses;
using Core.V2.Weapons.Models.Responses;

namespace Core.V2.Deites.Models.Responses
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
