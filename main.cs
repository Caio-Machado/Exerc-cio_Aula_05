using System;

class MainClass {
  public static void Main (string[] args) {
    //Variáveis
    bool sentinela = true;
    
    ModelagemPessoa Metodos = new ModelagemPessoa();
    
    while (sentinela == true) {
      
      Console.WriteLine ("Vamos Montar Uma Pessoa! \n Utilize o codigo baseado nas opções: \n Código  Ação \n 100     Criar nova pessoa. \n 101     Envelhecer \n 102     Emagrecer \n 103     Engordar \n 104     Crescer \n 105     Diminui Altura \n 106     Sair");
      int pergunta = int.Parse(Console.ReadLine ());
      
      //Optei por utilizar switch case, pois fiz um tipo de lista de opções cada uma em um caso.
      switch (pergunta) {
        //O primeiro caso remete a criação de uma pessoa, para se utilizar as outras opções é nescessário que pelomenos o nome existe. (Opção extra fora do escopo.)
        case 100:
          //Variável utilizadas para passar os parâmetros.
          string nomeNovo;
          int idadeNova;
          double pesoNovo;
          double alturaNovo;
          
          //Perguntas para recolher os dados.
          //Nome
          Console.WriteLine("Digite o Nome da pessoa:");
          nomeNovo = Console.ReadLine();
          
          //Idade
          Console.WriteLine("Digite a idade da pessoa:");
          idadeNova = int.Parse(Console.ReadLine());
          
          //Peso
          Console.WriteLine("Digite o peso da pessoa:");
          pesoNovo = double.Parse(Console.ReadLine());
          
          //Altura (Recolhida em metros)
          Console.WriteLine("Digite a altura da pessoa (Digite em metros ex: 1.70:");
          alturaNovo = double.Parse(Console.ReadLine());
          
          //Utilização de todos oa dados recolhidos como parâmetros para a função que ira asicionar essas informações.
          Metodos.CriaPessoa(nomeNovo, idadeNova, pesoNovo, alturaNovo);
          break;
        
        //Caso que executa a ação de envelhecer esta opçâo só funciona se houver informação de nome cadastrada.
        case 101:
          //Condicional que identifica se há um nome registrado. (A unica forma de regiatrar um nome é por meio da criação de uma pessoa. Assim evitando de engordar sem haver peso ainda.)
          if (Metodos.Validacao() == true) {
            
            //Variável para alteração da idade.
            int AumentaIdade;
            
            //Pergunta para recolher a idade.
            Console.WriteLine ("Digite quanto deseja envelhecer:");
            AumentaIdade = int.Parse(Console.ReadLine());
            
            //Execusão do método que modifica a idade.
            Metodos.Envelhece(AumentaIdade);
            
            //Feedback a respeito das alterações.
            Console.WriteLine("Sua idade atual é {0}",Metodos.MostraIdade());
            break;
          }
          
          else {
            //Menssagem informando a necessidade de criar uma pessoa antes.
            Console.WriteLine("Parece que não há nenhuma pessoa criada, tente utilizar o código 100 para criar uma.");
            break;
          }
        
        //Caso em que foi escolhido a opção de emagrecer
        case 102:
        
          //Método de validação.
          if (Metodos.Validacao() == true) {
            double DiminuiPeso;
            
            //Perfunta para recolha de dados.
            Console.WriteLine("Digite quanto deve emagrecer (Digite o valor em kg ex: 10.4):");
            DiminuiPeso = double.Parse(Console.ReadLine());
            
            //Utilização do metodo adequado, tendo como parâmetro o dado recolhido antes.
            Metodos.Emagrece(DiminuiPeso);
            
            //Feedback
            Console.WriteLine ("Seu peso atual agora é {0}", Metodos.MostraPeso());
            break;
          }
           //Condicional de negação da validação
          else {
            Console.WriteLine("Parece que não há nenhuma pessoa criada, tente utilizar o código 100 para criar uma.");
            break;
          }
          
        //Caso em que foi escolhido a opção engordar.
        case 103:
        
          //Vondicional de validação.
          if (Metodos.Validacao() == true) {
            double AumentaPeso;
            
            //Pergunta para coleta dos dados.
            Console.WriteLine("Digite o quanto deve engordar (digite o valor em kg ex: 10.4");
            AumentaPeso = double.Parse(Console.ReadLine());
            
            //Utilização do método adequado com o parametro como o dado recolhido anteriomente.
            Metodos.Engorda(AumentaPeso);
            
            //Feedback
            Console.WriteLine ("O seu peso atual agora é {0}", Metodos.MostraPeso());
            break;
          }
          
          //Condicional da negação do método de validação.
          else {
            Console.WriteLine("Parece que não há nenhuma pessoa criada, tente utilizar o código 100 para criar uma.");
            break;
          }
        
        //Caso em que foi escolhido a opção Crescer
        case 104:
          //Condicional de validação
          if (Metodos.Validacao() == true) {
            double AumentaAltura;
            //Recolhimento de dados
            Console.WriteLine("Digite o quanto deseja acrescentar a altura (utiliza em metros ex 0.15 = 15 cm)");
            AumentaAltura = double.Parse(Console.ReadLine());
            
            //Execusão do aumento da autura
            Metodos.Cresce(AumentaAltura);
            
            //Feedback
            Console.WriteLine("A sua altura atual agora é {0}", Metodos.MostraAltura());
            
            break;
          }
          
          //Condicional caso a validação retorne false
          else {
            Console.WriteLine("Parece que não há nenhuma pessoa criada, tente utilizar o código 100 para criar uma.");
            break;
          }
        
        //Caso em que foi escolhida a opçâo Diminui altura (Extra)
        case 105:
          //Condicional de validação
          if (Metodos.Validacao() == true) {
          double DiminuiAlrura;

          //Recolhimento de dados
          Console.WriteLine ("Digite o quanto deseja diminui na altura (utilize em metros ex: 0.25 = 25 cm)");
          DiminuiAlrura = double.Parse(Console.ReadLine());
          
          //Execusão da diminuição de autura
          Metodos.Diminui(DiminuiAlrura);
          
          //Feedback
          Console.WriteLine("A sua altura atual agora é {0}", Metodos.MostraAltura());
          break;
          }
          
          //Condicional caso a validação retorne false
          else {
            Console.WriteLine("Parece que não há nenhuma pessoa criada, tente utilizar o código 100 para criar uma.");
            break;
          }
          
        //Caso que encerra o programa
        case 106:
          sentinela = false;
          break;
          
      }
    }
  }
}