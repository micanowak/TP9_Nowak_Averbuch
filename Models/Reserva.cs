namespace TP9_Nowak_Averbuch.Models
{
    class Reserva
    {
        private int _IdReserva;
        private DateTime _fechaIN;
        private DateTime _fechaOUT;
        private int _fkHotel;
        private int _fkHabitacion;
        private string _nombre;
        private int _DNI;

        public int IdReserva{ get {return _IdReserva;} set {_IdReserva = value;}}
        public DateTime fechaIN{ get {return _fechaIN;} set {_fechaIN = value;}}
        public DateTime fechaOUT{ get {return _fechaOUT;} set {_fechaOUT = value;}}
        public int fkHotel{ get {return _fkHotel;} set {_fkHotel = value;}}
        public int fkHabitacion{ get {return _fkHabitacion;} set {_fkHabitacion = value;}}
        public string Nombre{ get {return _nombre;} set {_nombre = value;}}
        public int DNI{ get {return _DNI;} set {_DNI = value;}}

        public Reserva(int idR, DateTime fechI, DateTime fechO, int hot, int hab, string nom, int dn1){
            
            idR = _IdReserva;
            fechI = _fechaIN;
            fechO = _fechaOUT;
            hot = _fkHotel;
            hab = _fkHabitacion;
            nom = _nombre;
            dn1 = _DNI;
        }
        public Reserva(){}
    }
}