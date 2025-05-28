# DIO - Trilha .NET - Programação orientada a objetos
www.dio.me

## Desafio de projeto
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de orientação a objetos, da trilha .NET da DIO.

## Contexto
Você é responsável por modelar um sistema que trabalha com celulares. Para isso, foi solicitado que você faça uma abstração de um celular e disponibilize maneiras de diferentes marcas e modelos terem seu próprio comportamento, possibilitando um maior reuso de código e usando a orientação a objetos.

## Proposta
Você precisa criar um sistema em .NET, do tipo console, mapeando uma classe abstrata e classes específicas para dois tipos de celulares: Nokia e iPhone. 
Você deve criar as suas classes de acordo com o diagrama abaixo:

![Diagrama classes](Imagens/diagrama.png)

## Regras e validações
1. A classe **Smartphone** deve ser abstrata, não permitindo instanciar e servindo apenas como modelo.
2. A classe **Nokia** e **Iphone** devem ser classes filhas de Smartphone.
3. O método **InstalarAplicativo** deve ser sobrescrito na classe Nokia e iPhone, pois ambos possuem diferentes maneiras de instalar um aplicativo.

## Explicação do Código Desenvolvido
O código que desenvolvemos implementa uma estrutura orientada a objetos para representar smartphones em C#, garantindo organização, reutilização de código e aplicação de conceitos fundamentais como herança, abstração e implementação de interfaces.
1. Criação da Classe Abstrata Smartphone
- Definimos a classe Smartphone como abstrata, impedindo que seja instanciada diretamente.
- Essa classe contém propriedades comuns aos smartphones, como modelo, IMEI e memória.
- Implementamos métodos concretos, como Ligar() e ReceberLigacao(), para garantir funcionalidades básicas.
- O método InstalarAplicativo(string nome) foi definido como abstrato, exigindo que as classes derivadas implementem sua própria versão.
2. Implementação das Classes Nokia e Iphone
- Criamos as classes Nokia e Iphone, que herdam de Smartphone.
- Ambas implementam de forma diferente o método InstalarAplicativo(), refletindo suas particularidades:
- Nokia instala aplicativos utilizando a loja própria da marca.
- Iphone instala aplicativos pela App Store.
3. Adição da Interface IAparelhoTelefonico
- Implementamos a interface IAparelhoTelefonico para padronizar funcionalidades comuns a dispositivos telefônicos.
- A interface define os métodos Ligar(), ReceberLigacao() e InstalarAplicativo(), garantindo que todas as classes que a implementam possuam esses comportamentos.
4. Teste do Código
- Criamos a classe Program para testar as funcionalidades.
- Instanciamos objetos Nokia e Iphone, verificando que cada um mantém suas particularidades e respeita o modelo estabelecido.
