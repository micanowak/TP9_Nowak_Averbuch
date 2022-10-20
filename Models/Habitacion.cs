namespace TP9_Nowak_Averbuch.Models
{
    class Habitacion
    {
        private int _IdHabitacion;
        private int _Piso;
        private int _Precio;
        private string _Nombre;
        private int _FkNivel;
        private int _FkHotel;


        public int IdHabitacion{ get {return _IdHabitacion;} set {_IdHabitacion = value;}}
        public string Nombre{get {return _Nombre;} set {_Nombre = value;}}
        public int Piso{ get {return _Piso;} set {_Piso = value;}}
        public int Precio{ get {return _Precio;} set {_Precio = value;}}
        public int FkNivel{ get {return _FkNivel;} set {_FkNivel = value;}}
        public int FkHotel{ get {return _FkHotel;} set {_FkHotel = value;}}
       
        public Habitacion(int IdHabitacion, string Nombre, int Piso, int Precio, int FkNivel, int FkHotel){
            idN = IdHabitacion;
            pis = Piso;
            pre = Precio;
            nom = Nombre ;
            fkN = FkNivel;
            fkH = FkHotel;
        }
        public Habitacion(){}
    }
}   