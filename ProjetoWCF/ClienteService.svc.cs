using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ProjetoWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ClienteService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ClienteService.svc or ClienteService.svc.cs at the Solution Explorer and start debugging.
    public class ClienteService : IClienteService
    {
        private Entities _db;

        public Cliente DeleteById(int id)
        {
            using (_db = new Entities())
            {
                _db.Configuration.ProxyCreationEnabled = false;
                Cliente cliente = _db.Set<Cliente>().Find(id);
                _db.Set<Cliente>().Remove(cliente);
                _db.SaveChanges();

                return cliente;
            }
        }

        public Cliente Delete(Cliente cliente)
        {
            using (_db = new Entities())
            {
                _db.Configuration.ProxyCreationEnabled = false;
                _db.Set<Cliente>().Remove(cliente);
                _db.SaveChanges();

                return cliente;
            }
        }

        public Cliente Find(int id)
        {
            using (_db = new Entities())
            {
                _db.Configuration.ProxyCreationEnabled = false;
                Cliente cliente = _db.Clientes.Single(x => x.ClienteId == id);

                return cliente;
            }
        }

        public List<Cliente> FindAll()
        {
            using (_db = new Entities())
            {
                _db.Configuration.ProxyCreationEnabled = false;
                List<Cliente> clientes = _db.Clientes.Include("Endereco").ToList();

                return clientes;
            }
        }

        public Cliente New(Cliente cliente)
        {
            using (_db = new Entities())
            {
                _db.Configuration.ProxyCreationEnabled = false;
                _db.Clientes.Add(cliente);
                _db.SaveChanges();

                return cliente;
            }
        }

        public Cliente Update(Cliente cliente)
        {
            using (_db = new Entities())
            {
                _db.Configuration.ProxyCreationEnabled = false;
                _db.Entry(cliente).State = EntityState.Modified;
                _db.SaveChanges();

                return cliente;
            }
        }
    }
}
