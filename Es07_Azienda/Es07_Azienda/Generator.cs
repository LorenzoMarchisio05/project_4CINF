namespace Es07_Azienda
{
    public static class IdGenerator
    {
        private static uint _val = 1;

        public static uint generate() => _val++;

        public static void error() => _val--;
    }
}
