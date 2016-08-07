using System.Linq;
using Core.Deites;
using Core.Deites.Requests;
using Core.Deites.Responses;
using DAL.Domains;
using DAL.Weapons;
using MongoDB.Bson;

namespace DAL.Deities
{
    public static class DeityMapper
    {
        public static DeityResponse ToDeityResponse(this Deity deity)
        {
            return new DeityResponse()
            {
                Id = deity.Id.ToString(),
                Description = deity.Description,
                Domains = deity.Domains.Select(x => x.ToDomainResponse()),
                Alignment = deity.Alignment,
                FavoredWeapon = deity.FavoredWeapon.ToWeaponResponse()
            };
        }

        public static Deity ToDeity(this InsertDeityRequest request)
        {
            return new Deity()
            {
                Description = request.Description,
                Domains = request.Domains.Select(x => x.ToDomain()),
                Alignment = request.Alignment,
                FavoredWeapon = request.FavoredWeapon.ToWeapon()
            };
        }

        public static Deity ToDeity(this UpdateDeityRequest request)
        {
            return new Deity()
            {
                Id = ObjectId.Parse(request.Id),
                Description = request.Description,
                Domains = request.Domains.Select(x => x.ToDomain()),
                Alignment = request.Alignment,
                FavoredWeapon = request.FavoredWeapon.ToWeapon()
            };
        }
    }
}
