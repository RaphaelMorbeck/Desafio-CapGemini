using System;
using System.Collections;

public class Program
{
	private static int n = 6;
    private static string ast;
    private static string spc;
    private static int x = 1;
	public static void Main()
	{
		Console.WriteLine("Digite a quantidade de degraus da escada");
		n = Convert.ToInt32(Console.ReadLine());
		
		
		while (x < n){
            spc += " ";
            x++;
        }
    	for (int i = n; i <= n & i > 0; i--)
		{
        ast += "*";
        Console.WriteLine(spc+ast);
        if(i<=n & i>1){
            spc = spc.Remove(0, 1);
        }
		}
	}
}