

namespace Construtores
{
    public class Criatura
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Vida { get; set; }

        public Criatura(){

        }

        public Criatura(int _codigo){
            this.Codigo = _codigo;
        }

        public Criatura(int _codigo, string _nome, string _descricao, int _vida){

            this.Codigo     = _codigo;
            this.Nome       = _nome;
            this.Descricao  = _descricao;
            this.Vida       = _vida;

        }
    }
}