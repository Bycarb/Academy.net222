namespace LogisticaLibrary
{
    public class Pacco : Spedizione
    {
        public double Height { get; private set; }
        public double Width { get; private set; }
        public double Depth { get; private set; }
        public Pacco(int id, string sender, string receiver, double value, double height, double width, double depth) : base(id, sender, receiver, value)
        {
            Height = height;
            Width = width;
            Depth = depth;
        }
        public override double Ingombro()
        {
            return Height * Width * Depth;
        }
    }
}
