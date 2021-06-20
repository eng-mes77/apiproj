using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.IServices
{
    public interface IRepositoryManager
    {
        IPersonRepository person { get; }
        void save();
    }
}
