using System;

class ModelagemPessoa {
  //variáveis
  private string nome = "";
  private int idade;
  private double peso;
  private double altura;
  
  //Método que valida se há ou não uma pessoa cadastrada. Para evitar que sejam feitas alterações em variáveis que sejam sem valor.
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
  //Método Cria Pessoa. Ele recolhe e salva as informações desejadas (SET)
  public void CriaPessoa (string nomeNovo, int idadeNova, double pesoNovo, double alturaNova) {
    
    nome = nomeNovo;
    
    idade = idadeNova;
    
    peso = pesoNovo;
    
    altura = alturaNova;
  }
  
  //Método envelhecer. Ao aplicar a regra de negócio descrita no exercício ele troca os valores ja registrados em cm e depois retorna eles de volta para metros. (SET)
  public void Envelhece (int AumentaIdade) {
    for (int x = 0; x < AumentaIdade; x++) {
      //O aumento do peso vem antes do aumento da idade para certificar que todos os anos envelhecidos sejam respeitados antes dos 21
      if (idade < 21) {
        altura = ((altura * 100) + 0.5) / 100;

      idade = idade + 1;
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
  
  
  
  //GETs (variáveis para interagirem com as variáveis privadas)
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