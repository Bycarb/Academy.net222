namespace Academy.Common.Entities
{
    public abstract class Vehicle
    {
        public string Plate { get; set; }
        public string Model { get; set; }
        public double DailyPrice { get; set; }
        public bool IsForNewDriver { get; set; }

    }
}
