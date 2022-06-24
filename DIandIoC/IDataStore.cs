using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIandIoC
{

  public interface IDataStore
  {
    void Connect(string ConnectionString);
    int Execute(string sqlCommand);

    void Delete();
  }
}
