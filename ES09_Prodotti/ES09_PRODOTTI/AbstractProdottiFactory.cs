namespace ES09_PRODOTTI
{
    public class AbstractProdottiFactory
    {
        private static AbstractProdottiFactory _instance = null;

        public static AbstractProdottiFactory Instance
        {
            get
            {
                if(_instance is null)
                {
                    _instance = new AbstractProdottiFactory();
                }
                return _instance;
            }
        }

        private AbstractProdottiFactory()
        {
        }
        
        public clsAlimentare Create(string nome, string marca, string prezzo, string scadenza)
        {
            return new clsAlimentare(nome, marca, prezzo, scadenza);
        }
        
        public clsNonAlimentare Create(string nome, string marca, string prezzo, string dataAcquisto, string giorniGaranzia)
        {
            return new clsNonAlimentare(nome, marca, prezzo,dataAcquisto, giorniGaranzia);
        }
        
    }
}
