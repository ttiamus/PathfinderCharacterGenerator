using Autofac;
using Core.Armors;
using Core.Characters;
using Core.Deites;
using Core.Feats;
using Core.Items;
using Core.Races;
using Core.Weapons;
using DAL.Armors;
using DAL.Characters;
using DAL.Deities;
using DAL.Feats;
using DAL.Items;
using DAL.Races;
using DAL.Weapons;

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
