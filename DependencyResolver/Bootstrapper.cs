using Autofac;
using Core.Armor;
using Core.Character;
using Core.Deity;
using Core.Feat;
using Core.Item;
using Core.Race;
using Core.Weapon;
using DAL.Armor;
using DAL.Character;
using DAL.Deity;
using DAL.Feat;
using DAL.Item;
using DAL.Race;
using DAL.Weapon;

namespace DependencyResolver
{
    public class Bootstrapper
    {

        public ContainerBuilder GetBuilder()
        {
            var Builder = new ContainerBuilder();
            
            //Armor
            Builder.RegisterType<ArmorService>().As<IArmorService>().InstancePerRequest();
            Builder.RegisterType<ArmorRepository>().As<IArmorRepository>().InstancePerRequest();

            //Character
            Builder.RegisterType<CharacterService>().As<ICharacterService>().InstancePerRequest();
            Builder.RegisterType<CharacterRepository>().As<ICharacterRepository>().InstancePerRequest();

            //Deity
            Builder.RegisterType<DeityService>().As<IDeityService>().InstancePerRequest();
            Builder.RegisterType<DeityRepository>().As<IDeityRepository>().InstancePerRequest();

            //Feat
            Builder.RegisterType<FeatService>().As<IFeatService>().InstancePerRequest();
            Builder.RegisterType<FeatRepository>().As<IFeatRepository>().InstancePerRequest();

            //Item
            Builder.RegisterType<ItemService>().As<IItemService>().InstancePerRequest();
            Builder.RegisterType<ItemRepository>().As<IItemRepository>().InstancePerRequest();

            //Race
            Builder.RegisterType<RaceService>().As<IRaceService>().InstancePerRequest();
            Builder.RegisterType<RaceRepository>().As<IRaceRepository>().InstancePerRequest();

            //Weapon
            Builder.RegisterType<WeaponService>().As<IWeaponService>().InstancePerRequest();
            Builder.RegisterType<WeaponRepository>().As<IWeaponRepository>().InstancePerRequest();

            return Builder;
        }
    }
}
