﻿using DIO.Series.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO.Series

{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> ListaSerie = new List<Serie>();
        public void Atualiza(int id, Serie entidade)
        {
            ListaSerie[id] = entidade;
        }

        public void Exclui(int id)
        {
            ListaSerie[id].Excluir();
        }

        public void Insere(Serie entidade)
        {
            ListaSerie.Add(entidade);
        }

        public List<Serie> Lista()
        {
            return ListaSerie;
        }

        public int ProximoId()
        {
            return ListaSerie.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return ListaSerie[id];
        }
    }
}
