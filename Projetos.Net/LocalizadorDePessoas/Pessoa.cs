public class Pessoa
{
    public string Nome {get; set;} 
    public Pessoa Clone()
    {      
      return new Pessoa()
      {       
        Nome = this.Nome
      };
    }
}