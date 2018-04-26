using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Interfaces
{
    public interface IProductoRepository
    {
        IEnumerable<Producto> GetAll();
        Producto Get(long id);
        Producto Add(Producto item);
        void Remove(long id);
        bool Update(Producto item);

    }
}
