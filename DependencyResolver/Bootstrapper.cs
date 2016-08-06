using Autofac;
using Common.Interfaces;
using Common.Results;
using Core.Armors;
using Core.Characters;
using Core.Deites;
using Core.Feats;
using Core.Items;
using Core.Items.DeleteItem;
using Core.Items.GetItem;
using Core.Items.GetItems;
using Core.Items.InsertItem;
using Core.Items.UpdateItem;
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
            //Builder.RegisterType<ItemRepository>().As<IItemRepository>().InstancePerRequest();

            //Builder.RegisterGeneric(typeof (DeleteItemHandler)).As(typeof (ICommandHandler<>));

            Builder.RegisterType<DeleteItemHandler>().As(typeof(ICommandHandler<DeleteItemRequest>)).InstancePerRequest();
            Builder.RegisterType<DeleteItemRepository>().As(typeof(ICommandRepository<DeleteItemRequest>)).InstancePerRequest();

            Builder.RegisterType<IQueryHandler<GetItemRequest, Result<GetItemResponse>>>().As<GetItemHandler>().InstancePerRequest();
            Builder.RegisterType<IQueryRepository<GetItemRequest, GetItemResponse>>().As<GetItemRepository>().InstancePerRequest();

            Builder.RegisterType<IQueryHandler<GetItemsRequest, Result<GetItemResponse>>>().As<GetItemsHandler>().InstancePerRequest();
            Builder.RegisterType<IQueryRepository<GetItemsRequest, GetItemResponse>>().As<GetItemsRepository>().InstancePerRequest();

            Builder.RegisterType<ICommandHandler<InsertItemRequest>>().As<InsertItemHandler>().InstancePerRequest();
            Builder.RegisterType<ICommandRepository<InsertItemRequest>>().As<InsertItemRepository>().InstancePerRequest();

            Builder.RegisterType<ICommandHandler<UpdateItemRequest>>().As<UpdateItemHandler>().InstancePerRequest();
            Builder.RegisterType<ICommandRepository<UpdateItemRequest>>().As<UpdateItemRepository>().InstancePerRequest();

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
