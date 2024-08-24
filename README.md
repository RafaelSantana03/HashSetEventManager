# HashSetEventManagement

Este projeto foi criado como um desafio proposto pelo ChatGPT para aplicar e fixar os conceitos que estudei sobre `HashSet` e `SortedSet` em C#. O objetivo foi desenvolver um pequeno projeto de gerenciamento de listas de convidados para eventos, utilizando esses recursos.

## Descrição do Projeto

O projeto simula a organização de listas de convidados para três eventos diferentes, com funcionalidades que incluem:

- **Verificar se todos os convidados de um evento estão presentes em outro:** Utilizando `HashSet.IsSubsetOf` para comparar listas.
- **Adicionar novos convidados a um evento:** Implementado com `HashSet.Add` para garantir que novos convidados sejam incluídos apenas se ainda não estiverem na lista.
- **Encontrar e exibir a interseção de convidados entre dois eventos:** Utilizando `HashSet.IntersectWith` para identificar convidados comuns.
- **Remover convidados de um evento que também estejam em outro:** Feito com `HashSet.ExceptWith`.
- **Combinar listas de convidados em uma única lista para o grande evento final:** Utilizando `HashSet.UnionWith` para criar uma lista final.
- **Ordenar e exibir a lista final de convidados:** Implementado com `SortedSet` para garantir a ordenação alfabética.
- **Limpar todas as listas de convidados após o evento.**

## Resultado
![Captura de tela 2024-08-23 211311](https://github.com/user-attachments/assets/eb3c4db2-f954-4ea0-bfe5-18a6c9fc0d22)

## Motivação

A ideia de solicitar um desafio ao ChatGPT foi para consolidar o que aprendi sobre `HashSet` e `SortedSet` durante meus estudos. Este exercício me permitiu praticar a implementação desses conceitos em um cenário realista e fortalecer minha compreensão.

## Como Executar

Você pode executar este projeto em uma IDE como Visual Studio ou qualquer editor de código que suporte C#. Basta compilar e rodar o código.

## Conclusão

Este foi um exercício valioso para reforçar os conceitos de coleções em C#. O processo de desenvolvimento ajudou a aprofundar meu entendimento de como utilizar `HashSet` e `SortedSet` para manipular conjuntos de dados de maneira eficiente.
