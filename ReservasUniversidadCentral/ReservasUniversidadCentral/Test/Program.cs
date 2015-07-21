using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                IZonaComun aula = new Aula(0);
                IElemento tablero = new Tablero();
                IElemento silla = new Silla(30);
                aula.AdicionarElemento(tablero);
                aula.AdicionarElemento(silla);

                FactoryZonaComun FactoryZonaComun = new FactoryZonaComun();
                FactoryZonaComun.Agregar(aula);

                IZonaComun auditorio = new Auditorio(0);                
                IElemento sillasAuditorio = new Silla(40);
                auditorio.AdicionarElemento(sillasAuditorio);

                FactoryZonaComun.Agregar(auditorio);


                List<IZonaComun> zonasComunes = FactoryZonaComun.ObtenerTodas();

                Console.WriteLine("Zonas comunes disponibles:");

                foreach (IZonaComun zonacomun in zonasComunes)
                {
                    Console.WriteLine(zonacomun.ObtenerDescripcion());
                    List<IElemento> elementos = zonacomun.ObtenerElementos();
                    Console.WriteLine("Elementos que componen la zona común:");
                    foreach (IElemento elemento in elementos)
                    {
                        Console.WriteLine(elemento.ObtenerNombre());
                    }
                }

            }
            catch (Exception ex)
            {
                System.Console.Write(ex.Message);
            }
            finally
            {
                System.Console.ReadKey();
            }
            
        }
    }
}