using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Data;

namespace Proyecto
{
    public class Operaciones
    {
        private User nuevoUsuario;
        public bool AgregarUsuario(string Name, string Email, string Gender, string Password, int Role)
        {
            using (var conexion = new ILC())
            {
                this.nuevoUsuario = new User();
                nuevoUsuario.Name = Name;
                nuevoUsuario.Email = Email;
                nuevoUsuario.Gender = Gender;
                nuevoUsuario.RoleId = Role;
                nuevoUsuario.Password = Password;
                conexion.Users.Add(nuevoUsuario);
                if (conexion.SaveChanges() == 1)
                    return true;
                else
                    return false;
            }
        }
    }
}
