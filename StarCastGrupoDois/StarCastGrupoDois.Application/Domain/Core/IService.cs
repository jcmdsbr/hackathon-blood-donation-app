using System;
using System.Collections.Generic;
using System.Text;

namespace StarCastGrupoDois.Application.Domain.Core
{
    public interface IService<in T>
    {
        void Salvar(T obj);
    }
}
