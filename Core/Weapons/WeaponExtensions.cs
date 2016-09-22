using Core.Weapons.Requests;

namespace Core.Weapons
{
    public static class WeaponExtensions
    {
        public static bool Validate(this GetWeaponRequest request)
        {
            return request.Id != null;
        }

        public static bool Validate(this InsertWeaponRequest request)
        {
            return !string.IsNullOrWhiteSpace(request.Name)
                   && !string.IsNullOrWhiteSpace(request.CriticalThreatRange);
        }

        public static bool Validate(this UpdateWeaponRequest request)
        {
            return request.Id != null
                   && !string.IsNullOrWhiteSpace(request.Name)
                   && !string.IsNullOrWhiteSpace(request.CriticalThreatRange);
        }

        public static bool Validate(this DeleteWeaponRequest request)
        {
            return request.Id != null;
        }
    }
}