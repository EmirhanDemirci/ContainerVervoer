using System;
using System.Collections.Generic;
using System.ComponentModel;
using ContainerVervoer;
using ContainerVervoer.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Container = ContainerVervoer.Models.Container;

namespace ContainerVervoerTest
{
    [TestClass]
    public class PlaceTests
    {
        private Place _place;
        private Container _container;

        [TestInitialize]
        public void TestInitialize()
        {
            _place = new Place(1);
        }
        [TestMethod]
        public void AddContainerTest()
        {
            _container = new Container(false, false, 4000);
            var added = _place.AddContainer(_container);
            Assert.IsTrue(added);
        }

        [TestMethod]
        public void DeleteContainerTest()
        {
            _container = new Container(false, false, 4000);
            _place.AddContainer(_container);
            var deleted = _place.DeleteContainer(_container);
            Assert.IsTrue(deleted);
        }

        [TestMethod]
        public void SetPositionTest()
        {
            var containers = new List<Container> { new Container(true, false, 30000) };
            for (int i = 0; i < 4; i++)
                containers.Add(new Container(false, false, 30000));

            foreach (var container in containers)
                _place.AddContainer(container);

            _place.SetPosition();
            Assert.AreEqual(_place.Containers[4].Valuable, true);
        }
    }
}
