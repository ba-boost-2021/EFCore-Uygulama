namespace BilgeAdam.Lock
{
    internal class Program
    {
        public static void Main(string[] arg)
        {
            Console.WriteLine("Döngü için bir sayı giriniz:");
            var input = int.Parse(Console.ReadLine());

            var deneme = new Deneme(input);
            var thread = new Thread(deneme.AddAllValues);
            thread.Start();
            Console.WriteLine("Silinecek verinin indeksini veriniz:");
            var index = int.Parse(Console.ReadLine());
            deneme.RemoveAt(index);
        }
    }

    public class Deneme
    {
        private readonly object @lock = new object();
        private readonly List<string> myList = new List<string>();
        private int donguSayisi;

        public Deneme(int donguSayisi)
        {
            this.donguSayisi = donguSayisi;
        }

        public void AddAllValues()
        {
            lock (@lock)
            {
                for (int i = 0; i < donguSayisi; i++)
                {
                    myList.Add($"{i}. dögü çalışıyor");
                    Thread.Sleep(1000);
                }
                Console.WriteLine("Döngü tamamlandı");
            }
        }

        public void RemoveAt(int index)
        {
            lock (@lock)
            {
                Console.WriteLine("silme işlemi başladı");
                myList.RemoveAt(index);
            }
        }
    }
}