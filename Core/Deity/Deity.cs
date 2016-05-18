using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Deity
{
    public class Deity
    {
        public string Id { get; set; }
        public string Description { get; set; }
        //List<DomainOption> Domains { get; set }
        public Alignment.Alignment Alignment { get; set; }
        public Weapon.Weapon FavoredWeapon { get; set; }
    }
}
