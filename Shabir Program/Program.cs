// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.DependencyInjection;
using Shabir_Program;
public class Program
{
    static void Main(string[] args)
    {
        var services = new ServiceCollection();
        ConfigureServices(services);
        var txt = services
            .AddSingleton<MainClass, MainClass>()
            .BuildServiceProvider()
            .GetService<MainClass>()
            .GetSchoolNames();
        Console.WriteLine(txt);
        var AllList = services
            .AddSingleton<MainClass, MainClass>()
            .BuildServiceProvider()
            .GetService<MainClass>()
            .GetAllLists();
        foreach (var item in AllList)
        {
            Console.WriteLine(item.Name);
        }
        var txt1 = services
           .AddSingleton<MainClass, MainClass>()
           .BuildServiceProvider()
           .GetService<MainClass>()
           .GetNameByBook();
        Console.WriteLine(txt1);
    }
    private static void ConfigureServices(IServiceCollection services)
    {
        services.AddScoped<ISchoolRepository, SchoolRepository>();
        services.AddTransient<IAuthor, Author>();



    }
}