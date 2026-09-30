namespace G_NET_65_EF001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                
                bool created = context.Database.EnsureCreated();

                if (created)
                {
                    Console.WriteLine("Database created successfully");
                }
                else
                {
                    Console.WriteLine("Database already exists");
                }
            }
        }
    }
}
