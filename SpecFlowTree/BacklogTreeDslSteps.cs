using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using TechTalk.SpecFlow;

namespace SpecFlowTree
{
    [Binding]
    internal class BacklogTreeDslSteps
    {
        private readonly List<BacklogItem> rootItems = new List<BacklogItem>();

        private readonly Dictionary<string, BacklogItem> allItems = new Dictionary<string, BacklogItem>();

        [Given(@"a backlog item named '(.*)'")]
        public void GivenRootBacklogItem(string name)
        {
            var newItem = new BacklogItem(name, null);
            rootItems.Add(newItem);
            allItems.Add(newItem.Name, newItem);
        }

        [Given(@"a child backlog item named '(.*)' with parent '(.*)'")]
        public void GivenRootBacklogItem(string name, string parentName)
        {
            var parent = allItems[parentName];
            var newItem = new BacklogItem(name, parent);
            parent.ChildList.Add(newItem);
            allItems.Add(newItem.Name, newItem);
        }

        [When(@"I run the test")]
        public void WhenIRunTheTest()
        {
            new BacklogTreeTests().RunTest_WithPreparedBacklogItemTree(rootItems);
        }

        [Then(@"the test should pretty print a tree of backlog items")]
        public void ThenTheTestShouldPrettyPrintATreeOfBacklogItems()
        {
            //do nothing :)
        }
}
}
