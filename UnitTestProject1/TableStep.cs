using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace UnitTestProject1
{
    class MyTableClass
    {
        public int id { get; set; }

        public string PizzaType { get; set; }

        public bool Price { get; set; }

    }

    [Binding]
    class TableStep
    {
        private Dictionary<int, MyTableClass> Objects;

        public TableStep()
        {
            Objects = new Dictionary<int, MyTableClass>();
        }
        [TestMethod]
        [Given(@"the following table:")]
        public void GivenTheFollowingTable(Table table)
        {
            var rows = table.CreateSet<MyTableClass>();
            foreach (MyTableClass row in rows)
            {
                this.Objects.Add(row.id, row);
            }
        }
        [TestMethod]
        [Then(@"my binding should have the following objects")]
        public void ThenMyBindingShouldHaveTheFollowingObjects(Table table)
        {
            var excpectedObjects = table.CreateSet<MyTableClass>();
            foreach (MyTableClass excpectedObject in excpectedObjects)
            {
                MyTableClass actualObject = this.Objects[excpectedObject.id];
                if (!actualObject.PizzaType.Equals(excpectedObject.PizzaType))
                {
                    Assert.Fail("PizzaType doesn't match");
                }
                if (!actualObject.Price.Equals(excpectedObject.Price))
                {
                    Assert.Fail("PizzaType doesn't match");
                }
                Assert.Equals(actualObject.Price, excpectedObject.Price);
                Assert.Equals(actualObject.PizzaType, excpectedObject.PizzaType);
            }
        }
    }
}
