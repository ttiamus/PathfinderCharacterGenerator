using Common.Interfaces;

namespace Core.V2.Weapons.GetWeapon
{
    public class GetWeaponRequest : IRequest
    {
        public string Id { get; set; } 
    }
}