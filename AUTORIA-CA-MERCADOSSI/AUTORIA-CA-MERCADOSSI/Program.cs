// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bem vindo ao mercado do Fracalossi");
// Nesse codigo você vai poder escolher entre duas carnes
// Vai a carne, quantos quilos e vai te dar o preço final
Console.WriteLine("Temos dois tipos de carne. Pinhaca e Alcatra ");
Console.WriteLine("(1)- ALCATRA (pedaço) __________________R$55,00" +
    "              (2)- PICANHA (pedaço) __________________R$60,00");
Console.WriteLine("Digite o codigo da carne que deseja: ");
int tipo = int.Parse(Console.ReadLine());
if  (tipo == 1)
{
    Console.WriteLine("Voce escolheu Alcatra, otima escolha!");
    Console.WriteLine("Não vendemos pedaços cortados, apenas peças inteiras. Quantos quilos você deseja? ");
    double peso1 = int.Parse(Console.ReadLine());
    Console.WriteLine($"Você escolheu {peso1} quilos ");
    double total1;
    total1 = peso1 * 55;
    Console.WriteLine($"O valor que você deve pagar pelos {peso1} quilos é : R${total1} ");
    Console.WriteLine("Tudo certo :) Bom apetite");
}
else
{
    Console.WriteLine("Voce escolheu Picanha, otima escolha!");
    Console.WriteLine("Não vendemos pedaços cortados, apenas peças inteiras. Quantos quilos você deseja? ");
    double peso2 = int.Parse(Console.ReadLine());
    Console.WriteLine($"Você escolheu {peso2} quilos ");
    double total2;
    total2 = peso2 * 60;
    Console.WriteLine($"O valor que você deve pagar pelos {peso2} quilos é : R${total2} ");
    Console.WriteLine("Tudo certo :) Bom apetite");
}

