using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Helper.Models
{
    public class AuthModels
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public int Perfil { get; set; }
        public bool Autenticado { get; set; }
    }
}