using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVervoer.Models
{
    public class Place
    {
        public List<Container> Containers { get; } = new List<Container>();
        public double Weight { get; private set; }
        public int Position { get; }

        public Place(int position)
        {
            Position = position;
        }

        /// Add the container to the list while checking weight.
        /// <param name="model"></param>
        public bool AddContainer(Container model)
        {
            if (model.Valuable && Containers.Find(x => (x.Valuable)) != null) return false;
            if (!CheckWeight(model.Weight)) return false;
            Containers.Add(model);
            return true;
        }

        /// Deleting container and substracting weight.
        /// <param name="model"></param>
        public bool DeleteContainer(Container model)
        {
            var deleted = Containers.Remove(model);
            if (!deleted) return false;
            Weight = Weight - model.Weight;
            return true;
        }

        /// Checking weight of place.
        /// <param name="weight"></param>
        private bool CheckWeight(double weight)
        {
            if (!(Weight + weight <= 150000)) return false;
            Weight = Weight + weight;
            return true;
        }

        /// SetPosition make's sure that valuable containers get placed on top.
        public void SetPosition()
        {
            if (Containers.Find(x => (x.Valuable)) != null)
            {
                var valuable = Containers[0];
                Containers.RemoveAt(0);
                Containers.Add(valuable);
            };
        }
    }
}
