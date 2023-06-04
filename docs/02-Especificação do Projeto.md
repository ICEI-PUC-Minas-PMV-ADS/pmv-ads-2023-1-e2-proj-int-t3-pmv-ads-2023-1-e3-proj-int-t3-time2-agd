# Especificações do Projeto

## Personas

Patrícia tem 51 anos, é professora de matemática e tem um perfil inovador. Gosta de manter-se bem informada e utiliza desta característica para criar aulas mais dinâmicas e atuais.

João Pedro tem 33 anos e é professor do Ensino Médio da rede privada do Rio de Janeiro. Uma pessoa muito ligada à tecnologia e nas interações que facilitam o cenário mundial.

Matheus tem 25 anos e está cursando Análise e Desenvolvimento de Sistemas. Atualmente trabalha na administração da rede privada do Rio de Janeiro e é muito dedicado, está sempre compartilhando novidades tecnológicas que facilitam e otimizam os processos de trabalho.

Bruna tem 47 anos e é responsável pela parte administrativa da rede privada do Rio de Janeiro. Por não ter muita familiaridade com a tecnologia, prefere utilizar sistemas mais básicos e , que sejam autoexplicativos e de fácil entendimento.

## Histórias de Usuários

| **Eu como … [PERSONA]** | **… quero/desejo … [O QUE]** | **… para … [POR QUE]** |
|  --- | --- | --- |
| Patrícia | agendar empréstimos mensais dos notebooks | aplicação do teste online e só será possível se tiver notebook diponível |
| João Pedro | agendar horários a longo prazo, de acordo com o cronograma | garantir que tenha um notebook disponível neste horário de aula |
| Matheus | manter um intervalo entre um agendamento e outro | que não interfira no horário do agendamento seguinte |
| Bruna | garantir uma organização prévia dos atendimentos | não ter conflito de horário dos agendamentos |
| Matheus | ter um controle melhor e mais preciso dos notebook | saber quais e quantos precisam de manutenção |

## Requisitos

A lista que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

| **Numeração** | **Descrição** | **Prioridade** |
|  --- | --- | --- |
| RF-001 | Verificar se o usuário conseguirá efetuar o login a partir das informações corretas (e-mail, senha e perfil do funcionário) |  ALTA |
| RF-002 | O sistema deve impossibilitar o usuário de continuar o login caso esteja informando um e-mail não autorizado, fazendo-o retomar a etapa de informar o e-mail institucional |  ALTA |
| RF-003 | O perfil administrador terá a possibilidade de registrar os equipamentos com suas identificações ( ex: SJOHNNTXXX ), especificações (HOSTNAME, MODELO, STATUS). Ademais, o administrador gerencia operações específicas do sistema como: edição, alteração e/ou cancelamento de agendamentos  |  ALTA |
| RF-004 |O usuário poderá realizar o agendamento do empréstimo do equipamento na data desejada, desde que o horário esteja disponível e o usuário preencha os dados requisitados ( dentre eles: e-mail institucional, sala, turma e a quantidade de notebooks) necessários para o agendamento |  ALTA |
| RF-005 | O sistema deve possuir uma condição de controle de horário do empréstimo para evitar a interseção de agendamentos por parte dos usuários |  ALTA |
| RF-006 | O sistema deve fornecer aos usuários a possibilidade de cancelamento do seu próprio agendamento de forma simples, apenas clicando em "cancelar". Essa ação só será permitida para o perfil Administrador |  MEDIO |
| RF-007 | O sistema deve permitir que o administrador edite os agendamentos |  BAIXO |
| RF-008 | O sistema precisará diferenciar o usuário por meio do seu e-mail institucional |  BAIXO |
| RF-009 | O usuário poderá verificar a lista de agendamentos |  BAIXO |
| RF-010 | O sistema irá restringir mais de 5 agendamentos semanais por usuário (professor) |  BAIXO |

### Requisitos não Funcionais

| **Numeração** | **Descrição** | **Prioridade** |
|  --- | --- | --- |
| RNF-001 | O sistema deve ser uma aplicação desktop |  ALTA |
| RNF-002 | O sistema deve ser feito com framework .NET | MEDIO |
| RNF-003 | O sistema deverá gerar um relatório de estado dos equipamentos para a administração | BAIXO |
| RFN-004 | O sistema deve gerar um relatório de frequência de uso dos professores | BAIXO |
| RFN-005 | A aplicação será desenvolvida na linguagem C# | ALTA |



## Restrições

| **Numeração** | **Descrição** | **Prioridade** |
|  --- | --- | --- |
| RF001 | Não haverá versão web e mobile; | ALTA |  
| RF002 | O sistema não terá a opção de selecionar outros idiomas. Todo o website será em Português-BR | BAIXO |
| RF003 | O projeto deverá ser entregue no final do semestre letivo, não podendo extrapolar o prazo estipulado | ALTA | 

## Casos de Uso

![Captura de tela 2023-03-19 211532](https://user-images.githubusercontent.com/114964435/226219361-0f887ca3-5034-4ad8-92e0-0deda7a05b7d.png)


