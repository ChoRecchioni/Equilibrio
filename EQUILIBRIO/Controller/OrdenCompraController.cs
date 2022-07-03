using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using equilibrio.Clases;
using equilibrio.Controller;
namespace equilibrio.Controller
{
    public class OrdenCompraController
    {

        // Comienzo de nuevo Controller


        //instancia de las entidades de la BD
        static EQEntidades entidades = new EQEntidades();

        //Metodo para listar todos
        public static List<OrdenCompra> findAll()
        {

            var ord = from o in entidades.OrdenCompra
                      select o;

            return ord.ToList();
        }

        //Metodo para agregar
        public static string AddOrden(string codigo, string total, string codCarro, string codSede)
        {

            OrdenCompra o = new OrdenCompra()
            {
                codigo = int.Parse(codigo),
                total = total,
                fk_carro = int.Parse(codCarro),
                fk_sede = int.Parse(codSede),
            };

            entidades.OrdenCompra.Add(o);
            entidades.SaveChanges();

            return "Orden agregada.";
        }


        //Metodo para encontrar uno
        public static OrdenCompra FindOrden(int codigo)
        {

            return entidades.OrdenCompra.SingleOrDefault(r => r.codigo == codigo);
        }


        //Metodo para editar
        public static string editOrden(string codigo, string total, string codCarro, string codSede)
        {
            int intCod = int.Parse(codigo);
            //revista r = entidades.revista.Find(id);//Busca por clave primaria
            OrdenCompra o = FindOrden(intCod);

            if (o != null)
            {
                o.codigo = int.Parse(codigo);
                o.total = total;
                o.fk_carro = int.Parse(codCarro);
                o.fk_sede = int.Parse(codSede);
                entidades.SaveChanges();
                return "Orden modificada";
            }
            else
            {
                return "No se pudo modificar la Orden";
            }
        }


        //Metodo para eliminar
        public static string removeOrden(int codigo)
        {

            OrdenCompra o = FindOrden(codigo);
            entidades.OrdenCompra.Remove(o);
            entidades.SaveChanges();

            return "Orden eliminada";
        }

        // Fin nuevo Controller

        //private static List<OrdenCompra> listaOrden = new List<OrdenCompra>();

        ////Metodo para agregar Articulo
        //public static string AddOrden(string codigo, string codCarro, string total, string codLocal)
        //{
        //    CarroCompras carro = CarroComprasController.FindCarro(codCarro);
        //    Local local = LocalController.FindLocal(codLocal);
        //    try
        //    {
        //        listaOrden.Add(new OrdenCompra()
        //        {
        //            Codigo = int.Parse(codigo),
        //            Carro = carro,
        //            Total = total,
        //            Local = local

        //        });

        //        return "Orden agregada.";

        //    }
        //    catch (Exception e)
        //    {

        //        return e.Message;
        //    }
        //}

        ////Metodo para listar todas las Ordenes
        //public static List<OrdenCompra> FindAll()
        //{
        //    return listaOrden;
        //}

        ////Metodo para encontrar un objeto
        //public static OrdenCompra FindOrden(string cod)
        //{

        //    try
        //    {
        //        foreach (OrdenCompra orden in FindAll())
        //        {
        //            if (orden.Codigo == int.Parse(cod))
        //            {
        //                return orden;
        //            }
        //        }

        //        return null;
        //    }
        //    catch (Exception)
        //    {

        //        return null;
        //    }

        //}

        ////Metodo para editar Orden de compra

        //public static string EditOrden(string codigo, string codCarro, string total, string codLocal)
        //{
        //    CarroCompras carro = CarroComprasController.FindCarro(codCarro);
        //    Local local = LocalController.FindLocal(codLocal);
        //    try
        //    {
        //        OrdenCompra orden = FindOrden(codigo);
        //        orden.Carro = carro;
        //        orden.Total = total;
        //        orden.Local = local;

        //        return "Orden Modificada";
        //    }
        //    catch (Exception ex)
        //    {

        //        return ex.Message;
        //    }


        //}
        //// Metodo para eliminar Orden

        //public static string RemoveOrden(string cod)
        //{
        //    listaOrden.Remove(FindOrden(cod));

        //    return "Orden removida de la lista";
        //}

        ////Metodo para precargar Articulo
        //public static void CargarOrden()
        //{
        //    CarroComprasController.CargarCarro();
        //    LocalController.CargarLocales();

        //    if (listaOrden.Count < 1)
        //    {
        //        AddOrden("1", "1", "1.000", "1");


        //    }
        //}

        ////Metodo de auto increment
        //public static int OrdenAI()
        //{
        //    int cod = listaOrden.Count > 0 ? listaOrden[listaOrden.Count - 1].Codigo + 1 : 1;

        //    return cod;
        //}

    }
}