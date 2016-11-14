using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Data;
using System.Security.Cryptography;
using System.IO;
using System.Drawing;

namespace Proyecto
{
    public class Operaciones
    {
        protected User AuthUser;

        public Operaciones(User AuthUser)
        {
            this.AuthUser = AuthUser;
        }
        public bool AgregarUsuario(string Name, string Username, string Gender, string Password, int Role)
        {
            if (AuthUser.Role.Name == "Admin")
            {
                using (var conexion = new ILC())
                {
                    User nuevoUsuario = new User();
                    nuevoUsuario.Name = Name;
                    nuevoUsuario.Username = Username;
                    nuevoUsuario.Gender = Gender;
                    nuevoUsuario.RoleId = Role;
                    nuevoUsuario.Password = CalculateMD5Hash(Password);
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
                    conexion.Users.Find(AuthUser.Id).Password = CalculateMD5Hash(Password);
                    if (conexion.SaveChanges() == 1)
                        return true;
                }
            }
            return false;
        }

        public static string CalculateMD5Hash(string input)
        {
            // step 1, calculate MD5 hash from input
            MD5 md5 = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);
            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }

        public static Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        public bool AgregarTravelProblem(string name, int peso)
        {
            if (AuthUser.Role.Name == "Admin" && peso != 0)
            {
                using (var conexion = new ILC())
                {
                    TravelProblem nuevoTravelProblem = new TravelProblem();
                    nuevoTravelProblem.Name = name;
                    nuevoTravelProblem.Peso = peso;
                    conexion.TravelProblems.Add(nuevoTravelProblem);
                    if (conexion.SaveChanges() == 1)
                        return true;
                }
            }
            return false;
        }

        public bool AgregarRole(string role)
        {
            if (AuthUser.Role.Name == "Admin")
            {
                using (var conexion = new ILC())
                {
                    Role rol = new Role();
                    rol.Name = role;
                    conexion.Roles.Add(rol);
                    if (conexion.SaveChanges() == 1)
                        return true;
                }
            }
            return false;
        }
    }
}
