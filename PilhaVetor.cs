// Gabriel Willian Bartmanovicz - 21234
// João Pedro Ferreira Barbosa - 21687

using System;
using System.Collections.Generic;

public class PilhaVetor<Dado> : IPilha<Dado>
{
    Dado[] p;
    int topo;

    public PilhaVetor(int tamanho)
    {
        p = new Dado[tamanho];
        topo = -1;          // pois acabamos de criar a pilha, VAZIA
    }

    public PilhaVetor() : this(500)
    { }

    public int Tamanho => topo + 1;
    public bool EstaVazia => topo < 0;

    public void Empilhar(Dado dado)
    {
        if (Tamanho == p.Length)
            throw new Exception("`Pilha cheia (Stack Overflow)!");

        topo++;
        p[topo] = dado;
    }

    public Dado Desempilhar()
    {
        if (EstaVazia)
            throw new Exception("Pilha vazia (Stack Underflow)!");

        Dado dado = p[topo];
        topo--;
        return dado;
    }

    public Dado Topo()
    {
        if (EstaVazia)
            throw new Exception("Pilha vazia (Stack Underflow)!");

        Dado dado = p[topo];

        return dado;
    }

    public List<Dado> DadosDaPilha()
    {
        List<Dado> dados = new List<Dado>();

        for (int indice = 0; indice <= topo; indice++)
            dados.Add(p[indice]);

        return dados;
    }
}