using EjemploCliente.DAL;
using EjemploCliente.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjemploCliente.BLL
{
    public class ClientesBLL
    {
        public static bool Guardar(Clientes cliente)
        {
            bool retorno = false;
            using (var db = new EjemploDb())
            {
                try
                {
                    db.Cliente.Add(cliente);
                    db.SaveChanges();
                    retorno = true;
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return retorno;
        }
    }
}