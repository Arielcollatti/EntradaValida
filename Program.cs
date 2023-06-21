 CW(" ---Entrada Válida--- \n ");

 Console.Write("DIgite um valor entre 1 e 9 (ou  0 para cancelar a operação).........: ");
 int nume = int.Parse(Console.ReadLine()!);

while (nume < 0 || nume > 9)
{
     Console.WriteLine("", ConsoleColor.White);
     Console.Write("Digite um número entre 1 e 9 (ou 0 para cancelar a operação).........: ");
   nume  = int.Parse(Console.ReadLine()!);
}

if (nume  >= 1 && nume  <= 9)
{
    CW("");
CW($" O valor digitado é igual a {nume}");
}
else if (nume == 0)
{
    CW("");
 Console.WriteLine(" A operação foi encerrada!", Console.ForegroundColor = ConsoleColor.DarkRed);
 Console.ResetColor();
 return;    
}          


//Criação de uma sub rotina onde CW = Console.Writeline 
void CW (string CW) 
{
    Console.WriteLine(CW);

};

