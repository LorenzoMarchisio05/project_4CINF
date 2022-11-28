namespace Es11_Events
{
    public sealed class clsAuto
    {
        private int numeroGiri = 500;

        public const int INCREMENTO_GIRI = 500;

        public const int MAXGIRI = 6000;

        public const int MINGIRI = 500;

        public const int NumeroMarce = 6;

        public const int RANGE = MAXGIRI / NumeroMarce;

        public int NumeroGiri 
        {
            get
            {
                int giri = numeroGiri;

                if(giri >= MAXGIRI)
                {
                    giri = MAXGIRI;
                }
                else if(giri <= MINGIRI)
                {
                    giri = MINGIRI;
                }

                return giri;
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
