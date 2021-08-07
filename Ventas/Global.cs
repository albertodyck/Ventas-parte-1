using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaNegocios;

namespace Ventas
{
    //la primera vez que se invoque y se asigne el valor tendra vida durante la ejecucion
    public static class Global
    {
        public static int Usuarioid { get; set; }
        public static string NombreUsuario { get; set; }

        public static SeleccionBaseDeDatos.TipoBaseDeDatos TipoBaseDeDatos { get; set; }

        public static string FuenteDeDatos {get; set; }

        #region Producto
        



        #endregion
    }
}
