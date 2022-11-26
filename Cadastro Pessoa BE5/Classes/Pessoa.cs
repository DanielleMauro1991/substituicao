using Cadastro_Pessoa_BE5.Interfaces;

namespace Cadastro_Pessoa_BE5.Classes
{
    public abstract class Pessoa : IPessoa
    {
        public string ?nome {get; set;}

        public Endereco ?endereco { get; set; }
        
        public float rendimento { get; set; }
        
    
        public abstract float PagarImposto(float rendimento);
    
    }
}