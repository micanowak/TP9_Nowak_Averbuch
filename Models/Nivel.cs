namespace TP9_Nowak_Averbuch.Models
{
    class Nivel
    {
        private int _IdNivel;
        private string _Nivel;
        
        public int IdNivel{ get {return _IdNivel;} set {_IdNivel = value;}}

        public string Nivel{get {return _Nivel;} set {_Nivel = value;}}

       
        public Nivel(int IdNivel, string Nivel){
            idN = _IdNivel;
            niv = _Nivel ;
        }
        public Nivel(){}
    }
}   