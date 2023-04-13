using CSVReader;

namespace Lab9
{
    public class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Denis\Desktop\Study\2k_2h\Lab_3_h2\Lab_3_h2\CSVReder\test.csv";
            CSVReadering cSVReadering = new CSVReadering();
            cSVReadering.Reader(path);
        }

    }
}
