using Model.Generators;

namespace Model.Entity
{
    public sealed class Publisher
    {
        public string Id { get; }
        public string Name { get; }
        public string Telephone { get; }

        public Publisher(string name, string telephone)
        {
            Id = IdGenerator.Generate();
            Name = name;
            Telephone = telephone;
        }


        public override string ToString() => 
            $"Id: {Id} Name: {Name} Telephone: {Telephone} ";
    }
}