using Entidades;
using System.Data.SqlClient;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Net;
using System.Reflection.PortableExecutable;
using System.Text.RegularExpressions;


namespace Datos
{
    public class DatosPersona
    {
        public DatosPersona()
        {

        }

        public List<Persona> ObtenerSocios()
        {
            List<Persona> personas = new List<Persona>();

            SqlConnection connection = Conexion.openConection();
            string query = "SELECT dni, nombre, apellido, email FROM personas where rol='user';";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Persona persona = new Persona
                        (
                            int.Parse(reader["dni"].ToString()),
                            reader["nombre"].ToString(),
                            reader["apellido"].ToString(),
                            reader["email"].ToString(),
                            "",
                            ""
                        );
                        personas.Add(persona);
                    }
                }           
            }

            Conexion.closeConnection(connection);

            return personas;
        }

        public List<Profesor> ObtenerProfesores()
        {
            List<Profesor> profesores = new List<Profesor>();

            SqlConnection connection = Conexion.openConection();
            string query = "select per.dni, per.nombre, per.apellido, per.email, per.idActividad from personas per left join actividades act on act.idActividad = per.idActividad where per.rol = 'profesor';";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        
                        Actividad act = new DatosActividades().obtenerActividadXId(int.Parse(reader["idActividad"].ToString()));
                        Profesor profesor = new Profesor
                        (
                            int.Parse(reader["dni"].ToString()),
                            reader["nombre"].ToString(),
                            reader["apellido"].ToString(),
                            reader["email"].ToString(),
                            "",
                            "",
                            act
                        );
                        profesores.Add(profesor);
                    }
                }
            }

            Conexion.closeConnection(connection);

            return profesores;
        }

        public Persona getPersona(string dni, string password)
        {
            Persona personaEncontrada = null;
           
            SqlConnection connection = Conexion.openConection();

           
            string query = "SELECT * FROM personas p WHERE p.dni=@DNI and p.password=@password";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@DNI", dni);
                command.Parameters.AddWithValue("@password", password);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    try
                    {
                        if (reader.Read())
                        {
                            string nombre = reader["nombre"].ToString();
                            string apellido = reader["apellido"].ToString();
                            int numDoc = int.Parse(reader["dni"].ToString());
                            string pass = reader["password"].ToString();
                            string mail = reader["email"].ToString();
                            string rol = reader["rol"].ToString();

                            if(rol == "profesor")
                            {
                                Actividad act = new DatosActividades().obtenerActividadXId(int.Parse(reader["idActividad"].ToString()));
                                personaEncontrada = new Profesor(numDoc, nombre, apellido, mail, pass, rol, act);
                            } else
                            {
                                personaEncontrada = new Persona(numDoc, nombre, apellido, mail, pass,rol);
                            }
                            System.Diagnostics.Debug.WriteLine(personaEncontrada.getRol());
                        }
                    }
                    catch 
                    { 
                        Conexion.closeConnection(connection);
                        System.Diagnostics.Debug.WriteLine("MAL");
                        return null;
                    }
                }
            }
            Conexion.closeConnection(connection);

            return personaEncontrada;
        }

        public Persona getPersonaByDNI(string dni)
        {
            Persona personaEncontrada = null;

            SqlConnection connection = Conexion.openConection();

            string query = "SELECT * FROM personas p WHERE p.dni=@DNI";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@DNI", dni);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    try
                    {
                        if (reader.Read())
                        {
                            string nombre = reader["nombre"].ToString();
                            string apellido = reader["apellido"].ToString();
                            int numDoc = int.Parse(reader["dni"].ToString());
                            string pass = reader["password"].ToString();
                            string mail = reader["email"].ToString();
                            string rol = reader["rol"].ToString();

                            personaEncontrada = new Persona(numDoc, nombre, apellido, mail, "", rol);
                            System.Diagnostics.Debug.WriteLine("BIEN");
                        }
                    }
                    catch
                    {
                        Conexion.closeConnection(connection);
                        System.Diagnostics.Debug.WriteLine("MAL");
                        return null;
                    }
                }
            }
            Conexion.closeConnection(connection);

            return personaEncontrada;
        }

        public int validarDuplicado(int dni)
        {
            List<Persona> personas = ObtenerSocios();
            foreach (Persona p in personas) 
            {
                if(p.getDni() == dni)
                {
                    return 2;
                }
            }
            return 0;
        }

        public int addPersona(Persona persona)
        {
            SqlConnection connection = null;
            try
            {
                if(validarDuplicado(persona.getDni()) == 2)
                {
                    return 2;
                }
                else
                {
                    connection = Conexion.openConection();

                    string query = "INSERT INTO personas VALUES (@dni, @nombre, @apellido, @mail, @password, @rol)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@dni", persona.getDni());
                        command.Parameters.AddWithValue("@nombre", persona.getNombre());
                        command.Parameters.AddWithValue("@apellido", persona.getApellido());
                        command.Parameters.AddWithValue("@mail", persona.getMail());
                        command.Parameters.AddWithValue("@password", persona.getPassword());
                        command.Parameters.AddWithValue("@rol", persona.getRol());

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected;
                    }
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
            finally
            {
                if (connection != null) 
                {
                    Conexion.closeConnection(connection);                    
                }
            }
        }

        public void updatePersona(Persona persona)
        {
            SqlConnection connection = null;
            try
            {
             
                    connection = Conexion.openConection();

                    string query = "UPDATE personas SET nombre = @nombre, apellido = @apellido, email = @mail WHERE dni = @dni;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@dni", persona.getDni());
                        command.Parameters.AddWithValue("@nombre", persona.getNombre());
                        command.Parameters.AddWithValue("@apellido", persona.getApellido());
                        command.Parameters.AddWithValue("@mail", persona.getMail());
                        

                        command.ExecuteNonQuery();
                    }
             
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                if (connection != null)
                {
                    Conexion.closeConnection(connection);
                }
            }
        }
        public  bool EsMailValido(string email)
        {
            string expresionRegular = @"^[-\w.%+]{1,64}@(?:[A-Z0-9-]{1,63}\.){1,125}[A-Z]{2,63}$";
            Regex regex = new Regex(expresionRegular, RegexOptions.IgnoreCase);

            return regex.IsMatch(email);
        }
        public void deletePersona(string dni)
        {
            using (SqlConnection connection = Conexion.openConection())
            {
                string query = "DELETE FROM personas WHERE dni = @Dni";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Dni", dni);

                    command.ExecuteNonQuery();
                }
            }
        }
        public void deletePersonaLogica(string dni)
        {
            using (SqlConnection connection = Conexion.openConection())
            {
               
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    string deleteReservasQuery = "DELETE FROM reservas WHERE dni = @Dni";
                    using (SqlCommand deleteReservasCommand = new SqlCommand(deleteReservasQuery, connection, transaction))
                    {
                        deleteReservasCommand.Parameters.AddWithValue("@Dni", dni);
                        deleteReservasCommand.ExecuteNonQuery();
                    }

                    string deletePersonaQuery = "DELETE FROM personas WHERE dni = @Dni";
                    using (SqlCommand deletePersonaCommand = new SqlCommand(deletePersonaQuery, connection, transaction))
                    {
                        deletePersonaCommand.Parameters.AddWithValue("@Dni", dni);
                        deletePersonaCommand.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception("Error al eliminar al socio: " + ex.Message);
                }
            }
        }
        public List<PersonaCuota> ObtenerSociosCuotas()
        {
            List<PersonaCuota> personas = new List<PersonaCuota>();

            SqlConnection connection = Conexion.openConection();
            string query = " SELECT p.DNI, p.Nombre, p.Apellido,p.email, COUNT(c.idCuota) as cuotasAsignadas,SUM(CASE WHEN c.pagado = 0 THEN c.monto ELSE 0 END) as montoTotal, SUM(CASE WHEN c.pagado = 0 THEN 1 ELSE 0 END) as debe FROM personas p LEFT JOIN cuotas c ON p.DNI = c.idSocio WHERE p.rol = 'user' GROUP BY p.DNI, p.Nombre, p.Apellido, p.email ;";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        PersonaCuota personaCuota = new PersonaCuota
                        (
                            int.Parse(reader["DNI"].ToString()),
                            reader["nombre"].ToString(),
                            reader["apellido"].ToString(),
                            reader["email"].ToString(),
                            int.Parse(reader["cuotasAsignadas"].ToString()),
                            int.Parse(reader["debe"].ToString()),
                            decimal.Parse(reader["montoTotal"].ToString())
                        );
                        personas.Add(personaCuota);

                    }
                }
            }

            Conexion.closeConnection(connection);

            return personas;
        }
        public int addProfesor(Profesor profesor)
        {
            SqlConnection connection = null;
            try
            {
                if (validarDuplicado(profesor.getDni()) == 2)
                {
                    return 2;
                }
                else
                {
                    connection = Conexion.openConection();

                    
                    string query = "INSERT INTO personas VALUES (@dni, @nombre, @apellido, @mail, @password, @rol, @idActividad)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@dni", profesor.getDni());
                        command.Parameters.AddWithValue("@nombre", profesor.getNombre());
                        command.Parameters.AddWithValue("@apellido", profesor.getApellido());
                        command.Parameters.AddWithValue("@mail", profesor.getMail());
                        command.Parameters.AddWithValue("@password", profesor.getPassword());
                        command.Parameters.AddWithValue("@rol", profesor.getRol());
                        command.Parameters.AddWithValue("@idActividad", profesor.getActividad().getId());

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected;
                    }
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
            finally
            {
                if (connection != null)
                {
                    Conexion.closeConnection(connection);
                }
            }
        }
    }


}