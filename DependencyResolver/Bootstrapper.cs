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
            Builder.RegisterType<ItemRepository>().As<IItemRepository>().InstancePerRequest();

            Builder.RegisterType<ICommandHandler<DeleteItemHandler>>().As<DeleteItemHandler>().InstancePerRequest();
            Builder.RegisterType<ICommandRepository<DeleteItemRepository>>().As<DeleteItemRepository>().InstancePerRequest();

            Builder.RegisterType<IQueryHandler<GetItemHandler, QueryResult<GetItemResponse>>>().As<GetItemHandler>().InstancePerRequest();
            Builder.RegisterType<IQueryRepository<GetItemRepository, GetItemResponse>>().As<GetItemRepository>().InstancePerRequest();
            Builder.RegisterType<IQueryHandler<GetItemsHandler, GetItemResponse>>().As<GetItemsHandler>().InstancePerRequest();
            Builder.RegisterType<IQueryRepository<GetItemsRepository, GetItemResponse>>().As<GetItemsRepository>().InstancePerRequest();


            Builder.RegisterType<IQueryHandler<InsertItemHandler, GetItemsRequest>>().As<InsertItemHandler>().InstancePerRequest();
            Builder.RegisterType<IQueryRepository<InsertItemRepository, GetItemsRequest>>().As<InsertItemRepository>().InstancePerRequest();
            Builder.RegisterType<IQueryHandler<UpdateItemHandler, GetItemsRequest>>().As<UpdateItemHandler>().InstancePerRequest();
            Builder.RegisterType<IQueryRepository<UpdateItemRepository, GetItemsRequest>>().As<UpdateItemRepository>().InstancePerRequest();

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
