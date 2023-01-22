using System;

namespace Model.Generators
{
    public static class IdGenerator 
    {
        public static string Generate() => Guid
            .NewGuid()
            .ToString();
    }
}