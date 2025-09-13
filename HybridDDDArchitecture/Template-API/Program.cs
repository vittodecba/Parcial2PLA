namespace API
{
    public class Program
    {
        protected Program()
        {
        }
        // cometando a ver si anda
        //purba 1 
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }
        public static IHostBuilder CreateHostBuilder(string[] args) => Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(config => { config.UseStartup<Startup>(); });
    }
}