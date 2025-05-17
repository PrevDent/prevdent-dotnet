# Prevdent API

## Integrantes do Grupo

Vitor Cruz dos Santos - RM553621

Keven Ike Pereira da Silva - RM553215

José Ribeiro dos Santos Neto - RM553844

## Descrição do projeto

  O PrevDent é um aplicativo inovador que visa transformar a saúde bucal por meio da
prevenção e do acesso facilitado a informações e serviços odontológicos. Em um cenário onde a
alta taxa de sinistros e a falta de informação prejudicam a saúde dental, o PrevDent se propõe a
ser um aliado essencial para usuários de todas as idades. A aplicação busca promover hábitos
saudáveis e educar os usuários sobre cuidados essenciais para a saúde bucal, ao mesmo tempo
em que facilita o agendamento prático de consultas e o acesso a especialistas de forma rápida e
eficiente.

   Uma das grandes inovações do PrevDent é a integração da telemedicina, que permite
consultas virtuais, proporcionando aos usuários orientações e diagnósticos de dentistas sem a
necessidade de deslocamento. A plataforma oferece funcionalidades que incluem a visualização
de consultas agendadas, um histórico de diagnósticos e tratamentos, além de conteúdos
educacionais abrangentes sobre odontologia, capacitando os usuários em relação à sua saúde
bucal. Os usuários também recebem orientações personalizadas sobre a melhor especialidade
odontológica para suas necessidades específicas, tornando o acesso a cuidados ainda mais
eficiente.

    O PrevDent atende a uma diversidade de públicos, como adultos e idosos, famílias com
crianças, profissionais ocupados, usuários de planos odontológicos e pessoas com acesso
limitado a serviços odontológicos. Cada segmento se beneficia de recursos personalizados que
atendem às suas necessidades específicas, assegurando que todos possam ter acesso à
informação e ao cuidado que necessitam.

    Com uma abordagem integrada que combina tecnologia, educação e acessibilidade, o PrevDent
se destaca como uma solução completa para a saúde bucal. O aplicativo não apenas promove um
cuidado proativo e informativo, mas também visa reduzir a necessidade de tratamentos
emergenciais, melhorando a qualidade de vida dos usuários e contribuindo para um futuro onde a
saúde bucal é prioridade para todos.


##  Definição da Arquitetura da API e Justificativa da Escolha

A arquitetura escolhida para esta API é monolítica, pois o projeto é pequeno e não justifica a complexidade de microsserviços. Esta abordagem permite que toda a aplicação seja construída como um único sistema, onde todos os módulos compartilham um único código-base e banco de dados.

Embora os microsserviços sejam vantajosos para sistemas que requerem alta escalabilidade, eles trazem desafios, como a necessidade de orquestração e comunicação entre serviços, além de aumentar a complexidade geral. No caso deste projeto, optar por uma arquitetura monolítica evita o overengineering, já que a simplicidade facilita tanto o desenvolvimento quanto a manutenção.

As vantagens da arquitetura monolítica incluem menor complexidade, facilidade de deploy, custos operacionais reduzidos e a possibilidade de escalar a aplicação horizontalmente, se necessário. Assim, essa arquitetura se mostra mais adequada, garantindo eficiência e um gerenciamento mais simples. Se, no futuro, o projeto necessitar de maior escalabilidade, a modularização do código permitirá uma transição gradual para microsserviços, sem exigências de grandes refatorações.


## Design Patterns Utilizados
- **Dependency Injection**: Utilizado para gerenciar dependências e promover a inversão de controle.
- **Repository Pattern**: Para abstrair a lógica de acesso a dados e facilitar a manutenção e testes.
- **Factory Pattern**: Para a criação de objetos complexos, promovendo a reutilização de código e a separação de responsabilidades.

## Instruções para Rodar a API (LocalHost)

### Pré-requisitos
- .NET 8 SDK
- Oracle Database (ou outro banco de dados configurado)

### Passos
1. Clone o repositório:
    ```bash
    git clone https://github.com/PrevDent/prevdent-dotnet.git
    ```

2. Navegue até o diretório do projeto:
    ```bash
    cd prevdent-dotnet
    ```

3. Restaure as dependências do projeto:
    ```bash
    dotnet restore
    ```

4. Crie o banco de dados (se necessário):
    - Certifique-se de ter o Oracle Database ou outro banco de dados configurado corretamente.
    - Se estiver usando Oracle, crie um banco de dados e configure as credenciais no arquivo de configuração `appsettings.json`.

5. Execute a aplicação:
    ```bash
    dotnet run
    ```



   ## 🧪 Testes Implementados

O projeto incorpora uma suíte abrangente de testes automatizados para garantir a confiabilidade e a robustez do sistema. Os testes abrangem:

- **Testes Unitários**: Validação de componentes individuais para assegurar que cada unidade de código funcione conforme o esperado.
- **Testes de Integração**: Verificação da interação entre diferentes módulos e serviços do sistema.
- **Cobertura de Testes**: Monitoramento contínuo da cobertura de código para identificar áreas que necessitam de testes adicionais.

As ferramentas utilizadas para a implementação e gerenciamento dos testes incluem frameworks populares no ecossistema .NET, como xUnit, NUnit ou MSTest, juntamente com bibliotecas de mocking para simular dependências externas.

---

## 🧹 Práticas de Clean Code Aplicadas

O código do projeto segue rigorosamente os princípios do Clean Code, visando legibilidade, manutenibilidade e eficiência. As práticas adotadas incluem:

- **Nomenclatura Significativa**: Utilização de nomes claros e descritivos para variáveis, métodos e classes.
- **Funções Pequenas e Coesas**: Implementação de funções que realizam uma única tarefa específica.
- **Tratamento Adequado de Erros**: Uso consistente de estruturas de tratamento de exceções para capturar e gerenciar erros de forma eficaz.
- **Princípios SOLID**: Aplicação dos princípios de design de software para promover um código mais modular e flexível.
- **Documentação Clara**: Comentários e documentação que explicam o "porquê" das implementações, facilitando o entendimento do código por outros desenvolvedores.

Essas práticas são inspiradas em recursos como o projeto [clean-code-dotnet](https://github.com/thangchung/clean-code-dotnet), que adapta os conceitos do livro _Clean Code_ de Robert C. Martin para o ambiente .NET.

---

## 🤖 Funcionalidades de IA Generativa

O projeto integra funcionalidades de Inteligência Artificial generativa para aprimorar a experiência do usuário e a eficiência do sistema. As aplicações de IA incluem:

- **Geração de Conteúdo**: Criação automática de descrições e informações relevantes para os usuários, baseando-se em dados existentes.
- **Assistência Inteligente**: Implementação de assistentes virtuais que auxiliam os usuários na navegação e utilização do sistema.
- **Análise Preditiva**: Utilização de modelos de IA para prever necessidades dos usuários e oferecer soluções proativas.

A integração de IA é realizada por meio de APIs e serviços especializados, garantindo que as funcionalidades sejam escaláveis e alinhadas com as melhores práticas de desenvolvimento.

