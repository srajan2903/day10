using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    public class LargeDataCollection : IDisposable
    {
        private List<object> internalData;

        public LargeDataCollection(IEnumerable<object> initialData)
        {
            internalData = new List<object>(initialData);
        }
        public void Add(object item)
        {
            internalData.Add(item);
        }
        public void Remove(object item)
        {
            internalData.Remove(item);
        }

        public object Get(int index)
        {
            return internalData[index];
        }


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {

                internalData.Clear();
                internalData = null;
            }

        }
    }
    internal class Class1
    {
    }
}
