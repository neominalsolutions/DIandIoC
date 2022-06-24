using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIandIoC
{
  public class User
  {
    public string Name { get; set; }

  }

  public class UserRepository
  {
    private IDataStore _dataStore;
    //private readonly MySqlDataStore sqlDataStore = new MySqlDataStore();
    public UserRepository(IDataStore dataStore)
    {
      _dataStore = dataStore;
    }

    public void Add(User Name)
    {
      _dataStore.Execute("insert");
    }

    public void Delete()
    {

    }
  }
}
