namespace TP9_Nowak_Averbuch.Models
{
    public class Nivel
    {
        private int _IdNivel;
        private string _StatusNivel;
        
        public int IdNivel{ get {return _IdNivel;} set {_IdNivel = value;}}

        public string StatusNivel{get {return _StatusNivel;} set {_StatusNivel = value;}}

       
        public Nivel(int  idN , string status){
            _IdNivel =  idN ; 
            _StatusNivel = status;
        }
        public Nivel(){}
    }
}   