using System.Collections.Generic;
using Core.Alignments;
using Core.Domains;
using Core.Domains.Requests;
using Core.Weapons.Requests;
using Core.Weapons.Responses;

namespace Core.Deites.Requests
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