namespace TP9_Nowak_Averbuch.Models
{
    public class Hotel
    {
        private int _IdHotel;
        private string _Pais;
        private string _Nombre;
        private string _Descripcion;
        private string _Imagen;

        public int IdHotel{ get {return _IdHotel;} set {_IdHotel = value;}}

        public string Pais{get {return _Pais;} set {_Pais = value;}}
        public string Nombre{get {return _Nombre;} set {_Nombre = value;}}
        public string Descripcion{get {return _Descripcion;} set {_Descripcion = value;}}
        public string Imagen{get {return _Imagen;} set {_Imagen = value;}}

       
        public Hotel(int idH, string pais, string nom){
            idH = _IdHotel;
            pais = _Pais;
            nom = _Nombre;            
        }
        public Hotel(){}
    }
}   