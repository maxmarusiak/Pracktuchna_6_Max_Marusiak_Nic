namespace StudentGroupSystem.Shapes
{
    public abstract class Shape
    {
        public string Name { get; set; }
        public string Color { get; set; }

        public virtual double CalculateArea()
        {
            return 0;
        }

        public virtual double CalculatePerimeter()
        {
            return 0;
        }

        public abstract string GetDescription();
    }
}
