using System;

class MainClass {
  public static void Main (string[] args) {
    //Variáveis
    bool sentinela = true;
    
    ModelagemPessoa Metodos = new ModelagemPessoa();
    
    while (sentinela == true) {
      
      Console.WriteLine ("Vamos Montar Uma Pessoa! \n Utilize o codigo baseado nas opções: \n Código  Ação \n 100     Criar nova pessoa. \n 101     Envelhecer \n 102     Emagrecer \n 103     Engordar \n 104     Crescer \n 105     Sair");
      
      int pergunta = int.Parse(Console.ReadLine ());
      
      switch (pergunta) {
        case 100:
          if (Metodos.MostraNome() != "") {
            string nomeNovo;
            int idadeNova;
            double pesoNovo;
            double alturaNovo;
          
            Console.WriteLine("Digite o Nome da pessoa:");
            nomeNovo = Console.ReadLine();
          
            Console.WriteLine("Digite a idade da pessoa:");
            idadeNova = int.Parse(Console.ReadLine());
          
            Console.WriteLine("Digite o peso da pessoa:");
            pesoNovo = double.Parse(Console.ReadLine());
          
            Console.WriteLine("Digite a altura da pessoa:");
            alturaNovo = double.Parse(Console.ReadLine());
          
            Metodos.CriaPessoa(nomeNovo, idadeNova, pesoNovo, alturaNovo);
            break;
            
          else {
            Console.WriteLine("Parece que não há nenhuma pessoa criada, tente utilizar o código 100 para criar uma.");
          }
        
        case 101:
          int AumentaIdade;
        
          Console.WriteLine ("Digite quanto deseja envelhecer:");
          AumentaIdade = int.Parse(Console.ReadLine());
          
          Metodos.Envelhece(AumentaIdade);
          
          Console.WriteLine("Sua idade atual é {0}",Metodos.MostraIdade());
          break;
          
      }
    }
  }
}