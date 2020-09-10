using System;

class ModelagemPessoa {
  // Atributos
  private string nome;
  private int idade;
  private double peso;
  private double alturaCm;
  
  //SETs
  //Método Cria Pessoa (SET)
  public void CriaPessoa (string nomeNovo, int idadeNova, double pesoNovo, double alturaNova) {
    
    nome = nomeNovo;
    
    idade = idadeNova;
    
    peso = pesoNovo;
    
    alturaCm = alturaNova;
  }
  
  //Método envelhecer (SET)
  public void Envelhece (int AumentaIdade) {
    for (int x = 0; x < (AumentaIdade + 1); x++) {
      idade = idade + 1;
      
      if (idade < 21) {
        alturaCm = alturaCm + 0.5;
      }
    }
  }
  
  //Método emagrece (SET)
  public void Emagrece (double DiminuiPeso) {
    peso = peso - DiminuiPeso;
  }
  
  //Método engorda (SET)
  public void Engorda (double AumentaPeso) {
    peso = peso + AumentaPeso;
  }
  
  //Método cresce (SET)
  public void Cresce (double AumentaAltura) {
    alturaCm = alturaCm + AumentaAltura;
  }
  
  //Método diminui (SET)
  public void Diminui (double DiminuiAltura) {
    alturaCm = alturaCm - DiminuiAltura;
  }
  
  
  
  //GETs
  //GET da variavel idade.
  public int MostraIdade () {
    return idade;
  }
  
  //GET variável peso.
  public double MostraPeso () {
    return peso;
  }
  
  //GET da variavel alturaCm
  public double MostraAltura () {
    return alturaCm * 100;
  }
}