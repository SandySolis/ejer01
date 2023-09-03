// Si los ingresos del comprador son menores de $8000, el enganche será del
// 15% del costo de la casa y el resto se distribuirán pagos mensuales, a pagar en diez
// años. Si los ingresos del comprador son igual o mayores de $8000, el enganche será
// del 30% del costo de la casa y el resto se distribuirá en pagos mensuales a pagar en
// 7 años.La empresa quiere obtener cuanto debe pagar un comprador por concepto de
// enganche y cuanto por cada pago parcial.


Console.WriteLine("Ingrese el costo de la casa: ");
decimal costocasa = decimal.Parse(Console.ReadLine());

Console.WriteLine("Ingrese los ingresos del comprador: ");
decimal ingrcomp = decimal.Parse(Console.ReadLine());

decimal enganche = 0;
decimal pagomensual = 0;

if (ingrcomp<8000)
{
    enganche = 0.15m * costocasa;
    pagomensual = (costocasa - enganche) / 120; 
}
else
{ 
    enganche = 0.30m * costocasa;
    pagomensual = (costocasa - enganche) / 84; 
}

Console.WriteLine("El enganche a pagar es: " +enganche);
Console.WriteLine("El pago mensual a pagar es: " +pagomensual);
