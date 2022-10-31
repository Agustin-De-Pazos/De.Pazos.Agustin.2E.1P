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
        private string _pass;

        public Usuario()
        {}
        public Usuario(string gmail, string nombre, string apellido, int dni, string _pass)
        {
            this.gmail = gmail;
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this._pass = _pass;
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

        public bool VerificarPass(string pass)
        {
            bool isOkey = false;
            if(pass == this._pass)
            {
                isOkey = true;
            }
            return isOkey;
        }
        public static bool operator ==(Usuario u1, Usuario u2)
        {
            return u1.gmail == u2.gmail;
        }

        public static bool operator !=(Usuario u1, Usuario u2)
        {
            return !(u1 == u2);
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

    }
   
}