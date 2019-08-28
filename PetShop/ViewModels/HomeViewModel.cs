using PetShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.ViewModels
{
    public class HomeViewModel
    {
        public List<Pet> Pet{ get; set; }
        public string  NomeUsuario { get; set; }
        public decimal SaldoUsuario { get; set; }

       
    }
}
