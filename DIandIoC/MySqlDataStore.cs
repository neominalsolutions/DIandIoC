using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIandIoC
{
  public class MySqlDataStore:IDataStore
  {
    public void Connect(string connectionString)
    {
      Console.WriteLine("MySql Data Store bağlanıldı");
    }

    public int Execute(string sqlCommand)
    {
      Console.WriteLine("MySql Command çalıştırıldı");
      return 1;
    }
  }
}
