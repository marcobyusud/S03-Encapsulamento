using System.Globalization;

Fracao fracaoPadrao = new Fracao();
Fracao fracaoInteira = new Fracao(5);
Fracao tresQuartos = new Fracao(3, 4);
Fracao umTerco = new Fracao(1, 3);

MostrarFracao(fracaoPadrao);
MostrarFracao(fracaoInteira);
MostrarFracao(tresQuartos);
MostrarFracao(umTerco);

Fracao fracaoAlterada = new Fracao();
fracaoAlterada.DefinirNumerador(3);
fracaoAlterada.DefinirDenominador(4);

Console.WriteLine($"Numerador: {fracaoAlterada.ObterNumerador()}");
Console.WriteLine($"Denominador: {fracaoAlterada.ObterDenominador()}");

static void MostrarFracao(Fracao fracao)
{
    Console.WriteLine(fracao.ObterFracaoEmTexto());
    Console.WriteLine(fracao.ObterFracaoEmDecimal().ToString(CultureInfo.InvariantCulture));
}
