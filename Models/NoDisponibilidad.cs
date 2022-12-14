using System;
namespace TP9_Nowak_Averbuch.Models
{
    public class NoDisponibilidad
    {
        private int _IdNoDisponible;
        private DateTime _FechaDia;
        
        public int _FkHabitacion;
        public int IdNoDisponible{ get {return _IdNoDisponible;} set {_IdNoDisponible = value;}}

        public DateTime FechaDia{get {return _FechaDia;} set {_FechaDia = value;}}

        public int FkHabitacion{get {return _FkHabitacion;} set {_FkHabitacion = value;}}

        public NoDisponibilidad(int idND, DateTime dia, int FkHab){
            idND = _IdNoDisponible;
            dia = _FechaDia;
            FkHab = _FkHabitacion;
        }
        public NoDisponibilidad(){}
    }
}   