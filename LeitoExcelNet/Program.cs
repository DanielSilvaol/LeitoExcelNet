using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace LeitoExcelNet
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var a = ObterLista();
        }


        public static List<Entitie> ObterLista()
        {
            List<Entitie> entities = new List<Entitie>();

            string[] arquivo = System.IO.File.ReadAllLines("../../Excel.csv");


            for (int i = 1; i < arquivo.Length; i++)
            {
                string[] colunas = arquivo[i].Split(';');
                entities.Add(new Entitie()
                {
                    Nome = colunas[0]
                });
            }
            return entities;
        }
    }

    class Entitie
    {
        public string Nome { get; set; }
    }
}