namespace ES05_giocoCarte
{
    public static class Generator
    {
        private static uint value = 0;
        public static uint generate() => value++;
    }
}
