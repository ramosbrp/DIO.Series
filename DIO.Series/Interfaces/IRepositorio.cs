﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO.Series.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Lista();

        T RetornaPorId(int Id);

        void Insere(T entidade);

        void Exclui(int Id);

        void Atualiza(int Id, T entidade);

        int ProximoId();
    }
}
