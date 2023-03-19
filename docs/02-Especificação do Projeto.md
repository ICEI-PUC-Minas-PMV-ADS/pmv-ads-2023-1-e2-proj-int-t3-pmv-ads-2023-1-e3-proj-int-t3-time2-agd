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
| RF-001 | O sistema deve fornecer ao usuário a opção de login através do e-mail institucional. Caso seja o perfil administrativo, o sistema também irá requerir a senha |  ALTA |
| RF-002 | O perfil administrador terá a possibilidade de: registrar os equipamentos com suas identificações ( ex: SJOHNNTXXX ), especificações ( Nº DE SÉRIE, SISTEMA OPERACIONAL, MODELO ETC ), além do controle de estoque. Ademais, o administrador gerencia operações específicas do sistema como: permissão, alteração e/ou cancelamento de agendamentos |  ALTA |
| RF-003 | Ao acessar o servidor o usuário deverá se identificar com seu e-mail institucional |  ALTA |
| RF-003 | O sistema deve impossibilitar o usuário de continuar o login caso esteja informando um e-mail não altorizado, fazendo-o retomar a etapa de informar o e-mail institucional  |  ALTA |
| RF-004 | O usuário poderá realizar o agendamento do empréstimo do equipamento na data desejada, desde que o horário esteja disponível e o usuário preencha os dados requisitados ( dentre eles: e-mail institucional, sala, turma e a quantidade de notebooks) necessários para o agendamento |  ALTA |
| RF-005 | O sistema deve possuir uma condição de controle de horário do empréstimo para evitar a interseção de agendamentos por parte dos usuários |  ALTA |
| RF-006 | O sistema deve fornecer aos usuários a possibilidade de cancelamento do seu próprio agendamento por meio do preenchimento de um formulário com: e-mail institucional e justificativa;OBS: esse formulário será enviado para o suporte administrativo, para ter ciência do ocorrido |  MEDIO |
| RF-007 | O sistema deve fornecer aos usuários a possibilidade de informar ao perfil administrativo por meio de uma TAG quaisquer informações relacionadas a avarias nos equipamentos e requisições adicionais ao software; O perfil administrativo terá uma aba de notificações com as mensagens recebidas separadas por TAGS |  BAIXO |
| RF-008 | Mecanismo de busca por datas ( ex: 20/10/2023 ) |  BAIXO |
| RF-009 | O sistema precisará diferenciar o usuário por meio do seu e-mail institucional |  BAIXO |
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

![image](https://user-images.githubusercontent.com/71721477/224516023-66c7f438-f0e4-456b-82ff-982935fbaf8c.png)


