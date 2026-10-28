
public class Fila
{
    private Celula primeiro, ultimo;   // primeiro é o nó cabeça

    public Fila()
    {
        primeiro = new Celula();
        ultimo = primeiro;  
    }

    public bool isVazia()
    {
        return primeiro == ultimo;
    }   // TODO (Parte 1)

    public int tamanho()
    {
        int cont = 0;
        for(Celula i = primeiro.prox; i != null; i = i.prox)
        {
            cont++;
        }

        return cont;
    }    // TODO (Parte 1)

    public void inserir(int x)
    {
            ultimo.prox = new Celula(x);
            ultimo = ultimo.prox; 
    }   // TODO (Parte 1)

    public int remover()   // TODO (Parte 1): lançar Exception("Erro: fila vazia") se vazia
    {
        if (primeiro == ultimo)
            throw new Exception("Erro: fila vazia");
        Celula tmp = primeiro;
        primeiro = primeiro.prox;
        int elemento = primeiro.elemento;
        tmp.prox = null;
        tmp = null;
        return elemento;
    }

    public void mostrar()  // TODO (Parte 1): imprimir no formato [3, 5, 7]
    {
        Console.Write("[ ");
        for (Celula i = primeiro.prox; i != null; i = i.prox)
            Console.Write(i.elemento + " ");
        Console.WriteLine("]");
    }   

    // ---------- Parte 3 ----------
    public bool pesquisar(int x)
    {
        for (Celula i = primeiro.prox; i != null; i = i.prox)
        {
            if(i.elemento == x)
            {
                return true;
            }
        }
        return false;
        
    }   // TODO
    public int maior()
    {
        if (primeiro == ultimo)
            throw new Exception("Erro!");
        int maior = primeiro.prox.elemento;
        Celula i = primeiro.prox.prox;
        while (i != null) {
            if (i.elemento > maior) {
                maior = i.elemento;
            }
            i = i.prox;
        }
        return maior;
    }           // TODO (exceção se vazia)
    public int somar()
    {
        int resp = 0;
        for (Celula i = primeiro.prox; i != null; i = i.prox) {
            resp += i.elemento;
        }
        return resp;
    }           // TODO
    public void inverter()
    {
        if (primeiro == ultimo) return; 
        Celula fim = ultimo;
        bool terminou = false;
        while (!terminou) {
            terminou = (primeiro.prox == fim); 
            Celula nova = new Celula(primeiro.prox.elemento);
            nova.prox = fim.prox; 
            fim.prox = nova;
            Celula tmp = primeiro.prox; 
            primeiro.prox = tmp.prox;
            tmp.prox = null;
            if (ultimo == fim) ultimo = nova;
        }
    }         // TODO (use Stack<int>)

    // ---------- Desafio opcional ----------
    public int removerUltimo() { throw new NotImplementedException(); }     // TODO
}