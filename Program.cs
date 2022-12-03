System.Console.Write("Digite o valor Principal em R$: ");
decimal principal = Convert.ToDecimal(Console.ReadLine());
System.Console.Write("Dividido em quantas parcelas? ");
int parcelas = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Com quanto de juros? ");
decimal juros = Convert.ToDecimal(Console.ReadLine())/100;

decimal saldoDevedor = principal;
decimal amortizacao = principal / parcelas;
int periodo = 0;
while (periodo < parcelas)
{
    if(periodo == 0)
    {
        System.Console.WriteLine($"{periodo,-2:N0} | {amortizacao,-15:C} | {valorJuros,-15:C} | {prestacao,-15:C} | {valorPago,-15:C} | {saldoDevedor,-15:C} |");
    }
    decimal valorJuros = saldoDevedor * juros;
    decimal prestacao = amortizacao + valorJuros;
    decimal valorPago = saldoDevedor - amortizacao;
    saldoDevedor = saldoDevedor - amortizacao;
    System.Console.WriteLine($"{periodo,-2:N0} | {valorJuros,-15:C} | {saldoDevedor,-15:C} | {amortizacao,-15:C} | {prestacao,-15:C} | {valorPago,-15:C} |");
    periodo++;
}
