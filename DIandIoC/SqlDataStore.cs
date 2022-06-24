using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIandIoC
{
  public class SqlDataStore:IDataStore
  {

   public void Connect(string connectionString)
    {
      Console.WriteLine("Sql Data Store bağlanıldı");
    }

    public int Execute(string sqlCommand)
    {
      Console.WriteLine("Sql Command çalıştırıldı");
      return 1;
    }



  }
}
