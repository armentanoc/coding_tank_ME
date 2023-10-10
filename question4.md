## Questão 4 

O resultado correto é 1 (alternativa C). 

Para entender o raciocínio, precisamos quebrar a expressão `numero = Convert.ToInt16(!(21 > 21));`

1. `(21 > 21)` é uma comparação que checa se 21 é maior que 21 (que retorna False, porque não é verdadeira) 
2. `!(21 > 21)` nega a conclusão anterior, então o booleano se transforma em True
3. `Convert.ToInt16(true)` converte um valor booleano True em inteiro; quando True é convertido pra inteiro, ele se transforma em 1
4. Quando você atribui um valor de Int16 a um Int32, ocorre uma conversão implícita de tipos. Como o Int 32 cabe o Int 16, a conversão é segura e não ocorre perda de dados. 
   
Por esse motivo, o valor printado no terminal é 1. 
