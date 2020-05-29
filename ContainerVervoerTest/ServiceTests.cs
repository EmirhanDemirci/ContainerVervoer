using System;
using System.Collections.Generic;
using System.ComponentModel;
using ContainerVervoer;
using ContainerVervoer.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ContainerVervoerTest
{
    [TestClass()]
    public class ServiceTests
    {
        private List<ContainerVervoer.Models.Container> _containers;
        private Service _service;
        private int _weight;

        [TestInitialize]
        public void TestInitialize()
        {
            _containers = new List<ContainerVervoer.Models.Container>();
            _weight = 900000;
        }

        /// Weight exceeding over maximum capacity.
        [TestMethod]
        [ExpectedException(typeof(ExceptionHandler))]
        public void HighWeightTest()
        {
            _service = new Service(6, _weight);
            for (int i = 0; i < 40; i++)
                _containers.Add(new ContainerVervoer.Models.Container(false, false, 30000));

            _service.QuickChecker(_containers);
        }

        /// Weight lower then the minWeight.
        [TestMethod]
        [ExpectedException(typeof(ExceptionHandler))]
        public void LowWeightTest()
        {
            _service = new Service(6, _weight);
            for (int i = 0; i < 4; i++)
                _containers.Add(new ContainerVervoer.Models.Container(false, false, 30000));

            _service.QuickChecker(_containers);
        }

        /// Sets containers.
        [TestMethod]
        public void SetContainersTest()
        {
            _service = new Service(6, _weight);
            for (int i = 0; i < 2; i++)
                _containers.Add(new ContainerVervoer.Models.Container(false, false, 30000));

            var setted = _service.SetContainers(_containers);
            Assert.IsTrue(setted);
        }

        /// Trying to get weight without filling the places.
        [TestMethod]
        public void CalculateWeightTest()
        {
            _service = new Service(6, _weight);
            var weight = _service.CalculateWeight();
            Assert.AreEqual(weight, 0);
        }

        /// Places always returns 6 intitialized places.
        [TestMethod]
        public void GetPlacesTest()
        {
            _service = new Service(6, _weight);
            for (int i = 0; i < 30; i++)
                _containers.Add(new ContainerVervoer.Models.Container(false, false, 30000));

            var places = _service.GetPlaces();
            Assert.AreEqual(places.Count, 6);
        }

        /// 30 containers with a weight of 30000 is possible to balance it to 0%.
        [TestMethod]
        public void GetShipBalanceTest()
        {
            _service = new Service(6, _weight);
            for (int i = 0; i < 30; i++)
                _containers.Add(new ContainerVervoer.Models.Container(false, false, 30000));
            _service.SetContainers(_containers);
            var balance = _service.GetShipBalance();
            Assert.AreEqual(balance, 0);
        }
    }
}
