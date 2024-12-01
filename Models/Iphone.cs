namespace DesafioPOO.Models
{
   

 // TODO: Herdar da classe "Smartphone"
    
public class Iphone
 : Smartphone   {


public Iphone(string Numero, string Modelo, string IMEI, int Memoria) : base(numero, modelo, imei, memoria)  { }
// TODO: Sobrescrever o método "InstalarAplicativo"
				public override void InstalarAplicativo(string nomeApp){
			Console.WriteLine($"Instalando '{nomeApp}'");

			
			Console.WriteLine($"'{nomeApp}' instalado com sucesso");
}
}
}