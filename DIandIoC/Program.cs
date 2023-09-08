// See https://aka.ms/new-console-template for more information
using DIandIoC;
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("Hello, World!");



var serviceProvider = new ServiceCollection()
            .AddTransient<IDataStore, PostgresDataStore>() // register
            .BuildServiceProvider();



var repo3 = new CustomerRepository();
repo3.Update(new Customer { Id = 1, Name = "Can" }, serviceProvider.GetRequiredService<IDataStore>());

serviceProvider.GetRequiredService<IDataStore>();

var repo4 = new UserRepository(serviceProvider.GetRequiredService<IDataStore>());
repo4.Add(new User { Name = "Can" });
repo4.Delete();



