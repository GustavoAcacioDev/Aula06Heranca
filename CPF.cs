namespace Aula06Heranca
{

    //Chamando Herança da classe "Pessoa"
    public class CPF : Pessoa
    {
        public string cpf;

        public string rg;
        
        
        public bool vailidarCPF(){
            if(cpf != null){
                return true;
            }

            return false;
        }
    }
}