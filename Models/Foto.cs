namespace TP9_Nowak_Averbuch.Models
{
    public class Foto
    {
        private int _IdFoto;
        private string _Nombre;
        
        public int IdFoto{ get {return _IdFoto;} set {_IdFoto = value;}}

        public string Nombre{get {return _Nombre;} set {_Nombre = value;}}

       
        public Foto(int IdFoto, string Nombre){
            idF = _IdFoto;
            nom = _Nombre ;
        }
        public Foto(){}
    }
}   