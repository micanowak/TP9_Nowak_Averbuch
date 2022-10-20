namespace TP9_Nowak_Averbuch.Models
{
    public class Foto
    {
        private int _IdFoto;
        private string _Nombre;
        
        public int IdFoto{ get {return _IdFoto;} set {_IdFoto = value;}}

        public string Nombre{get {return _Nombre;} set {_Nombre = value;}}

       
        public Foto(int idF, string nom){
           _IdFoto = idF;
            _Nombre = nom ;
        }
        public Foto(){}
    }
}   