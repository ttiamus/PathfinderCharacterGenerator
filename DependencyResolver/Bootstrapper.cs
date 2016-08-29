using System.Collections.Generic;
using Autofac;
using Common.Configuration;
using Common.Interfaces;
using Core.Armors;
using Core.Characters;
using Core.Deites;
using Core.Feats;
using Core.Items;
using Core.Races;
using Core.V2.Items.CreateItem;
using Core.V2.Items.DeleteItem;
using Core.V2.Items.GetAllItems;
using Core.V2.Items.GetItem;
using Core.V2.Items.Models.Responses;
using Core.V2.Items.UpdateItem;
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

            Builder.RegisterType<IApplicationConfiguration>().SingleInstance();

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

            //V2
            Builder.RegisterType<Core.V2.Items.ItemService>().As<Core.V2.Items.IItemService>().InstancePerRequest();

            Builder.RegisterType<GetAllItemsHandler>().As<IQueryHandler<GetAllItemsRequest, List<ItemResponse>>>().InstancePerRequest();
            Builder.RegisterType<GetAllItemsRepository>().As<IQueryRepository<GetAllItemsRequest, IEnumerable<ItemResponse>>>().InstancePerRequest();

            Builder.RegisterType<GetItemHandler>().As<IQueryHandler<GetItemRequest, ItemResponse>>().InstancePerRequest();
            Builder.RegisterType<GetItemRepository>().As<IQueryRepository<GetItemRequest, ItemResponse>>().InstancePerRequest();

            Builder.RegisterType<CreateItemHandler>().As<ICommandHandler<CreateItemRequest>>().InstancePerRequest();
            Builder.RegisterType<CreateItemRepository>().As<ICommandRepository<CreateItemRequest>>().InstancePerRequest();

            Builder.RegisterType<DeleteItemHandler>().As<ICommandHandler<DeleteItemRequest>>().InstancePerRequest();
            Builder.RegisterType<DeleteItemRepository>().As<ICommandRepository<DeleteItemRequest>>().InstancePerRequest();

            Builder.RegisterType<UpdateItemHandler>().As<ICommandHandler<UpdateItemRequest>>().InstancePerRequest();
            Builder.RegisterType<UpdateItemRepository>().As<ICommandRepository<UpdateItemRequest>>().InstancePerRequest();

            return Builder;
        }
    }
}
