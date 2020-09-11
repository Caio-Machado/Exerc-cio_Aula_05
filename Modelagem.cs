using System;

class ModelagemPessoa {
  // Atributos
  private string nome = "";
  private int idade;
  private double peso;
  private double altura;
  
  
  public bool Validacao () {
    bool Resultado;
    
    if (nome == "") {
      Resultado = false;
    }
    
    else {
      Resultado = true;
    }
    
    return Resultado;
  }
  
  //SETs
  //Método Cria Pessoa (SET)
  public void CriaPessoa (string nomeNovo, int idadeNova, double pesoNovo, double alturaNova) {
    
    nome = nomeNovo;
    
    idade = idadeNova;
    
    peso = pesoNovo;
    
    altura = alturaNova;
  }
  
  //Método envelhecer (SET)
  public void Envelhece (int AumentaIdade) {
    for (int x = 0; x < AumentaIdade; x++) {
      idade = idade + 1;
      
      if (idade < 21) {
        altura = ((altura * 100) + 0.5) / 100;
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
    altura = altura + AumentaAltura;
  }
  
  //Método diminui (SET)
  public void Diminui (double DiminuiAltura) {
    altura = altura - DiminuiAltura;
  }
  
  
  
  //GETs
  //GET da variavel nome.
  public string MostraNome () {
    return nome;
  }
  
  //GET da variavel idade.
  public int MostraIdade () {
    return idade;
  }
  
  //GET variável peso.
  public double MostraPeso () {
    return peso;
  }
  
  //GET da variavel altura
  public double MostraAltura () {
    return altura;
  }
}