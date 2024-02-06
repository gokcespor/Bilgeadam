namespace asker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yas;
            Console.WriteLine("Lütfen yaşınızı giriniz: ");
            yas = Convert.ToInt32(Console.ReadLine());
            if (yas >= 20)
            {
                Console.WriteLine("Askere gidebilir.");
            }
            else
            {
                Console.WriteLine("Askere gidemez.");
            }
        }
    }
}
