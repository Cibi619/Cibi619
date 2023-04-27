using System;
using Hangfire;

class Program
{
    static void Main(string[] args)
    {
        // Configure Hangfire to use a local SQL Server database
        GlobalConfiguration.Configuration.UseSqlServerStorage("Server=(localdb)\\Local;Database=hangfiredb;Trusted_connection=True;");                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      
        // Schedule a job to run in the future
        BackgroundJob.Schedule(() => Console.WriteLine("Hello, world!"), TimeSpan.FromSeconds(10));

        // Start the Hangfire server to process jobs
        using (var server = new BackgroundJobServer())
        {
            Console.WriteLine("Hangfire server started. Press any key to exit...");
            Console.ReadKey();
        }
    }
}