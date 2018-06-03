using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoPostBackCombo
{
    public class Contact
    {
        public int IdEmployee { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string State { get; set; }

        public Contact() //esto es un constructor
        {

        }

        private static List<Contact> CrearLista()
        {
            List<Contact> contactos = new List<Contact>();

            Contact c1 = new Contact();
            c1.IdEmployee = 1;
            c1.FirstName = "Juan";
            c1.LastName = "Belmonte";
            c1.Email = "jb@gmail.com";
            c1.Phone = "(97)1243.23.23";
            c1.DateOfBirth = Convert.ToDateTime("12/07/1990");
            c1.State = "Alabama";
            contactos.Add(c1);

            Contact c2 = new Contact();
            c2.IdEmployee = 2;
            c2.FirstName = "José";
            c2.LastName = "Escribano";
            c2.Email = "jes@gmail.com";
            c2.Phone = "(97)1243.23.23";
            c2.DateOfBirth = Convert.ToDateTime("12/09/1991");
            c2.State = "Texas";
            contactos.Add(c2);

            Contact c3 = new Contact();
            c3.IdEmployee = 3;
            c3.FirstName = "María";
            c3.LastName = "Guzmán";
            c3.Email = "mg@gmail.com";
            c3.Phone = "(97)1243.23.23";
            c3.DateOfBirth = Convert.ToDateTime("19/12/1995");
            c3.State = "New Mexico";
            contactos.Add(c3);

            return contactos;

        }

        public static List<Contact> ObtenerContactos()
        {
            List<Contact> contactos = CrearLista();
            var contact = contactos
                .OrderBy(c => c.LastName)
                .Select(c => c).ToList();

            Contact vacio = new Contact();
            vacio.IdEmployee = 0;
            vacio.FirstName = string.Empty;
            vacio.LastName = string.Empty;

            contactos.Insert(0, vacio);

            return contactos;

        }

    }
}
//El ToList<TSource>(IEnumerable<TSource>) método exige la evaluación
//    inmediata de la consulta y devuelve un List<T> que contiene los 
//        resultados de la consulta.Puede anexar este método a su consulta 
//        para obtener una copia en caché de resultados de la consulta.