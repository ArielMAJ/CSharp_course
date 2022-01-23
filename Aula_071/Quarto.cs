using System;
using System.Globalization;

namespace Course
{
    public class Quarto
    {
        private string? _name;
        public string? _email { get; private set; }
        public int Numero { get; private set; }
        public bool Ocupado { get; private set; }

        public Quarto(int Numero)
        {
            this.Numero = Numero;
            Ocupado = false;
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length > 1)
                {
                    _name = value;
                    Ocupado = true;
                }
            
                    
            }
        }
        public string Email
        {
            get { return _email; }
            set
            {
                if (value.Length > 2)
                {
                    _email = value;
                }
            }
        }

        public override string ToString()
        {
            return $"{Numero}: {Name}, {Email}";
        }

    }
}