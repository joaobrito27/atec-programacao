using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_Trabalho_4
{
    class Contacto
    {
        private int _id, _telef;
        private string _nome, _email;
        private Data _dataNasc;

        public Contacto()
        {
            _id = 0;
            _nome = "Sem Nome";
            _telef = 0;
            _email = "";
            
        }
    }
}
