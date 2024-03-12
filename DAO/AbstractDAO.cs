using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1.DAO
{
    public interface AbstractDAO<T> where T : class
    {
        public List<T> getAll();
        public T insert(T t);
        public T upadte(T t);
        public T remove(T t);
    }
}
