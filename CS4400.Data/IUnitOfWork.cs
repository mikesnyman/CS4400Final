using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS4400.Data
{
    public interface IUnitOfWork
    {
        // Save pending changes to the data store.
        void Commit();
    }
}