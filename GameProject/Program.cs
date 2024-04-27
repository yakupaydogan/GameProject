using GameProject.Adapters;
using GameProject.Concrete;
using GameProject.Entities;

namespace GameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new MernisServiceAdapter());
            gamerManager.Add(new Gamer { IdentityNumber = 15661160778, FirstName = "YAKUP", LastName = "AYDOĞAN", BirthYear = 2004});
            Console.ReadLine();
        }
    }
}
