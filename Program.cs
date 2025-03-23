using Car.Entities;
    Locacao locacao = new Locacao();
    
 int TempoH ;



   Console.WriteLine("Infome o Id ");
locacao.ID = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Infome o instante inicial");
locacao.IsI = double.parse(Console.ReadLine());
Console.WriteLine("Infome o instante final ");
locacao.IsF = double.parse(Console.ReadLine());
Console.WriteLine("Infome o Valor da hora ");
locacao.VH = double.parse(Console.ReadLine());
Console.WriteLine("Infome o Modelo");
locacao.Model = Console.ReadLine();
int VlLocacao = (locacao.VD + locacao.VH);
TempoH = (locacao.IsF - locacao.IsI);

if (TempoH > 12 && locacao.VH <= 100){
    Console.WriteLine("Infome o Valor Diario ");
    locacao.VD = Convert.ToInt16(Console.ReadLine());
   double Vt = (VlLocacao*1.20);
   double VlImposto = (VlLocacao*0.20);
   Console.WriteLine($"Valor da locação {VlLocacao}, Valor Total {Vt},valor do imposto{VlImposto},Modelo do carro{locacao.Model},o carro foi alugado por {TempoH} horas  ");

}
else if (TempoH > 12 && locacao.VH > 100){
    Console.WriteLine("Infome o Valor Diario ");
    locacao.VD = Convert.ToInt16(Console.ReadLine());
   double Vt = (VlLocacao *1.15);
   double VlImposto = (VlLocacao*0.15);
   Console.WriteLine($"Valor da locação {VlLocacao}, Valor Total {Vt},valor do imposto{VlImposto},Modelo do carro{locacao.Model}, o carro foi alugado por {TempoH} horas  ");

}
else 
     Console.WriteLine($"Valor da locação {VlLocacao}, Valor Total {VlLocacao},Modelo do carro{locacao.Model}, o carro foi alugado por {TempoH} horas ");

 