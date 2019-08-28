using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Models.Repository
{
    public interface IClientRepository
    {
        List<Cliente> GetAllClients();
        Cliente GetClientById(int clientId);

    }
}
