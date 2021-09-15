using System; 

public class Concessionaria {
  private string localização {get; set;}
  private string gerente_principal {get; set;}
  private string ano_de_fundação {get; set;}
  private Carro carros_disponíveis {get; set;}
  private double Valortotal {get; set;}
  
  public Concessionaria (string localização,string gerente_principal,string ano_de_fundação,Carro carros_disponíveis, double Valortotal)
   {

    this.localização = localização;
    this.gerente_principal = gerente_principal;
    this.ano_de_fundação = ano_de_fundação;
    this.carros_disponíveis = carros_disponíveis;
    this.Valortotal = Valortotal 
    }
 public Carro carros = new Carro();
 public List<carros>  carroslist = new List<carros>();
 
 public void AdicionarCarro(Carro x)
    {
        foreach( Carro carros in carroslist)
        {
            carroslist.add(x);
        }
    }

    public double CalcularPortifolio()
    {
        foreach(Carros carros in carroslist)
        {
            Valortotal = Valortotal + carroslist(carros.valor);
        }
        return Valortotal;
    }
}
