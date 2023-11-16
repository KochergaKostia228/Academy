using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Академія.Domain.Task;

namespace Академія.Domain.Items
{
    internal class ListItems
    {
        public DayOfWeek DayOfWeek;

        public List<MyItems> myItems = null;

        public ListItems(DayOfWeek dayOfWeek) 
        {
            myItems = new List<MyItems>();
            DayOfWeek = dayOfWeek;
        }

        public void AddItems(MyItems myitems) { myItems.Add(myitems); }

        public void DeleteItems(MyItems myitems) { myItems.Remove(myitems); }

        public List<MyItems> GetItems() { return myItems; }

    }
}
