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
            Reserva posibleReserva = new Reserva();
            bool seReserva = true;
            int maxReservaID;
            List<DateTime> ListaFechas = new List<DateTime>();
            string SQL = "SELECT * FROM Reserva WHERE IdReserva = @pidReserva";
            using(SqlConnection db = new SqlConnection(_ConnectionString)){
                posibleReserva = db.QueryFirstOrDefault<Reserva>(SQL, new{pidReserva = idReserva});
            }

            SQL = "SELECT TOP 1 IdReserva FROM Reserva WHERE fkHotel = @pfkHotel and fkHabitacion = @pfkhab order by IdReserva DESC";
            using(SqlConnection db = new SqlConnection(_ConnectionString)){
                maxReservaID = db.QueryFirstOrDefault<int>(SQL, new{pfkHotel = posibleReserva.fkHotel, pfkhab = posibleReserva.fkHabitacion});
            }
            
            for(int i = 1; i<= maxReservaID; i++){
                SQL = "SELECT fechaIN,fechaOUT FROM Reserva WHERE fkHotel = @pfkHotel and fkHabitacion = @pfkhab";
                using(SqlConnection db = new SqlConnection(_ConnectionString)){
                ListaFechas = db.Query<DateTime>(SQL, new{pfkHotel = posibleReserva.fkHotel, pfkhab = posibleReserva.fkHabitacion}).ToList();
            }

            List<DateTime> listaNueva = new List<DateTime>();

            for (int i2 = 0; i2 < ListaFechas.Count; i2++)
            {
                if (!(listaNueva.Contains(ListaFechas[i2])))
                {
                    listaNueva.Add(ListaFechas[i]);
                }
            }

            if(ListaFechas.Count == listaNueva.Count){

            }
                SQL = "UPDATE Jugadores SET ComodinDobleChance = 0 WHERE IdJugador = @pIdJugador";
                using(SqlConnection db = new SqlConnection(_ConnectionString)){
                db.Execute(SQL, new{pIdJugador = _Player.IdJugador});
                }
            }
        }
    }
}