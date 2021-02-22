# TesteTrade

Neste teste tentei implementar algo que venho ouvindo bastante: o design Factory. Abaixo explicarei a estrutura, e também como criar novos riscos nesse exemplo de trade.

![](https://github.com/OtavioMenhart/TesteTrade/blob/main/imgReadme/solution.png)

Primeiramente, construí a ITrade com 2 campos Value e ClientSector. Em TradeImplementation herdei dessa interface e adicionei um construtor. 
Depois, foi a vez de criar a classe abstrata GenericRisk:

![](https://github.com/OtavioMenhart/TesteTrade/blob/main/imgReadme/genericRisk.png)

Nela temos o nome do risco, e uma variável booleana que será setada (via herança) pelo método Validation.

Dessa forma, temos um caminho a ser seguido por todos os riscos do nosso projeto, exemplo: 

![](https://github.com/OtavioMenhart/TesteTrade/blob/main/imgReadme/exampleRisk.png)

A classe LowRisk determina seu nome como “LOWRISK”, faz um override no método de validação, executa sua regra de negócio e retorna caso a validação seja verdadeira ou falsa.

Com todos os riscos criados (low, medium e high), é hora de criar o factory. Então criei a TradeFactory, que tem apenas um método ReturnRisk, a implementação dessa classe abstrata ficou assim:

![](https://github.com/OtavioMenhart/TesteTrade/blob/main/imgReadme/tradeRiskFactory.png)
