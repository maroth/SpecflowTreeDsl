using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpecFlowTree
{
    public class BacklogItem
    {
        public string Name;

        public BacklogItem Parent;

        public BacklogItem(string Name, BacklogItem parent)
        {
            this.Name = Name;
            this.Parent = parent;
        }

        public List<BacklogItem> ChildList = new List<BacklogItem>();
    }
}
