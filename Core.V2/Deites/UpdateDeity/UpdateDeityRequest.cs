using System.Collections.Generic;
using Core.V2.Alignments.Models.Data;
using Core.V2.Domains.UpdateDomain;

namespace Core.V2.Deites.UpdateDeity
{
    public class UpdateDeityRequest
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public IEnumerable<UpdateDomainRequest> Domains { get; set; }
        public Alignment Alignment { get; set; }
        public string FavoredWeaponId { get; set; }
    }
}