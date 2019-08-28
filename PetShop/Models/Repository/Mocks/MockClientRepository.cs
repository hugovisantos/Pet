                                                                                                                                                                                                                                                                                                            using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Models.Repository
{
    public class MockClientRepository : IClientRepository
    {
        private List<Cliente> _clientes;

        public MockClientRepository()
        {
            if(_clientes == null)
            {
                InitializeRepo();
            }
        }
        private void InitializeRepo()
        {
            _clientes = new List<Cliente>
                {
                new Cliente {Id = 1, Name = "Cliente1", Email = "asd@asd.com.br"},
                new Cliente {Id = 2, Name = "Cliente2", Email = "asd@asd.com.br"},
                new Cliente {Id = 3, Name = "Cliente3", Email = "asd@asd.com.br"}
             };
        }

        public List<Cliente> GetAllClients()
        {
            return _clientes;
        }



        public Cliente GetClientById(int clientId)
        {
            return _clientes.FirstOrDefault(c => c.Id == clientId);
        }
    }
}
