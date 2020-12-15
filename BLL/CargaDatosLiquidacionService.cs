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
        Liquidacion liquidacion = new Liquidacion();

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
                    catch(Exception e){ }


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
            Boolean flag = true;
            try
            {

                foreach (Liquidacion detalle in liquidacions )
                {

                    if (!detalle.IdSede.Equals(idSede) || !detalle.Vigencia.Equals(vigencia) ||!detalle.periodo.Equals(perido))
                    {
                        flag = false;
                    }

                }
                return flag;
            }

            catch { }
            return false;
        }

        public int ConsultarValor()
        {
            int mensaje = 0;
            try
            {
            
                conexion.Open();
                mensaje = repositorio.BuscarPorValor();
                conexion.Close();
                    }
            catch
            {

            }
            finally { conexion.Close(); }
            return mensaje;
        }

        public ConsultaCargaRespuesta Buscar(string vigencia, string perido, string sede)
        {
            ConsultaCargaRespuesta respuesta = new ConsultaCargaRespuesta();
            try
            {

                conexion.Open();
                respuesta.Liquidacions = repositorio.Buscar(vigencia, perido,sede);
                conexion.Close();
                respuesta.Mensaje = (respuesta.Liquidacions != null) ? "Se encontró la Persona buscada" : "La persona buscada no existe";
                respuesta.Error = false;
                return respuesta;
            }
            catch (Exception e)
            {

                respuesta.Mensaje = $"Error de la Aplicacion: {e.Message}";
                respuesta.Error = true;
                return respuesta;
            }
            finally { conexion.Close(); }
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
      
    

