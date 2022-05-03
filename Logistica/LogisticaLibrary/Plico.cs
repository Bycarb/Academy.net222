namespace LogisticaLibrary
{
    public class Plico : Spedizione
    {
        private readonly double Height;
        private readonly double Width;
        public Plico(int id, string sender, string receiver, double value, double height, double width) : base(id, sender, receiver, value)
        {
            Height = height;
            Width = width;
        }

        public override double Ingombro() => Width * Height;

    }
}
