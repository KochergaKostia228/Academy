using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Академія.Domain.Items
{
    public class MyItems
    {
        public string name;

        public string Name { get { return name; } }

        public MyItems(string name) {  this.name = name; }


    }
}
