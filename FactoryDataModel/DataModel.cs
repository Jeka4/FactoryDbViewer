using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDataModel
{
    public class DataModel
    {
        public DataModel()
        {
            using (var contex = new DbFactory())
            {
                contex.Database.CreateIfNotExists();

                var x = contex.Workers;

                foreach (var item in x)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
