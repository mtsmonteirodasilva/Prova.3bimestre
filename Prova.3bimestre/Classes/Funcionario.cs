class Funcionario
{
    public string Nome { get; set; }
    public string CPF { get; set; }
    public int Matricula { get; set; }
    public DateTime DataNascimento { get; set; }
    public string Sexo { get; set; }
    public double Salario { get; set; }

   
       
    public Funcionario(string nome, string cpf, int matricula, DateTime dataNascimento, string sexo, double salario)
    {
        this.Nome = nome;
        this.CPF = cpf;
        this.Matricula = matricula;
        this.DataNascimento = dataNascimento;
        this.Sexo = sexo;
        this.Salario = salario;
    }
}