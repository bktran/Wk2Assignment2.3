using System.IO;
using System.Threading.Channels;
namespace Wk2Assignment2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter basic details to save to file: ");
            string path = @"D:\MSSA\10975\Wk2Assignment2.3\";
            Console.WriteLine("Enter name for text file: ");
            string fileName = path + Console.ReadLine() + ".txt";
            string name;
            string age;
            string street;
            string cityStateZip;
            string address;

            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            age = Console.ReadLine();
            Console.WriteLine("Enter your house number and street: ");
            street = Console.ReadLine();
            Console.WriteLine("Enter your city, state, and zipcode");
            cityStateZip = Console.ReadLine();
            address = $"{street}" +
                $"\n{cityStateZip}";

            string allInfo = $"Name: {name}" +
                        $"\nAge: {age}" +
                        $"\nAddress:" +
                        $"\n{address.PadLeft(10)}";
         
            StreamWriter writer = null;
            try
            {
                if (!File.Exists(fileName))
                {
                    writer = File.CreateText(fileName);
                    writer.WriteLine(allInfo);
                    Console.WriteLine("File created and information appended");

                }
                else
                {
                    Console.WriteLine();
                    File.AppendAllText(fileName, allInfo);
                    Console.WriteLine("Appended information to existing File successfully");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                writer.Close();
            }

        }
    }
}
