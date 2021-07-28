using razorHramBabynino.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace razorHramBabynino.Services
{
    public interface ICRUDPagination<Type>
    {
        List<Type> get();
        List<Type> getByTag(string Tag);
        bool canNext();
        Type itemById(int id);
        void add(Type item);        
        void update(Type item);
        void delete(Type item);
    }
}
