Algoritmo "Exercício 1 – Combustível"
// Disciplina   : [Linguagem e Lógica de Programação]
// Professor   : Antonio Carlos Nicolodi 
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 17/03/2023
Var
// Seção de Declarações das variáveis 
 litros, result: real
 cod: caracter

Inicio
// Seção de Comandos, procedimento, funções, operadores, etc... 
 escreva ("Digite a quantidade de litros:")
 leia (litros)
 escreva ("Digite A para álcool ou G para gasolina:")
 leia (cod)
  se (cod = "A") entao
   se (litros <= 20) entao
    result:= litros * (4,30 - (4,30 * 3/100))
     escreva ("O valor a pagar é de: result")
   senao
     result:= litros * (4,30 - (4,30 * 5/100))
      escreva ("O valor a pagar é de: result")
   fimse
  senao
   se (cod = "G") entao
    se(litros <=20) entao
     result:= litros * (5,50 - (5,50 * 4/100))
      escreva ("O valor a pagar é de: result")
    senao
      result:= litros * (5,50 - (5,50 * 6/100))
       escreva ("O valor a pagar é de: result")
    fimse
   fimse
  fimse

Fimalgoritmo