// See https://aka.ms/new-console-template for more information
using DIandIoC;
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("Hello, World!");



var serviceProvider = new ServiceCollection()
            .AddTransient<IDataStore, PostgresDataStore>() // register
            .BuildServiceProvider();

var dataStore = serviceProvider.GetRequiredService<IDataStore>();

// method DI 
var repo3 = new CustomerRepository();
repo3.Update(new Customer { Id = 1, Name = "Can" }, dataStore);


var repo4 = new UserRepository(dataStore);
repo4.Add(new User { Name = "Can" });
repo4.Delete();



