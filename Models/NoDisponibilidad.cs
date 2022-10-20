namespace TP9_Nowak_Averbuch.Models
{
    class NoDisponibilidad
    {
        private int _IdNoDisponible;
        private string _FechaDia;
        
        public int _FkHabitacion;
        public int IdNoDisponible{ get {return _IdNoDisponible;} set {_IdNoDisponible = value;}}

        public string FechaDia{get {return _FechaDia;} set {_FechaDia = value;}}

        public string FkHabitacion{get {return _FkHabitacion;} set {_FkHabitacion = value;}}

        public NoDisponibilidad(int IdNoDisponible, DateTime FechaDia, int FkHabitacion){
            idND = IdNoDisponible;
            dia =FechaDia;
            FkHab = FkHabitacion;
        }
        public NoDisponibilidad(){}
    }
}   