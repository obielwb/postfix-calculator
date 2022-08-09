// Gabriel Willian Bartmanovicz - 21234
// João Pedro Ferreira Barbosa - 21687

using System.Collections.Generic;

public interface IStack<T>
{
    void Push(T dado);   // empilha o objeto "dado" 
    T Pop();         // remove e retorna o objeto do topo
    T Peek();               // retorna o objeto do topo sem removê-lo
    int Size { get; }        // informa a quantidade de itens empilhados
    bool IsEmpty { get; }     // informa se a pilha está ou não vazia  
    List<T> StackData();  // percorre a pilha e retorna uma lista com todos os itens empilhados,
                                // sem alterar o conteúdo da pilha
}