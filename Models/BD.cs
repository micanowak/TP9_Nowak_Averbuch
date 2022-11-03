using System;
using System.Data.SqlClient;
using Dapper;
using System.Collections.Generic;

namespace TP9_Nowak_Averbuch.Models
{
    class BD
    {
        private static string _ConnectionString = @"Server=A-PHZ2-CIDI-024;DataBase=scriptTP9;Trusted_Connection=True;";

        public static int ReservarHabitacion(DateTime fechaIN, DateTime fechaOut, int fkHotel, int fkHabi, string Nombre, int dni){
            int id;
            string SQL = "INSERT INTO Reserva(fechaIN, fechaOUT, fkHotel, fkHabitacion, nombre, DNI, estadoComprobante) VALUES (@pfechaIN, @pfechaOUT, @pfkHotel, @pfkHabitacion, @pnombre, @pDNI, @pEstado)";
            using(SqlConnection db = new SqlConnection(_ConnectionString)){
                db.Execute(SQL, new{pfechaIN = fechaIN, pfechaOUT = fechaOut, pfkHotel = fkHotel, pfkHabitacion = fkHabi, pnombre = Nombre, pDNI = dni, pEstado = 0});
            }
            SQL = "SELECT IdReserva from Reserva WHERE fechaIN = @pfechaIN AND fechaOUT = @pfechaOUT AND fkHotel = @pfkHotel AND fkHabitacion = @pfkHabitacion AND Nombre = @pnombre AND DNI = @pDNI AND estadoComprobante = @pEstado";
            using(SqlConnection db = new SqlConnection(_ConnectionString)){
                id = db.QueryFirstOrDefault<int>(SQL, new{pfechaIN = fechaIN, pfechaOUT = fechaOut, pfkHotel = fkHotel, pfkHabitacion = fkHabi, pnombre = Nombre, pDNI = dni, pEstado = 0});
            }
            
            return id;
        }

        public static Reserva BuscarReserva(int idReserva){
            Reserva dev = new Reserva();
            string SQL = "SELECT * FROM Reserva WHERE IdReserva = @PidReserva";
            using(SqlConnection db = new SqlConnection(_ConnectionString)){
                dev = db.QueryFirstOrDefault<Reserva>(SQL, new{PidReserva = idReserva});
            }
            return dev;
        }

        public static void ModificarFechaIN(DateTime fecha, int id){
            string SQL = "UPDATE Reserva SET FechaIN = @pFecha WHERE IdReserva = @pID";
                using(SqlConnection db = new SqlConnection(_ConnectionString)){
                db.Execute(SQL, new{pFecha = fecha, pID = id});
                }
        }

        public static void ModificarFechaOUT(DateTime fecha, int id){
            string SQL = "UPDATE Reserva SET FechaOUT = @pFecha WHERE IdReserva = @pID";
                using(SqlConnection db = new SqlConnection(_ConnectionString)){
                db.Execute(SQL, new{pFecha = fecha, pID = id});
                }
        }

        public static void ModificarHotel(int fkHot, int id){
            string SQL = "UPDATE Reserva SET fkHotel = @pfkHot WHERE IdReserva = @pID";
                using(SqlConnection db = new SqlConnection(_ConnectionString)){
                db.Execute(SQL, new{pfkHot = fkHot, pID = id});
                }
        }

        public static void ModificarHabitacion(int fkHab, int id){
            string SQL = "UPDATE Reserva SET fkHabitacion = @pfkHab WHERE IdReserva = @pID";
                using(SqlConnection db = new SqlConnection(_ConnectionString)){
                db.Execute(SQL, new{pfkHab = fkHab, pID = id});
                }
        }

        public static void EliminarReserva(int idReserva){
            string SQL = "DELETE FROM Reserva WHERE IdReserva = @pID";
                using(SqlConnection db = new SqlConnection(_ConnectionString)){
                db.Execute(SQL, new{pID = idReserva});
                }
        }
        public static Habitacion VerHabitaciones(int IdHab)
        {
            Habitacion _Habitaciones = new Habitacion();
            string sql = "SELECT * FROM Habitacion WHERE IdHab = @nivel";
            using(SqlConnection db = new SqlConnection(_ConnectionString)){
                _Habitaciones = db.QueryFirstOrDefault<Habitacion>(sql,new{nivel = IdHab});
            }
            return _Habitaciones;
        }
        public static void IngresarComprobante(int id, string comp){
            string SQL = "UPDATE Reserva SET estadoComprobante = @pEstado WHERE IdReserva = @pID";
                using(SqlConnection db = new SqlConnection(_ConnectionString)){
                db.Execute(SQL, new{pEstado = 1, pID = id});
                }
            SQL = "UPDATE Reserva SET comprobante = @pComp WHERE IdReserva = @pID";
                using(SqlConnection db = new SqlConnection(_ConnectionString)){
                db.Execute(SQL, new{pComp = comp, pID = id});
                }
        }
    }
}