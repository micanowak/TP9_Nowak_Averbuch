namespace TP9_Nowak_Averbuch.Models
{
    public class Foto
    {
        private int _IdFoto;
        private string _Nombre;
        private int _fk_Hotel;
        
        public int IdFoto{ get {return _IdFoto;} set {_IdFoto = value;}}

        public string Nombre{get {return _Nombre;} set {_Nombre = value;}}
        public int fk_Hotel{ get {return _fk_Hotel;} set {_fk_Hotel = value;}}

       
        public Foto(int idF, string nom, int fk){
           idF = _IdFoto;
           nom = _Nombre;
           fk = _fk_Hotel;
        }
        public Foto(){}
    }
}   