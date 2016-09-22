using System.Collections.Generic;
using System.Threading.Tasks;
using Common.Interfaces;
using Core.V2.Items.CreateItem;
using Core.V2.Items.DeleteItem;
using Core.V2.Items.GetAllItems;
using Core.V2.Items.GetItem;
using Core.V2.Items.Models.Responses;
using Core.V2.Items.UpdateItem;

namespace Core.V2.Items
{
    public class ItemService : IItemService
    {
        private readonly IQueryHandler<GetAllItemsRequest, List<ItemResponse>> getAllItems;
        private readonly IQueryHandler<GetItemRequest, ItemResponse> getItem;
        private readonly ICommandHandler<CreateItemRequest> createItem;
        private readonly ICommandHandler<UpdateItemRequest> updateItem;
        private readonly ICommandHandler<DeleteItemRequest> deleteItem;

        public ItemService(
            IQueryHandler<GetAllItemsRequest, List<ItemResponse>> getAllItems,
            IQueryHandler<GetItemRequest, ItemResponse> getItem,
            ICommandHandler<CreateItemRequest> createItem,
            ICommandHandler<UpdateItemRequest> updateItem,
            ICommandHandler<DeleteItemRequest> deleteItem
            )
        {
            this.getAllItems = getAllItems;
            this.getItem = getItem;
            this.createItem = createItem;
            this.updateItem = updateItem;
            this.deleteItem = deleteItem;
        }

        public async Task<List<ItemResponse>> GetAllItems(GetAllItemsRequest request)
        {
            return await getAllItems.Execute(request);
        }

        public async Task<ItemResponse> GetItem(GetItemRequest request)
        {
            return await getItem.Execute(request);
        }

        public async Task CreateItem(CreateItemRequest request)
        {
            await createItem.Execute(request);
        }

        public async Task UpdateItem(UpdateItemRequest request)
        {
            await updateItem.Execute(request);
        }

        public async Task DeleteItem(DeleteItemRequest request)
        {
            await deleteItem.Execute(request);
        }
    }
}
