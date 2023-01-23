using System.Collections.Generic;
using Model.Generators;

namespace Model.Entity
{
    public sealed class Publisher
    {
        public string IdCe { get; set; }
        public string Nome { get; set; }
        public string Telefono { get; set; }

        public Publisher()
        {
        }


        public override string ToString() => 
            $"Id: {IdCe} Name: {Nome} Telephone: {Telefono} ";
    }
}