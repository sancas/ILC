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
        protected User AuthUser;
        private User nuevoUsuario;

        public Operaciones(User AuthUser)
        {
            this.AuthUser = AuthUser;
        }
        public bool AgregarUsuario(string Name, string Email, string Gender, string Password, int Role)
        {
            if (AuthUser.Role.Name == "Admin")
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
                }
            }
            return false;
        }

        public bool UpdatePassword(string Password)
        {
            if (AuthUser != null)
            {
                using (var conexion = new ILC())
                {
                    conexion.Users.Find(AuthUser.Id).Password = Password;
                    if (conexion.SaveChanges() == 1)
                        return true;
                }
            }
            return false;
        }
    }
}
