Console.ForegroundColor = ConsoleColor.Cyan;
System.Console.Write("Digite o valor Principal:    R$ ");
decimal principal = Convert.ToDecimal(Console.ReadLine());

System.Console.Write("Dividido em quantas parcelas?.. ");
int parcelas = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Com qual taxa de juros?........ ");
decimal juros = Convert.ToDecimal(Console.ReadLine()) / 100;

decimal saldoDevedor = principal;
decimal amortizacao = principal / parcelas;
int periodo = 0;
decimal valorJuros, prestacao, valorPago;
valorPago = 0;

Console.ForegroundColor = ConsoleColor.Green;
System.Console.WriteLine($"  {"Periodo",-9}   {"Amortização",-15}   {"Valor Juros",-15}   {"Prestação",-15}   {"Valor Pago",-15}   {"Saldo Devedor",-15}  ");
System.Console.WriteLine();
Console.ForegroundColor = ConsoleColor.White;


while (periodo <= parcelas)
{
    if (periodo == 0)
    {
        System.Console.WriteLine($"| {periodo,-9:N0} | {"",-15} | {"",-15} | {"",-15} | {"",-15} | {saldoDevedor,-15:C} |");
        periodo++;
    }
    else
    {
        valorJuros = saldoDevedor * juros;
        prestacao = amortizacao + valorJuros;
        valorPago = valorPago + prestacao;
        saldoDevedor = saldoDevedor - amortizacao;
        System.Console.WriteLine($"| {periodo,-9:N0} | {amortizacao,-15:C} | {valorJuros,-15:C} | {prestacao,-15:C} | {valorPago,-15:C} | {saldoDevedor,-15:C} |");
        periodo++;
    }
}
Console.ResetColor();