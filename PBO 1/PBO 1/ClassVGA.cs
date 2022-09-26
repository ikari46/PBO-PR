namespace ClassVGA
{
    class VGA
    {
        public string merk;
    }
    class Amd : VGA
    {
        public Amd()
        {
            merk = "AMD";
        }
    }
    class Nvidia : VGA
    {
        public Nvidia()
        {
            merk = "nvidia";
        }
    }
}