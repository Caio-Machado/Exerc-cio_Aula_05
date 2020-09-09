using System;

class ModelagemPessoa {
  // Atributos
  private string nome;
  private int idade;
  private double peso;
  private double alturaCm;
  
  //Método Cria Pessoa
  public void CriaPessoa (string nomeNovo, int idadeNova, double pesoNovo, double alturaNova) {
    
    nome = nomeNovo;
    
    idade = idadeNova;
    
    peso = pesoNovo;
    
    alturaCm = alturaNova;
  }
    
  public void MostraNome () {
    Console.WriteLine("{0} {1} {2} {3}", nome, idade, peso, alturaCm);
  }
}