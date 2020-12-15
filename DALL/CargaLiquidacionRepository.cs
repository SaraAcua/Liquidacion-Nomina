using ENTITY;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL
{
    public class CargaLiquidacionRepository
    {
        private readonly SqlConnection _connection;



        public CargaLiquidacionRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }

        public CargaLiquidacionRepository()
        {
        }
        public int GuardarLiquidacion(Liquidacion liquidacion, int valorTotal)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Insert Into Liquidacion (IdSede, idempleado,nombre,HorasTrabajadas,periodo,vigencia, valor) " +
                    "Values (@Id, @idempleado,@nombre,@horas,@periodo,@vigencia,@valor)";
                //command.Parameters.Add("@Id", SqlDbType.VarChar).Value = persona.Identificacion;
                command.Parameters.AddWithValue("@Id", liquidacion.IdSede);
                command.Parameters.AddWithValue("@idempleado", liquidacion.IdEmpleado);
                command.Parameters.AddWithValue("@nombre", liquidacion.NombreEmpleado);
                command.Parameters.AddWithValue("@horas", liquidacion.horastrabajadas);
                command.Parameters.AddWithValue("@periodo", liquidacion.periodo);
                command.Parameters.AddWithValue("@vigencia", liquidacion.Vigencia);
                command.Parameters.AddWithValue("@valor", liquidacion.horastrabajadas * valorTotal);

                var filas = command.ExecuteNonQuery();
                return filas;
            }
        }
        public int BuscarPorValor()
        {
            SqlDataReader dataReader;
            int mensaje = 0;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select ValorHora from ValorHoraVigencia where id=@id";
                command.Parameters.AddWithValue("@id", "01");
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        mensaje = dataReader.GetInt32(0);
                    }
                }
                
            }
            return mensaje;
        }


        public List <Liquidacion> Buscar(string vigencia, string perido, string sede)
        {
            List<Liquidacion> liquidacions = new List<Liquidacion>();
            SqlDataReader dataReader;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select* from Liquidacion ";
               
                dataReader = command.ExecuteReader();
                dataReader.Read();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                       Liquidacion liquidacion = DataReaderMapToLiquidacion(dataReader);
                        liquidacions.Add(liquidacion);
                    }
                }
            }
            return liquidacions;
        }

        private Liquidacion DataReaderMapToLiquidacion(SqlDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Liquidacion liquidacion = new Liquidacion();
            liquidacion.IdSede = dataReader.GetString(0);
            liquidacion.IdEmpleado = dataReader.GetString(1);
            liquidacion.NombreEmpleado = dataReader.GetString(2);
            liquidacion.horastrabajadas = dataReader.GetInt32(3);
            liquidacion.periodo= dataReader.GetString(4);
            liquidacion.Vigencia = dataReader.GetString(5);
            liquidacion.Valor = dataReader.GetInt32(6);
            return liquidacion;
        }

        private Liquidacion DataReaderMap(SqlDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Liquidacion liquidacion = new Liquidacion();
            liquidacion.IdSede = (string)dataReader["Idsede"];
            liquidacion.IdEmpleado = (string)dataReader["Idempleado"];
            liquidacion.NombreEmpleado = (string)dataReader["NombreEmpleado"];
            liquidacion.horastrabajadas = (int)dataReader["HorasTrabajadas"];
            liquidacion.periodo = (string)dataReader["perido"];
            liquidacion.Vigencia = (string)dataReader["vigencia"];
            liquidacion.Valor = (int)dataReader["valor"];


            return liquidacion;
        }

        public List<Liquidacion> ConsultarTodos(string fileName)
            {
                List<Liquidacion> lista = new List<Liquidacion>();
                FileStream file = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader reader = new StreamReader(file);
                string linea = string.Empty;
                while ((linea = reader.ReadLine()) != null)
                {
                    Liquidacion liquidacion = Map(linea);
                    lista.Add(liquidacion);
                }
                reader.Close();
                file.Close();
                return lista;
            }
        private Liquidacion Map(string linea)
        {
            Liquidacion liquidacion = new Liquidacion();
            char delimeter = ';';
            string[] vectorLiquidacion = linea.Split(delimeter);
            liquidacion.IdSede = vectorLiquidacion[0];
            liquidacion.IdEmpleado = vectorLiquidacion[1];
            liquidacion.NombreEmpleado = vectorLiquidacion[2];
            liquidacion.horastrabajadas = int.Parse(vectorLiquidacion[3]);
            liquidacion.periodo = vectorLiquidacion[4];
            liquidacion.Vigencia = vectorLiquidacion[5];
            return liquidacion;
        }

    }
    }

