using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpecFlowTree
{
    using NUnit.Framework;

    class BacklogTreeTests
    {
        [Test]
        public void RunTest_WithPreparedBacklogItemTree(List<BacklogItem> rootItems)
        {
            Console.WriteLine("MY BACKLOG ITEM TREE");
            foreach (var item in rootItems)
            {
                this.PrintChild(item, string.Empty);
            }

        }

        private void PrintChild(BacklogItem item, string indent)
        {
            Console.WriteLine(indent + item.Name);
            foreach (var child in item.ChildList)
            {
                this.PrintChild(child, indent + "    ");
            }
        }
    }
}
