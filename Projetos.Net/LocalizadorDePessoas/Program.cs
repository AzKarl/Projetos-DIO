using static System.Console;
public class Program
{
   static bool EncontrarPessoa(List<StructPessoa> pessoas, StructPessoa pessoa)
  {
    foreach (var item in pessoas)
    {
        if(item.Equals(pessoa))
        {
          return true;
        }
    }
    return false;
  } 
  public static void Main()
  {
    List<StructPessoa> pessoas = new List<StructPessoa>()
    {
      new StructPessoa(){Nome = "Ricardo"},
      new StructPessoa(){Nome = "José"},
      new StructPessoa(){Nome = "Maria"},
      new StructPessoa(){Nome = "Fabiana"},
      new StructPessoa(){Nome = "Eduardo"},
    };

    WriteLine("Digite a pessoa que gostaria de localizar:");
    var nome = ReadLine();
    var pessoa = new StructPessoa(){Nome = nome};
    var encontrado = EncontrarPessoa(pessoas, pessoa);
    if(encontrado)
    {
      WriteLine("Pessoa localizada!");
    }
    else
    {
      WriteLine("Pessoa não localizada");
    }

  }
}