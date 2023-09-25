class Medico : Funcionario
{
    public string CRM { get; }
    public double ValorHoraExtra { get; }
    public string Especialidade { get; }

    public Medico(string nome, string cpf, int matricula, DateTime dataNascimento, string sexo, double salario, string crm, double valorHoraExtra, string especialidade)
        : base(nome, cpf, matricula, dataNascimento, sexo, salario)
    {
        this.CRM = crm;
        this.ValorHoraExtra = valorHoraExtra;
        this.Especialidade = especialidade;
    }
}