// Gabriel Willian Bartmanovicz - 21234
// João Pedro Ferreira Barbosa - 21687

using System;
using System.Collections.Generic;
public class StackVector<T> : IStack<T>
{
    T[] p;
    int top;
    public StackVector(int max)
    {
        p = new T[max];
        top = -1;          // pois acabamos de criar a pilha, VAZIA
    }

    public StackVector() : this(500)
    { }

    public int Size => top + 1;
    public bool IsEmpty => top < 0;
    public void Push(T T)
    {
        if (Size == p.Length)
            throw new Exception("`Pilha cheia (Stack Overflow)!");

        top = top + 1;    // ou apenas
        p[top] = T;     // p[++top] = T;
    }
    public T Pop()
    {
        if (IsEmpty)
            throw new Exception("Pilha vazia (Stack Underflow)!");
        T stacked = p[top]; // ou
        top = top - 1;              // T TEmpilhado = p[top--];
        return stacked;
    }
    public T Peek()
    {
        if (IsEmpty)
            throw new Exception("Pilha vazia (Stack Underflow)!");

        T stacked = p[top]; // copia o conteúdo da posição topo
                                      // e não altera o valor do índice top
                                      // ou seja, mantém o estado da pilha,
                                      // apenas consultou o T empilhado
                                      // no topo da pilha
        return stacked;
    }

    public List<T> StackData()
    {
        List<T> lista = new List<T>();

        for (int indice = 0; indice <= top; indice++)
            lista.Add(p[indice]);

        return lista;
    }
}