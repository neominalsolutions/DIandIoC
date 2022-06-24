using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIandIoC
{
  public class Customer
  {
    public string Name { get; set; }
    public int Id { get; set; }


  }

  // Client Class CustomerRepository
  public class CustomerRepository
  {
    // Service Class SqlDataStore (dependcy) (DIP)
    //private SqlDataStore SqlDataStore = new SqlDataStore();
    private readonly IDataStore _dataStore;
    //private readonly MySqlDataStore sqlDataStore = new MySqlDataStore();


    public CustomerRepository()
    {
      
    }

    /// <summary>
    /// Constructor Injection
    /// </summary>
    /// <param name="dataStore"></param>
    public CustomerRepository(IDataStore dataStore) // DI Dependecy Injection
    {
      //SqlDataStore.Connect("Server=Test;Database=MyTestDb;");
      _dataStore = dataStore;
      _dataStore.Connect("Server=Test;Database=MyTestDb;");
    }

    public void Add(Customer customer)
    {
      //SqlDataStore.Execute($"insert into Customers(Name) values(${customer.Name})");
      _dataStore.Execute($"insert into Customers(Name) values(${customer.Name})");
    }

    /// <summary>
    /// Method dependency Injection
    /// </summary>
    /// <param name="customer"></param>
    /// <param name="dataStore"></param>
    public void Update(Customer customer, IDataStore dataStore)
    {
      dataStore.Execute($"update Customers set Name={customer.Name} where id={customer.Id}");

    }


  }
}
