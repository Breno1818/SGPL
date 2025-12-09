using SGPL.Domain.Entities;
using SGPL.Repository.Context;
using System.Text.Json;


namespace SGPL.Test
{
    [TestClass]
    public sealed class RepositoryTest
    {
        [TestMethod]
        public void TestAnimal()
        {

            using (var context = new SGPLContext())
            {
                Console.WriteLine("Connected!");
                var feedVaca = new Feed(1, "Feno", 10);
                var productionVaca = new Production(1, "Leite", 5, feedVaca);
                var animal1 = new Animal(1, "Vaca", 3, true, productionVaca);
                context.Animals.Add(animal1);
                context.SaveChanges();
                Console.WriteLine("Insert done!");


            }

            using (var context = new SGPLContext())
            {
                foreach (var animal in context.Animals)
                {
                    Console.WriteLine(JsonSerializer.Serialize(animal));
                }
                Console.WriteLine("List done!");
            }
        }
    }
}
