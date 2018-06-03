using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoPostBackCombo
{
    public class Equipos
    {
        public int IdEquipo { get; set; }
        public string NombreEquipo { get; set; }

        private static List<Equipos> CrearEquipos()
        {
            List<Equipos> listaEquipos = new List<Equipos>();
            Equipos e1 = new Equipos();
            e1.IdEquipo = 1;
            e1.NombreEquipo = "Rayo";
            listaEquipos.Add(e1);

            Equipos e2 = new Equipos();
            e2.IdEquipo = 2;
            e2.NombreEquipo = "Hortaleza";
            listaEquipos.Add(e2);

            return listaEquipos;
        }

        public static List<Equipos> ObtenerEquipos()
        {
            List<Equipos> lista = CrearEquipos();
            var equip = lista
                .OrderBy(e => e.NombreEquipo)
                .Select(e => e).ToList();

            Equipos vacio = new Equipos();
            vacio.IdEquipo = 0;
            vacio.NombreEquipo = string.Empty;
            lista.Insert(0, vacio);

            return lista;

        }
    }
}