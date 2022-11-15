namespace ES09_PRODOTTI
{
    public class AbstractProdottiFactory
    {

        private AbstractProdottiFactory _instance = null;

        public AbstractProdottiFactory Instance
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

        public clsProdotto Create(string nome, string marca, string prezzo)
        {
            return null;
        }


    }
}
