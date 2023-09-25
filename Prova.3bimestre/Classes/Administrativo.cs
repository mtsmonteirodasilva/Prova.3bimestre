class Adiministrativo : Funcionario
{
    public string Funcao { get; set; }

    public Adiministrativo(string nome, string cpf, int matricula, DateTime dataNascimento, string sexo, double salario, string funcao) : base(nome, cpf, matricula, dataNascimento, sexo, salario)
    {
        this.Funcao = funcao ;
    }
}
