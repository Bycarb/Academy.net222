namespace LogisticaLibrary
{
    public abstract class Spedizione
    {
        private int Id;
        private string Sender;
        private string Receiver;
        public double Value { get; private set; }
        public Spedizione(int id, string sender, string receiver, double value)
        {
            Id = id;
            Sender = sender;
            Receiver = receiver;
            Value = value;
        }
        public abstract double Ingombro(); // non printa, restituisce solo il valore
     
        public bool Equals(Spedizione spedizione)
        {
            if(spedizione == null) return false;
            if(spedizione.Sender.Equals(Sender)
                    && spedizione.Receiver.Equals(Receiver)
                    && spedizione.Value == Value
                    && spedizione.Id == Id) //pasterebbe l'id ma per essere sicuri sicuri
                return true;
            else return false;
        }
        public string ToString()
        {
            return $"ID: {Id}\tSender: {Sender}\tReceiver: {Receiver}\t Value: {Value}";
        }
    }
}