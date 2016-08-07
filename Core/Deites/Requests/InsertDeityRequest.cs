using System.Collections.Generic;
using Core.Alignments;
using Core.Domains;
using Core.Domains.Requests;
using Core.Weapons.Requests;
using Core.Weapons.Responses;

namespace Core.Deites.Requests
{
    public class InsertDeityRequest
    {
        public string Description { get; set; }
        public IEnumerable<InsertDomainRequest> Domains { get; set; }
        public Alignment Alignment { get; set; }
        public string FavoredWeaponId { get; set; }
    }
}