using HayvanSesi.Models;

namespace HayvanSesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bird bird = new Bird() { Id = 1, Tur = "Serçe" };
            Dog dog = new Dog() { Id = 2, Tur = "Sokak köpeği" };
            Cat cat = new Cat() { Id = 3, Tur = "Siyam" };

            List<BaseVoice> hayvanlar = new List<BaseVoice>() { bird, dog, cat };

            foreach (BaseVoice hayvan in hayvanlar)
            {
                Console.WriteLine($"Id: {hayvan.Id}\nTur: {hayvan.Tur}\n==================");
                hayvan.Ses();
            }

        }
    }
}
