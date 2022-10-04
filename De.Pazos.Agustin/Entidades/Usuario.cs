using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public abstract class Usuario
    {
        private string gmail;
        private string nombre;
        private string apellido;
        private int dni;
        private EPermisos permisos;

        public Usuario()
        {}
        public Usuario(string gmail, string nombre, string apellido, int dni)
        {
            this.gmail = gmail;
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }
        
        public abstract EPermisos Permisos { get; }
        
        public string Gmail
        {
            get
            {
                return this.gmail;
            }
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Dni { get => dni; set => dni = value; }

        public static bool VerificarGmail(List<Usuario> u, string texto)
        {
            bool todOk = true;
            foreach (Usuario item in u)
            {
                if (item.Gmail == texto)
                {
                    todOk = false;
                }
            }
            return todOk;
        }
        public static bool VerificarDni(List<Usuario> u, string texto)
        {
            bool todOk = true;
            int aux;
            
            if (int.TryParse(texto,out aux))
            {
                foreach (Usuario item in u)
                {
                    if (item.Dni == aux)
                    {
                        todOk = false;
                    }
                }
            }
            return todOk;
        }
       
        public static bool operator ==(Usuario u1, Usuario u2)
        {
            return u1.gmail == u2.gmail;
        }

        public static bool operator !=(Usuario u1, Usuario u2)
        {
            return !(u1 == u2);
        }

        public virtual string Mostrar()
        {
            return (string)this;
        }

        public static bool operator +(List<Usuario> u, Usuario a)
        {
            bool ok = false;
            if (!(u == a))
            {
                u.Add(a);
                ok = true;
            }
            return ok;
        }

        public static bool operator ==(List<Usuario> u, Usuario a)
        {
            bool ok = false; 
            foreach (Usuario item in u)
            {
                if (item == a)
                {
                    ok = true;
                }
            }
            return ok;
        }

        public static bool operator !=(List<Usuario> u, Usuario a)
        {
            return !(u == a);
        }

        public static explicit operator string(Usuario u)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Gmail: {u.gmail}");
            sb.AppendLine($"Nombre: {u.nombre}");
            sb.AppendLine($"Apellido: {u.apellido}");
            sb.AppendLine($"Apellido: {u.dni}");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }


    }
   
}