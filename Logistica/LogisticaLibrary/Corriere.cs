namespace LogisticaLibrary
{
    public class Corriere
    {
        private readonly List<Spedizione> Spedizioni;
        public Corriere()
        {
            Spedizioni = new List<Spedizione>();
        }
        public void AddSpedizione(Spedizione spedizione)
        {
            Spedizioni.Add(spedizione);
        }
        public new string ToString()
        {
            string result = $"Elenco delle spedizioni del corriere:{Environment.NewLine}";
            foreach (var spedizione in Spedizioni)
            {
                result = $"{result} {spedizione.ToString()}{Environment.NewLine}";
            }
            return result;
        }
        //sommo semplicemente i volumi come se i pacchi fossero liquidi
        public double TotalIngombro()
        {
            double total = 0;
            foreach (Spedizione spedizione in Spedizioni)
            {
                total += spedizione.Ingombro();
            }
            return total;
        }
    }
}
