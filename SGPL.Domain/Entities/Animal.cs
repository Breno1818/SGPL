using SGPL.Domain.Base;

namespace SGPL.Domain.Entities
{
    public class Animal : BaseEntity<int>
    {
        public Animal() : base(0)
        {
        }
        public Animal(int id, string name, int age, bool producer, Production production) : base(id) 
        {
            Name = name;
            Age = age;
            Producer = producer;
            Production = production;

        }
        public string Name { get; set; }
        public int Age { get; set; }
        public bool Producer { get; set; }
        public Production Production { get; set; }
    }
}
