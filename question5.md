## Questão 5

O resultado correto é -5, -2, 1, 4, 7 (alternativa E). 

Isso ocorre porque, num loop `for`:

1. A primeira parte da expressão (`int i = -5`) inicializa uma variável com o valor em que o loop será iniciado; logo, 5 
2. A segunda parte da expressão (`i <= 7`) indica que o loop será executado até que a variável seja menor ou igual a 7; logo, o último número é 7
3. A terceira parte da expressão (`i += 3`) indica que, a cada loop, ocorrerá a soma do valor 3 à variável i (-5; (-5+3 = 2), ...)
4. Por fim, o `Console.WriteLine(i)` escreve em cada linha o valor que a variável i apresentava naquele loop específico. 
   
Por esse motivo, o valor printado no terminal é -5, -2, 1, 4, 7 (separado por linhas). 
