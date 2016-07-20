using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Item;
using Item = Core.Item.Item;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var itemRepo = new ItemRepository();

            var item = new Core.Item.Item();
            item.Cost = 3;
            item.Weight = 4;
            item.Name = "Some Item";

            itemRepo.InsertItem(item).Wait();

            var items = itemRepo.GetItems().Result;

            Console.ReadLine();
        }
    }
}
