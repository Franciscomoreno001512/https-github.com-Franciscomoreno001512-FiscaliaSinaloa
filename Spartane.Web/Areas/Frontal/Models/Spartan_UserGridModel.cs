using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Spartan_UserGridModel
    {
        public int Id_User { get; set; }
        public string Name { get; set; }
        public int? Role { get; set; }
        public string RoleDescription { get; set; }
        public int? Image { get; set; } //FileInfo
        public string Email { get; set; }
        public int? Status { get; set; }
        public string StatusDescription { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }


        //fjmore
        public string Cargo { get; set; }
        public int? Unidad { get; set; }
        public string UnidadDescription { get; set; }

        public int? Region { get; set; }
        public string RegionDescription { get; set; }

    }
}

