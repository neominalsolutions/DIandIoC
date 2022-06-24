using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIandIoC
{
  public enum DataStoreTypes
  {
    MySql,
    Sql,
    Posgres
  }

  public class DataStoreFactory
  {

    public static IDataStore GetDataStore(DataStoreTypes dataStoreTypes)
    {
      IDataStore dataStore = null;


      switch (dataStoreTypes)
      {
        case DataStoreTypes.MySql:
          dataStore = new MySqlDataStore();
          break;
        case DataStoreTypes.Sql:
          dataStore = new SqlDataStore();
          break;
        case DataStoreTypes.Posgres:
          dataStore = new PostgresDataStore();
          break;
      }

      return dataStore;

    }
  }


}
