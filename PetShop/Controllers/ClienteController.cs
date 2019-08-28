using Microsoft.AspNetCore.Mvc;
using PetShop.Models;
using PetShop.Models.Repository;
using PetShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Controllers
{
    public class ClienteController : Controller
    {
        private MockClientRepository mockClientRepository; //baixo acoplamento

        private ClienteViewModel _clienteViewModel; //baixo acoplamento

        //MockClientRepository repo = new MockClientRepository();

        public IActionResult Listar()
        {
            _clienteViewModel.Clientes = mockClientRepository.GetAllClients(); //baixo acoplamento
            _clienteViewModel.Dolar = 3.99m; //baixo acoplamento


            //var clienteViewModel = new ClienteViewModel
            //{
            //    Clientes = repo.GetAllClients(),
            //    Dolar = 3.99m
            //};

            return View(_clienteViewModel);
        }
        public IActionResult Detalhe(int id)
        {
            var _clientes = mockClientRepository.GetClientById(id); //baixo acoplamento

            //var clientes = repo.GetClientById(id);

            return View(_clientes);
        }

    }
}
