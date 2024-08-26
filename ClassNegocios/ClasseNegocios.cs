using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDados;
using ClassEntidades;

namespace ClassNegocios
{
    public class ClasseNegocios
    {
        ClasseDados cldados = new ClasseDados();

        public string userform { get; set; }
        public string passform { get; set; }

        public DataTable N_login(ClasseEntidade obje)
        {
            return cldados.Dlogin(obje);
        }

        public DataTable N_login(ClasseNegocios clUser)
        {
            throw new NotImplementedException();
        }
    }
}
