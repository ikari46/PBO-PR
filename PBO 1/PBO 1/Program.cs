using ClassProcessor;
using ClassVGA;

namespace PBO1
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop1 = new Vivobook();
            laptop1.processor = new Corei5();
            laptop1.vga = new Nvidia();                       
            Laptop laptop2 = new IdeaPad();
            laptop2.processor = new Ryzen();
            laptop2.vga = new Amd();                       
            Predator predator = new Predator();
            predator.processor = new Corei7();
            predator.vga = new Amd();

            //Jawaban Soal Nomor 1
            //laptop2.LaptopDinyalakan();
            //laptop2.LaptopDimatikan();

            //Soal Nomor 2
            //laptop1.Ngoding();

            //Soal Nomor 3
            //Console.WriteLine(laptop1.processor.merk);
            //Console.WriteLine(laptop1.processor.tipe);
            //Console.WriteLine(laptop1.vga.merk);

            //Soal Nomor 4
            //predator.BermainGame();

            //Soal Nomor 5
            //Acer acer = new Predator();
            //acer.BermainGame():
        }
    }
}
