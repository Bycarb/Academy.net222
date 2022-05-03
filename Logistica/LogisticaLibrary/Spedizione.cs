namespace LogisticaLibrary
{
    public abstract class Spedizione
    {
        private readonly int Id;
        private readonly string Sender;
        private readonly string Receiver;
        private readonly double Value;
        public Spedizione(int id, string sender, string receiver, double value)
        {
            Id = id;
            Sender = sender;
            Receiver = receiver;
            Value = value;
        }
        public abstract double Ingombro(); 
     
        public bool Equals(Spedizione spedizione)
        {
            if (spedizione == null) throw new ArgumentNullException(nameof(spedizione));
            return spedizione.Sender.Equals(Sender)
                    && spedizione.Receiver.Equals(Receiver)
                    && spedizione.Value == Value
                    && spedizione.Id == Id;
       
        }
        public new string ToString()
        {
            return $"ID: {Id}\tSender: {Sender}\tReceiver: {Receiver}\t Value: {Value}";
        }
    }
}