using System;
using System.Data.SqlClient;
using Dapper;
using System.Collections.Generic;

namespace TP9_Nowak_Averbuch.Models
{
    class BD
    {
        private static string _ConnectionString = @"Server=A-PHZ2-CIDI-024;DataBase=scriptTP9;Trusted_Connection=True;";

        public static int ReservarHabitacion(DateTime fechaIN1, DateTime fechaOut1, int fkHotel1, int fkHabi1, string Nombre1, int dni1){
            int id;
            string SQL = "INSERT INTO Reserva(fechaIN, fechaOUT, fkHotel, fkHabitacion, nombre, DNI, estadoComprobante) VALUES (@pfechaIN, @pfechaOUT, @pfkHotel, @pfkHabitacion, @pnombre, @pDNI, @pEstado)";
            using(SqlConnection db = new SqlConnection(_ConnectionString)){
                db.Execute(SQL, new{pfechaIN = fechaIN1, pfechaOUT = fechaOut1, pfkHotel = fkHotel1, pfkHabitacion = fkHabi1, pnombre = Nombre1, pDNI = dni1, pEstado = 0});
            }
            SQL = "SELECT IdReserva from Reserva WHERE fechaIN = @pfechaIN AND fechaOUT = @pfechaOUT AND fkHotel = @pfkHotel AND fkHabitacion = @pfkHabitacion AND Nombre = @pnombre AND DNI = @pDNI AND estadoComprobante = @pEstado";
            using(SqlConnection db = new SqlConnection(_ConnectionString)){
                id = db.QueryFirstOrDefault<int>(SQL, new{pfechaIN = fechaIN1, pfechaOUT = fechaOut1, pfkHotel = fkHotel1, pfkHabitacion = fkHabi1, pnombre = Nombre1, pDNI = dni1, pEstado = 0});
            }
            
            return id;
        }

        public static Habitacion VerHabitaciones(int IdHabitacion)
        {
            Habitacion _Habitaciones = new Habitacion();
            string sql = "SELECT * FROM Habitacion WHERE IdHabitacion = @nivel";
            using(SqlConnection db = new SqlConnection(_ConnectionString)){
                _Habitaciones = db.QueryFirstOrDefault<Habitacion>(sql,new{nivel = IdHabitacion});
            }
            return _Habitaciones;
        }

        public static Reserva BuscarReserva(int idReserva){
            Reserva dev = new Reserva();
            string SQL = "SELECT * FROM Reserva WHERE IdReserva = @PidReserva";
            using(SqlConnection db = new SqlConnection(_ConnectionString)){
                dev = db.QueryFirstOrDefault<Reserva>(SQL, new{PidReserva = idReserva});
            }
            return dev;
        }

public static void Modificar(Reserva res){
            int id;
            string SQL = "SELECT IdReserva from Reserva WHERE IdReserva = @pId";
            using(SqlConnection db = new SqlConnection(_ConnectionString)){
                id = db.QueryFirstOrDefault<int>(SQL, new{pId = res.IdReserva});
            }
            SQL = "UPDATE Reserva SET FechaIN = @pfechaIN, fechaOUT = @pfechaOUT, fkHotel = @pfkHo, fkHabitacion = @pfkHabi, nombre = @pNom, DNI = @pdni, estadoComprobante = @pEstado, comprobante = @pComp WHERE IdReserva = @pID";
                using(SqlConnection db = new SqlConnection(_ConnectionString)){
                db.Execute(SQL, new{pfechaIN = res.fechaIN, pfechaOUT = res.fechaOUT, pfkHo = res.fkHotel, pfkHabi = res.fkHabitacion, pNom = res.Nombre, pdni = res.DNI, pEstado = res.EstadoComprobante, pComp = res.Comprobante, pID = res.IdReserva});
                }
        }    }
}