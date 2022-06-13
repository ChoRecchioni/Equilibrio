using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using equilibrio.Clases;

namespace equilibrio.Controller
{
    public class DireccionController
    {
        private static List<Direccion> listaDireccion = new List<Direccion>();

        //Metodo para agregar Direccion
        public static string AddDireccion(string codigo, string alias, string calleYnum, string depto, string codcomuna, string codregion)
        {
            Comuna comuna = ComunaController.FindComuna(codcomuna);
            Region region = RegionController.FindRegion(codregion);
            try
            {
                listaDireccion.Add(new Direccion()
                {

                    Codigo = int.Parse(codigo),
                    Alias = alias,
                    CalleYnum = calleYnum,
                    Depto = depto,
                    Comuna = comuna,
                    Region = region,
                });

                return "Dirección agregada.";

            }
            catch (Exception e)
            {

                return e.Message;
            }
        }

        //Metodo para listar todas las Direcciones
        public static List<Direccion> FindAll()
        {
            return listaDireccion;
        }

        //Metodo para encontrar un objeto
        public static Direccion FindDireccion(string cod)
        {

            try
            {
                foreach (Direccion direccion in FindAll())
                {
                    if (direccion.Codigo == int.Parse(cod))
                    {
                        return direccion;
                    }
                }

                return null;
            }
            catch (Exception)
            {

                return null;
            }

        }

        //Metodo para editar direccion

        public static string EditDireccion(string codigo, string alias, string calleYnum, string depto, string codcomuna, string codregion)
        {

            try
            {
                Comuna comuna = ComunaController.FindComuna(codcomuna);
                Region region = RegionController.FindRegion(codregion);
                Direccion direccion = FindDireccion(codigo);
                direccion.Alias = alias;
                direccion.CalleYnum = calleYnum;
                direccion.Depto = depto;
                direccion.Comuna = comuna;
                direccion.Region = region;

                return "Dirección Modificada";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }


        }
        // Metodo para eliminar Dirección

        public static string RemoveDireccion(string cod)
        {


            listaDireccion.Remove(FindDireccion(cod));

            return "Dirección removida de la lista";
        }

        public static void CargarDirección()
        {
            ComunaController.CargarComuna();
            RegionController.CargarRegion();

            if (listaDireccion.Count < 1)
            {
                AddDireccion("1", "casa", "casa 1", "1", "1", "1");
                AddDireccion("2", "El Florido", "El florido 2", "2", "2", "2");
                AddDireccion("3", "Santiacentro", "Santiacentro 3", "3", "3", "3");
                AddDireccion("4", "Mar del viña", "Mar del viña 4", "4", "4", "4");
                AddDireccion("5", "Muipa", "Muipa 5", "5", "5", "5");
                AddDireccion("6", "Noobvidencia", "Noobvidencia 6", "6", "5", "5");

            }
        }

        public static int DirAI()
        {
            int cod = listaDireccion[listaDireccion.Count - 1].Codigo + 1;

            return cod;
        }


    }
}