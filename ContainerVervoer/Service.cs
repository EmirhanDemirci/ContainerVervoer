﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContainerVervoer.Models;

namespace ContainerVervoer
{
    public class Service
    {
        private Ship _ship;

        public Service(int places, double weight)
        {
            SetShip(places, weight);
        }

        /// Quick checker already calculates if it's eligible for the ship.
        /// <param name="containers">List of containers</param>
        public void QuickChecker(List<Container> containers)
        {
            var valuable = 0;
            double weight = 0;
            double cooledWeight = 0;
            double maxCooledWeight = 300000;

            foreach (var container in containers)
            {
                if (container.Valuable)
                {
                    valuable = valuable + 1;
                    if (valuable <= 2)
                        maxCooledWeight = maxCooledWeight - container.Weight;
                }
                if (container.Cooled)
                    cooledWeight = cooledWeight + container.Weight;

                weight = weight + container.Weight;
            }

            // Throws exception for these situations.
            if (cooledWeight > maxCooledWeight)
                throw new ExceptionHandler(
                    "Weight of all cooled containers is exceeding over the maximum capacity of " +
                    maxCooledWeight + " (Calculated by the weight of all valuable containers). This won't fit in the front side of the ship. Current weight: " + cooledWeight);
            if (valuable > 4)
                throw new ExceptionHandler(
                    "Can't add more then 4 valuable containers. Current: " + valuable);
            if (weight < _ship.MinWeight)
                throw new ExceptionHandler(
                    "Weight is under the minimum capacity of " + _ship.MinWeight + ". More weight is needed to prevent capsizing. Current weight: " + weight);
            if (weight > _ship.MaxWeight)
                throw new ExceptionHandler(
                    "Weight is exceeding over the maximum capacity of " + _ship.MaxWeight + ". The ship can't handle it! Current weight: " + weight);
        }

        /// Setting the containers in places.
        /// <param name="containers">List of containers</param>
        public bool SetContainers(List<Container> containers)
        {
            // Setting the containers in places.
            if (OrderContainers(containers).Any(container => !Insert(container)))
                throw new ExceptionHandler("Something went wrong!");

            // Balances the ship to prevent capsizing.
            var balance = _ship.CalculateBalance();
            while (balance < -20)
            {
                _ship.Balance();
                balance = _ship.CalculateBalance();
            }

            // Setting valuables containers on top.
            foreach (var shipPlace in _ship.Places)
                shipPlace.SetPosition();

            return true;
        }

        /// Orders the containers in a specifc order.
        /// <param name="containers">IEnumerarble of containers</param>
        private IEnumerable<Container> OrderContainers(IEnumerable<Container> containers)
        {
            var cooled = new List<Container>();
            var valuable = new List<Container>();
            var normal = new List<Container>();
            var ordendContainers = new List<Container>();

            foreach (var container in containers)
            {
                if (container.Cooled)
                    cooled.Add(container);
                else if (container.Valuable)
                    valuable.Add(container);
                else
                    normal.Add(container);
            }

            ordendContainers.AddRange(valuable);
            ordendContainers.AddRange(cooled);
            ordendContainers.AddRange(normal);
            return ordendContainers;
        }

        /// Inserts the containcers in places.
        /// <param name="model">Containcer model</param>
        private bool Insert(Container model)
        {
            if (model.Valuable)
            {
                if (_ship.Places[0].AddContainer(model) || _ship.Places[1].AddContainer(model) || _ship.Places[4].AddContainer(model) || _ship.Places[5].AddContainer(model))
                    return true;
            }
            else if (model.Cooled)
            {
                if (_ship.Places[0].AddContainer(model) || _ship.Places[1].AddContainer(model))
                    return true;
            }
            else
            {
                foreach (var shipPlace in _ship.Places)
                {
                    if (!shipPlace.AddContainer(model)) continue;
                    return true;
                }
            }
            return false;
        }

        /// Setting the ship usable.
        /// <param name="placesAmount">Ammount of places</param>
        /// <param name="weight">Ship weight</param>
        private void SetShip(int placesAmount, double weight)
        {
            var places = new List<Place>();
            for (int i = 1; i <= placesAmount; i++)
            {
                places.Add(new Place(i));
            }
            _ship = new Ship(places, weight);
        }

        /// Calculates the total weight of the ship.
        public double CalculateWeight()
        {
            double weight = 0;
            for (int i = 0; i < 6; i++)
                weight = weight + _ship.Places[i].Weight;
            return weight;
        }

        /// Get's all the places of the ship.
        /// <returns>List of places</returns>
        public List<Place> GetPlaces()
        {
            return _ship.Places;
        }

        /// Get's the ship balance
        /// <returns>Decimal</returns>
        public decimal GetShipBalance()
        {
            return _ship.RowBalance;
        }
    }
}
