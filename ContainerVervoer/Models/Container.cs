namespace ContainerVervoer.Models
{
    public class Container
    {
        public bool Valuable { get; }
        public bool Cooled { get; }
        public double Weight { get; }

        public Container(bool valuable, bool cooled, double weight)
        {
            Valuable = valuable;
            Cooled = cooled;
            Weight = weight;
        }

        public override string ToString()
        {
            return "Weight: " + Weight + ", Valuable: " + Valuable + ", Cooled: " + Cooled;
        }
    }
}
