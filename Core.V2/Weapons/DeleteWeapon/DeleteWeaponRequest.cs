using Common.Interfaces;

namespace Core.V2.Weapons.DeleteWeapon
{
    public class DeleteWeaponRequest : IRequest
    {
        public string Id { get; set; } 
    }
}