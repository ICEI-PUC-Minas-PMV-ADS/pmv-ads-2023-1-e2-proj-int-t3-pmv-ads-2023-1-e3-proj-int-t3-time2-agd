# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Cenários de testes utilizados na realização dos testes da aplicação AgendAI atendendo aos requisitos pré-definidos na seção "2 - Especificação do Projeto". 
 
| **Caso de Teste** 	| **CT-01** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-00X - A aplicação deve apresentar, na página principal, a funcionalidade de cadastro de usuários para que esses consigam criar e gerenciar seu perfil. |
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar na aplicação. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://adota-pet.herokuapp.com/src/index.html<br> - Clicar em "Criar conta" <br> - Preencher os campos obrigatórios (e-mail, nome, sobrenome, celular, CPF, senha, confirmação de senha) <br> - Aceitar os termos de uso <br> - Clicar em "Registrar" |
|Critério de Êxito | - O cadastro foi realizado com sucesso. |
|  	|  	|
| Caso de Teste	| CT-02 – Cadastrar Equipamentosl|
|	Requisito Associado 	| RF-002 O perfil administrador terá a possibilidade de: registrar os equipamentos com suas identificações ( ex: SJOHNNTXXX ), especificações ( Nº DE SÉRIE, SISTEMA OPERACIONAL, MODELO ETC ), além do controle de estoque. Ademais, o administrador gerencia operações específicas do sistema como: permissão, alteração e/ou cancelamento de agendamentos|
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar na aplicação os equipamentos com suas respectivas especificações de identificação. |
| Passos 	|  |
|Critério de Êxito | - O cadastro foi realizado com sucesso. |
|  	|  	|
| **Caso de Teste** 	| **CT-03** 	|
|	Requisito Associado 	| RF-00X  |
| Objetivo do Teste 	|  |
| Passos 	|  |
|Critério de Êxito |  |
|  	|  	|
| Caso de Teste 	| CT-04 – Efetuar Agendamento	|
|Requisito Associado | RF-004	- O usuário poderá realizar o agendamento do empréstimo do equipamento na data desejada, desde que o horário esteja disponível e o usuário preencha os dados requisitados ( dentre eles: e-mail institucional, sala, turma e a quantidade de notebooks) necessários para o agendamento|
| Objetivo do Teste 	| Verificar fez o agendamento corretamente. |
| Passos 	| |
|Critério de Êxito | - O agendamento foi realizado com sucesso. |
| **Caso de Teste** 	| **CT-05** 	|
|	Requisito Associado 	| RF-00X  |
| Objetivo do Teste 	|  |
| Passos 	|  |
|Critério de Êxito |  |
|  	|  	|
| Caso de Teste 	| CT-06 – Cancelar Agendamento	|
|Requisito Associado | RF-006	- O sistema deve fornecer aos usuários a possibilidade de cancelamento do seu próprio agendamento por meio do preenchimento de um formulário com: e-mail institucional e justificativa;OBS: esse formulário será enviado para o suporte administrativo, para ter ciência do ocorrido|
| Objetivo do Teste 	| Verificar se o cancelamento foi realizado. |
| Passos 	| |
|Critério de Êxito | - O cancelamento foi realizado com sucesso. |
| **Caso de Teste** 	| **CT-07** 	|
|	Requisito Associado 	| RF-00X  |
| Objetivo do Teste 	|  |
| Passos 	|  |
|Critério de Êxito |  |
|  	|  	|
| Caso de Teste 	| CT-08 – Busca por datas 	|
|Requisito Associado | RF-008	-Mecanismo de busca por datas ( ex: 20/10/2023 ) |
| Objetivo do Teste 	| Fazer uma busca de agendamento por data. |
| Passos 	| |
|Critério de Êxito | - Busca de agendamento por data realizada com sucesso. |
| **Caso de Teste** 	| **CT-09** 	|
|	Requisito Associado 	| RF-00X  |
| Objetivo do Teste 	|  |
| Passos 	|  |
|Critério de Êxito |  |
|  	|  	|
| Caso de Teste 	| CT-10 – Restrição de agendamento 	|
|Requisito Associado | RF-010	-O sistema irá restringir mais de 5 agendamentos semanais por usuário (professor) |
| Objetivo do Teste 	| Verificar se o mesmo usuário não excedeu o limite de 5 agendamentos semanais. |
| Passos 	| |
|Critério de Êxito | - O sistema conseguir identificar com sucesso que nenhum usuário ultrapassou o limite padrão pré-determinado. |
 

