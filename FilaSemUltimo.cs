
using System.Globalization;

public class FilaSemUltimo
{
    private Celula primeiro = new Celula();
    public long passos = 0;   // quantas células o inserir visitou

    public void inserir(int x)
    {
       Celula i = primeiro;
       while (i.prox != null)
        {
            passos++;
            i = i.prox;
        }
        i.prox = new Celula(x);
    }
}