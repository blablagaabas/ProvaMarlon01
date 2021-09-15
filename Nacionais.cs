using System; 

public class Nacionais:Carro{
  private string cor {get; set;}
  private string marca {get; set;}
  private string modelo {get; set;}
  private double valor {get; set;}
  private int ano {get; set;}
  
  public Nacionais(string cor,string marca,string modelo,double valor, int ano):base(cor, marca, modelo, valor, ano){

    this.cor = cor;
    this.marca = marca;
    this.modelo = modelo;
    this.valor = valor;
    this.ano = ano;
    }
   
  public override void definirValorVeiculo(double CustoFixo){
    
  }


}