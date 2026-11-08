MauiAppHotel

Aplicativo desenvolvido em .NET MAUI como atividade prática das Agendas 13 e 14 do curso Técnico em Desenvolvimento de Sistemas da ETEC de Ibaté.

O projeto simula a contratação de hospedagens em um hotel, permitindo informar a quantidade de hóspedes, selecionar uma acomodação, definir o período da estadia e visualizar o valor total da hospedagem.

Na Agenda 14, o projeto foi aprimorado com a aplicação de conceitos de Programação Orientada a Objetos (POO), validação de dados por meio das classes de modelo e melhorias na interface visual.

Funcionalidades

Seleção de hóspedes: informa a quantidade de adultos e crianças.
Escolha da acomodação: três opções de suítes:
   Suíte Simples – R$ 200,00 por diária;
   Suíte Master – R$ 300,00 por diária;
   Suíte Família – R$ 450,00 por diária.
Definição do período: seleção das datas de check-in e check-out.
Validação de informações: impede a continuidade sem pelo menos um adulto, sem acomodação selecionada ou com datas inválidas.
Controle de datas: atualiza automaticamente a data mínima do check-out conforme o check-in selecionado.
Cálculo da hospedagem: calcula a quantidade de diárias e o valor total.
Resumo da contratação: apresenta os dados da hospedagem em uma segunda tela.
Tela Sobre: apresenta informações sobre o aplicativo e seu desenvolvedor.
Interface aprimorada: organização visual com cartões, cores padronizadas, botões personalizados e adaptação da tela de confirmação com rolagem.


Classe Quarto

Responsável por representar as acomodações disponíveis no hotel.

Atributos privados para armazenar a descrição e o valor da diária.
Propriedades públicas com métodos get e set.
Encapsulamento e validação para impedir descrições vazias e valores de diária menores ou iguais a zero.
Construtor para inicializar os objetos.

Classe Hospedagem

Responsável por representar os dados de uma contratação.
Armazena a quantidade de adultos e crianças.
Mantém a referência ao quarto selecionado.
Armazena as datas de check-in e check-out.
Valida os dados recebidos no construtor.
Calcula automaticamente a quantidade de diárias e o valor total da hospedagem por meio de propriedades calculadas.



Tecnologias utilizadas

- C#
- .NET MAUI 10
- XAML
- Visual Studio Code
- .NET SDK
- Android SDK



Desenvolvedor: Eduardo Amaral

Curso Técnico em Desenvolvimento de Sistemas – ETEC de Ibaté.

Ano: 2026