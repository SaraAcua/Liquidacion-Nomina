using DALL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CargaDatosLiquidacionService
    {
        private readonly ConnectionManager conexion;
        private readonly CargaLiquidacionRepository repositorio;
        Liquidacion liquidacion;

        CargaLiquidacionRepository carga = new CargaLiquidacionRepository();

        public CargaDatosLiquidacionService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new CargaLiquidacionRepository(conexion);
        }

        public string GuardarCargaLiquidacion(List<Liquidacion> liquidacions, int valor)
        {
            try
            {
                foreach (Liquidacion detalle in liquidacions)
                {
                    try
                    {
                        conexion.Open();
                        repositorio.GuardarLiquidacion(detalle, valor);

                        conexion.Close();

                    }
                    catch { }


                    finally
                    {
                        conexion.Close();
                    }
                }

                return $"Se guardaron los datos correctamente";

            }
            catch (Exception e)
            {
                return $"Error de la aplicacion {e.Message}";
            }

            finally { conexion.Close(); }
        }
        public Boolean ValidarCarga(List<Liquidacion> liquidacions, string vigencia, string perido, string idSede)
        {
            Boolean flag = false;
            try
            {

                foreach (Liquidacion detalle in liquidacions )
                {

                    if (liquidacion.IdSede.Equals(idSede) && liquidacion.Equals(vigencia)&&liquidacion.periodo.Equals(perido))
                    {
                        flag = true;
                    }

                }
                return flag;
            }

            catch { }
            return true;
        }






        public ConsultaCargaRespuesta ConsultaTodos(string file)
        {
            ConsultaCargaRespuesta respuesta = new ConsultaCargaRespuesta();
            try
            {
                respuesta.Liquidacions = carga.ConsultarTodos(file);
                if (respuesta.Liquidacions.Count > 0)
                {
                    respuesta.Mensaje = "Se consultan los datos";
                }
                else
                {
                    respuesta.Mensaje = "No hay Datos";
                }
                respuesta.Error = false;
                return respuesta;
                {

                }
            }
            catch (Exception e)
            {
                respuesta.Mensaje = $"Error de la aplicacion: { e.Message }";
                respuesta.Error = true;
                return respuesta;
            }
        }

    }
    public class ConsultaCargaRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public List<Liquidacion> Liquidacions { get; set; }
    }
}
      
    

