namespace TP9_Nowak_Averbuch.Models
{
    public class Habitacion
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
       
        public Habitacion(int idN, int piso, int pre, string nom, int fkN, int fkH){
            _IdHabitacion = idN;
            _Piso = piso;
            _Precio = pre;
            _Nombre = nom;
            _FkNivel = fkN;
            _FkHotel = fkH;
        }
        public Habitacion(){}
    }
}   