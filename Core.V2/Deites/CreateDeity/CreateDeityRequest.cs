using System.Collections.Generic;
using Core.V2.Alignments.Models.Data;
using Core.V2.Domains.CreateDomain;

namespace Core.V2.Deites.CreateDeity
{
    public class CreateDeityRequest
    {
        public string Description { get; set; }
        public IEnumerable<CreateDomainRequest> Domains { get; set; }
        public Alignment Alignment { get; set; }
        public string FavoredWeaponId { get; set; }
    }
}