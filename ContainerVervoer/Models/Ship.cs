using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVervoer.Models
{
    public class Ship
    {
        public decimal RowBalance { get; set; }
        public double MaxWeight { get; }
        public double MinWeight { get; }
        public List<Place> Places { get; }

        public Ship(List<Place> places, double maxWeight)
        {
            Places = places;
            MaxWeight = maxWeight;
            MinWeight = CalculateMinWeight();
        }


        private double CalculateMinWeight()
        {
            return Convert.ToDouble(MaxWeight / 2);
        }

        public void Balance()
        {
            for (int i = 0; i < 6; i = i + 2)
            {
                if (Places[i + 1].Containers.Count != 0)
                {
                    if (!((Places[i].Weight - Places[i + 1].Weight) / Places[i + 1].Weight * 100 > -20)) continue;
                    foreach (var container in Places[i].Containers)
                    {
                        if (container.Valuable) continue;
                        var placed = Places[i + 1].AddContainer(container);
                        if (!placed) continue;
                        var deleted = Places[i].DeleteContainer(container);
                        if (!deleted) continue;
                        break;
                    }
                }
                else
                {
                    foreach (var container in Places[i].Containers)
                    {
                        if (container.Valuable) continue;
                        var placed = Places[i + 1].AddContainer(container);
                        if (!placed) continue;
                        var deleted = Places[i].DeleteContainer(container);
                        if (!deleted) continue;
                        break;
                    }
                }
            }
        }

        /// Calculates the balance between row 1 and row 2.
        public decimal CalculateBalance()
        {
            double row1 = 0;
            double row2 = 0;

            for (int i = 0; i < 6; i++)
            {
                if (i == 0 || i == 2 || i == 4)
                    row1 = row1 + Places[i].Weight;
                else
                    row2 = row2 + Places[i].Weight;
            }
            RowBalance = Convert.ToDecimal((row2 - row1) / row1 * 100);
            return RowBalance;
        }
    }
}
