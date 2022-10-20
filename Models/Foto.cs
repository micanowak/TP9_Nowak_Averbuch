namespace TP9_Nowak_Averbuch.Models
{
    class Foto
    {
        private int _IdFoto;
        private string _Nombre;
        
        public int IdFoto{ get {return _IdFoto;} set {_IdFoto = value;}}

        public string Nombre{get {return _Nombre;} set {_Nombre = value;}}

       
        public Foto(int IdFoto, string Nombre){
            idF = IdFoto;
            nom = Nombre ;
        }
        public Foto(){}
    }
}   