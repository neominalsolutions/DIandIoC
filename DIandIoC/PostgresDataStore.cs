using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIandIoC
{
 

  public class PostgresDataStore:IDataStore
  {
    public void Connect(string connectionString)
    {
      Console.WriteLine("Postgres Data Store bağlanıldı");
    }

    public int Execute(string sqlCommand)
    {
      Console.WriteLine("Postgres Command çalıştırıldı");
      return 1;
    }

    public void Delete()
    {
      Console.WriteLine("Delete işlemi");
    }

    public void Test()
    {
      throw new NotImplementedException();
    }
  }
}
