using System;

class Aula11 {
    static void Main() {
        int nota=80;
        string Resultado = "Reprovado";
       
        if(nota >= 80){
            Resultado = "Aprovado";
        }
        Console.WriteLine("Resultado:{0} ",Resultado);
    }
}