namespace TP9_Nowak_Averbuch.Models
{
    public class Hotel
    {
        private int _IdHotel;
        private string _Pais;
        
        private string _Nombre;

        public int IdHotel{ get {return _IdHotel;} set {_IdHotel = value;}}

        public string Pais{get {return _Pais;} set {_Pais = value;}}
        public string Nombre{get {return _Nombre;} set {_Nombre = value;}}

       
        public Hotel(int idH, string pais, string nom){
            _IdHotel = idH;
            _Pais = pais ;
            _Nombre = nom;            
        }
        public Hotel(){}
    }
}   