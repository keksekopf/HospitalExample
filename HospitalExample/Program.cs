namespace HospitalExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Database database = new Database();// Create a shared database
            Menu menu = new Menu(database); // Pass the shared database to the menu
        }
    }
}
