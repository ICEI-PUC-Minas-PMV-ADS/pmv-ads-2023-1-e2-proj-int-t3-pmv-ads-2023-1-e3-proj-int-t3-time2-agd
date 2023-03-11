# Especificações do Projeto

## Personas

Patrícia tem 51 anos, casada, é professora de matemática e tem perfil inovador e focado em números. Gosta de ficar por dentro das novidades, com  o objetivo de deixar suas aulas mais dinâmicas e interativas.

João Pedro tem 14 anos, é estudante do 9º ano do Ensino Fundamental de uma rede privada do Rio de Janeiro. Gosta de videogame e jogos online.

Julia tem 16 anos e é estudante de uma rede privada no Rio de Janeiro, ela está no 2º ano do Ensino Médio. Passa grande parte do tempo mexendo nas redes sociais, principalmente TikTok e Instagram,  e está sempre por dentro das tendências. Julia se interessa por moda e estilo, pretende cursar Design de Moda na faculdade.

Matheus é solteiro e tem 24 anos. Trabalha no setor técnico da rede privada desde 2018. É muito focado no trabalho e tem o objetivo de cursar Redes de Computadores para  abrir sua própria empresa de Datacenter.

Bruna tem 30 anos, é casada e tem 2 filhos. Ela é responsável pela parte de administração da rede privada que trabalha há 7 anos e ama o que faz, isso a incentivou a começar o curso de Administração e Gestão de Empresas. Bruna valoriza muito o tempo com sua família, gosta de frequentar a praia, parques e restaurantes.

## Histórias de Usuários

| **Eu como … [PERSONA]** | **… quero/desejo … [O QUE]** | **… para … [POR QUE]** |
|  --- | --- | --- |
| Patrícia | utilizar os notebooks disponível no colégio | criar aulas mais dinâmicas e conteúdos mais diversos |
| João Pedro | utilizar os notebooks disponíveis | responder as avaliações dos professores e dispor de ferramentas mais amplas de pesquisa |
| Julia | ter aulas utilizando os notebooks | para aprender de maneira mais dinâmica |
| Patrícia | agendar horários a longo prazo, de acordo com o cronograma | dar aulas mais interativas e menos cansativas para os alunos |
| Matheus | ter um controle melhor e mais preciso dos notebook | saber quais e quantos precisam de manutenção |
| Bruno | organizar melhor os horários disponíveis entre um agendamento e outro | não ter conflito de horário nos agendamentos |

## Requisitos

A lista que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

| **Numeração** | **Descrição** | **Prioridade** |
|  --- | --- | --- |
| RF-001 | O sistema deve fornecer à coordenação a possibilidade de login como "administrador", com funcionalidades específicas que diferem das permitidas ao usuário “professor” |  ALTA |
| RF-002 | O perfil administrador terá a possibilidade de: registrar os equipamentos com suas identificações ( ex: SJOHNNTXXX ), especificações ( Nº DE SÉRIE, SISTEMA OPERACIONAL, MODELO ETC ), além do controle de estoque. Ademais, o administrador gerencia operações específicas do sistema como: permissão, alteração e/ou cancelamento de agendamentos |  ALTA |
| RF-003 | Ao acessar o servidor o usuário deverá se identificar com seu e-mail institucional |  ALTA |
| RF-004 | O usuário poderá realizar o agendamento do empréstimo do equipamento na data desejada, desde que o horário esteja disponível e o usuário preencha os dados requisitados ( dentre eles: e-mail institucional, sala, turma e a quantidade de notebooks) necessários para o agendamento |  ALTA |
| RF-005 | O sistema deve possuir uma condição de controle de horário do empréstimo para evitar a interseção de agendamentos por parte dos usuários |  ALTA |
| RF-006 | O sistema deve fornecer aos usuários a possibilidade de cancelamento do seu próprio agendamento por meio do preenchimento de um formulário com: e-mail institucional e justificativa;OBS: esse formulário será enviado para o suporte administrativo, para ter ciência do ocorrido |  MEDIO |
| RF-007 | O sistema deve fornecer aos usuários a possibilidade de informar ao perfil administrativo por meio de uma TAG quaisquer informações relacionadas a avarias nos equipamentos e requisições adicionais ao software; O perfil administrativo terá uma aba de notificações com as mensagens recebidas separadas por TAGS |  BAIXO |
| RF-008 | Mecanismo de busca por datas ( ex: 20/10/2023 ) |  BAIXO |
| RF-009 | O sistema precisará diferenciar o usuário por meio do seu e-mail institucional; |  BAIXO |
| RF-010 | O sistema irá restringir mais de 5 agendamentos semanais por usuário (professor) |  BAIXO |

### Requisitos não Funcionais

| **Numeração** | **Descrição** | **Prioridade** |
|  --- | --- | --- |
| RNF-001 | O sistema deve ser uma aplicação desktop; |  ALTA |
| RNF-002 | O sistema deve ser feito com framework .NET. | MEDIO |
| RNF-003 | O sistema deverá gerar um relatório de estado dos equipamentos para a administração; | BAIXO |
| RFN-004 | O sistema deve gerar um relatório de frequência de uso dos professores; | BAIXO |
| RFN-005 | A aplicação será desenvolvida na linguagem C#; | ALTA |



## Restrições

| **Numeração** | **Descrição** | **Prioridade** |
|  --- | --- | --- |
| RF001 | Não haverá versão web e mobile; | ALTA |  
| RF002 | O sistema não terá a opção de selecionar outros idiomas. Todo o website será em Português-BR. | BAIXO |
| RF003 | O projeto deverá ser entregue no final do semestre letivo, não podendo extrapolar o prazo estipulado. | ALTA | 


