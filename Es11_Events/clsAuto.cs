namespace Es11_Events
{
    public sealed class clsAuto
    {
        private int numeroGiri = 500;

        public const int INCREMENTO_GIRI = 500;

        public const int MAXGIRI = 10000;

        public int NumeroGiri
        {
            get
            {
                return numeroGiri >= MAXGIRI ? MAXGIRI : numeroGiri;
            }
        } 

        public delegate void reachedLimit(string msg);
        public delegate void aggiorna();


        public void incrementa()
        {
            numeroGiri += INCREMENTO_GIRI;
        }

        public void decrementa()
        {
            numeroGiri -= INCREMENTO_GIRI;
        }
    }
}
