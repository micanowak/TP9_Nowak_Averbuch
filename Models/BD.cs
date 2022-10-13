using System;
using System.Data.SqlClient;
using Dapper;
using System.Collections.Generic;

namespace TP9_Nowak_Averbuch.Models
{
    class BD
    {
        private static string _ConnectionString = @"Server=A-PHZ2-CIDI-052;DataBase=JuegoQQSM;Trusted_Connection=True;";

        public static void ReservarTurno(DateTime fechaIN, DateTime fechaOut, int fkHotel, int fkHabi, string Nombre, int dni){
            string SQL = "INSERT INTO Reserva(fechaIN, fechaOUT, fkHotel, fkHabitacion, nombre, DNI) VALUES (@pfechaIN, @pfechaOUT, @pfkHotel, @pfkHabitacion, @pnombre, @pDNI)";
            using(SqlConnection db = new SqlConnection(_ConnectionString)){
                db.Execute(SQL, new{pfechaIN = fechaIN, pfechaOUT = fechaOut, pfkHotel = fkHotel, pfkHabitacion = fkHabi, pnombre = Nombre, pDNI = dni});
            }
        }

        public static void Disponibilidad(int idReserva){
            bool seReserva = true;
            string SQL = "SELECT * FROM Reserva WHERE IdPregunta = @pidReserva";
            using(SqlConnection db = new SqlConnection(_ConnectionString)){
                posibleReserva = db.QueryFirstOrDefault<Reserva>(SQL, new{pidReserva = idReserva});
            }
            
            string SQL = "UPDATE Jugadores SET ComodinDobleChance = 0 WHERE IdJugador = @pIdJugador";
                using(SqlConnection db = new SqlConnection(_ConnectionString)){
                db.Execute(SQL, new{pIdJugador = _Player.IdJugador});
                }
        }
    }
}