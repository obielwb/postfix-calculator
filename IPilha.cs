﻿// Gabriel Willian Bartmanovicz - 21234
// João Pedro Ferreira Barbosa - 21687

using System.Collections.Generic;

public interface IPilha<Dado>
{
    void Empilhar(Dado dado);   // empilha o objeto "dado" 
    Dado Desempilhar();         // remove e retorna o objeto do topo
    Dado Topo();               // retorna o objeto do topo sem removê-lo
    int Tamanho { get; }        // informa a quantidade de itens empilhados
    bool EstaVazia { get; }     // informa se a pilha está ou não vazia  
    List<Dado> DadosDaPilha();  // percorre a pilha e retorna uma lista com todos os itens empilhados,
                                // sem alterar o conteúdo da pilha
}