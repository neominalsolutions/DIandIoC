// See https://aka.ms/new-console-template for more information
using DIandIoC;
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("Hello, World!");



// Yarın yada başka bir gün ben bu projede MsSqlServer yerine aslında PostgresSql veya MySql geçebilirim.

/// <summary>
/// Consturctor injection
/// </summary>
//var repo = new CustomerRepository(DataStoreFactory.GetDataStore(DataStoreTypes.Sql));
//var repo1 = new CustomerRepository(DataStoreFactory.GetDataStore(DataStoreTypes.MySql));
//var repo2 = new CustomerRepository(new MySqlDataStore());
//var repo3 = new CustomerRepository();


// ServiceCollection NetCore IOC Container içindeki servisleri register etmek için kullanılan bir kolleksiyon ilen Bu kolleksiyona BuildServiceProvider() methodu eklenince Microsoft Container'ı olan ServiceProvider instance oluşur. ServiceProvider IoC Container görevi görür.
var serviceProvider = new ServiceCollection()
            .AddTransient<IDataStore, PostgresDataStore>() // register
            .BuildServiceProvider();


/// <summary>
/// Method Injection
/// serviceProvider.GetRequiredService<IDataStore>() bana resolve et
/// </summary>

var repo3 = new CustomerRepository();
repo3.Update(new Customer { Id = 1, Name = "Can" }, serviceProvider.GetRequiredService<IDataStore>());

serviceProvider.GetRequiredService<IDataStore>();

var repo4 = new UserRepository(serviceProvider.GetRequiredService<IDataStore>());
repo4.Add(new User { Name = "Can" });
repo4.Delete();



//repo3.Add(new Customer { Name = "Ali" });
