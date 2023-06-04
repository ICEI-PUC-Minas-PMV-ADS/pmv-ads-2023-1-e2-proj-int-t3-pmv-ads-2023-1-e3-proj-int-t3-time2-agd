# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Cenários de testes utilizados na realização dos testes da aplicação AgendAI atendendo aos requisitos pré-definidos na seção "2 - Especificação do Projeto". 
 
| **Caso de Teste** 	| **CT-01 - Login** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-001 - O usuário deverá escolher o perfil como administrador ou professor. O sistema também irá requerer a senha.|
| Objetivo do Teste 	| Verificar se o usuário conseguirá efetuar o login a partir das informações corretas (e-mail, senha e perfil do funcionário). |
| Passos 	| - Acessar a aplicação <br> - Informar o endereço do site <br> - Selecionar o perfil desejado (admininstrador ou professor) <br> - Preencher os campos obrigatórios (e-mail e senha) <br> - Clicar em "Entrar" <br> |
|Critério de Êxito | - O Login foi realizado com sucesso. |
|  	|  	|
| Caso de Teste	| **CT-02 - Informe de Login Inválido** 	|
|	Requisito Associado 	| RF-002 - O sistema deve impossibilitar o usuário de continuar o login caso esteja informando um e-mail não autorizado, fazendo-o retomar a etapa de informar o e-mail institucional.  |
| Objetivo do Teste 	| Caso as informações de Login (email e senha) estejam erradas, o sistema deve emitir um alerta de erro ao usuário.  |
| Passos 	| - Acessar a aplicação <br> - Informar o endereço do site <br> - Selecionar o perfil desejado (admininstrador ou professor) <br> - Preencher os campos obrigatórios (e-mail e senha) <br> - Clicar em "Entrar" <br> | - Uma mensagem deve aparecer alertando o usuário sobre o erro <br> |
|Critério de Êxito | - Login inválido. |
|  	|  	|
| Caso de Teste	| **CT-03 – Cadastrar Equipamentos** |
|	Requisito Associado 	| RF-003 - O perfil administrador terá a possibilidade de registrar os equipamentos com suas identificações ( ex: SJOHNNTXXX ), especificações (HOSTNAME, MODELO, STATUS). Ademais, o administrador gerencia operações específicas do sistema como: edição, alteração e/ou cancelamento de agendamentos. |
| Objetivo do Teste 	| Verificar se o usuário consegue cadastrar na aplicação os equipamentos com suas respectivas especificações de identificação. |
| Passos 	| - Acessar a aplicação <br> - Informar o endereço do site <br> - Selecionar o perfil desejado (admininstrador ou professor) <br> - Preencher os campos obrigatórios (e-mail e senha) <br> - Clicar em "Entrar" <br> | - Clicar em "Equipamentos" <br> | - Preencher os campos obrigatórios em Cadastro de Equipamentos (Hostname, Modelo, Status) <br> | - Clicar em "Salvar" <br> |
|Critério de Êxito | - O cadastro foi realizado com sucesso. |
|  	|  	|
| Caso de Teste 	| **CT-04 – Efetuar Agendamento**	|
|Requisito Associado | RF-004	- O usuário poderá realizar o agendamento do empréstimo do equipamento na data desejada, desde que o horário esteja disponível e o usuário preencha os dados requisitados ( dentre eles: e-mail institucional, sala, turma e a quantidade de notebooks) necessários para o agendamento|
| Objetivo do Teste 	| Verificar se fez o agendamento corretamente. |
| Passos 	| - Acessar a aplicação <br> - Informar o endereço do site <br> - Selecionar o perfil desejado (admininstrador ou professor) <br> - Preencher os campos obrigatórios (e-mail e senha) <br> - Clicar em "Entrar" <br> - Clicar em "Novo agendamento" <br> - Selecionar a data e hora desejada para o agendamento, dentro da faixa de disponibilidade <br> - Digitar a quantidade desejada <br> - Digitar o nº da sala de reserva do agendamento <br> - Digitar o e-mail institucional <br> - Digitar o ID do funcionário <br> - Selecionar o tipo do evento (aula, prova ou atualização) <br> - Clicar em "Agendar" <br> |
|Critério de Êxito | - O agendamento foi realizado com sucesso. |
|  	|  	|
| Caso de Teste 	| **CT-05 - Controle de Horário** 	|
|	Requisito Associado 	| RF-005 - 	O sistema deve possuir uma condição de controle de horário do empréstimo para evitar a interseção de agendamentos por parte dos usuários |
| Objetivo do Teste 	| Verificar se o sistema vai impedir o "usuário 1" de agendar o mesmo equipamento no mesmo horário que o "usuário 2" agendou.  |
| Passos 	| - Acessar a aplicação <br> - Informar o endereço do site <br> - Selecionar o perfil desejado (admininstrador ou professor) <br> - Preencher os campos obrigatórios (e-mail e senha) <br> - Clicar em "Entrar" <br> - Clicar em "Novo agendamento" <br> - Selecionar a data e hora desejada para o agendamento, dentro da faixa de disponibilidade <br> - Digitar a quantidade desejada <br> - Digitar o nº da sala de reserva do agendamento <br> - Digitar o e-mail institucional <br> - Digitar o ID do funcionário <br> - Selecionar o tipo do evento (aula, prova ou atualização) <br> - Clicar em "Agendar" <br> - Após preencher os pré requisitos necessário da aplicação, repetir o processo de agendamento com as credenciais de outro professor, no mesmo dia e horário, selecionando o mesmo equipamento <br> - Uma mensagem deve aparecer alertando o usuário sobre o erro <br> |
|Critério de Êxito | - Indisponível. |
|  	|  	|
| Caso de Teste 	| **CT-06 – Cancelar Agendamento**	|
|Requisito Associado | RF-006	- O sistema deve fornecer aos usuários a possibilidade de cancelamento do seu próprio agendamento de forma simples, apenas clicando em "cancelar". Essa ação só será permitida para o perfil Administrador |
| Objetivo do Teste 	| Verificar se o cancelamento foi realizado. |
| Passos 	| - Informar o endereço do site <br> - Selecionar o perfil "admininstrador" <br> - Preencher os campos obrigatórios (e-mail e senha) <br> - Clicar em "Entrar" <br> - Clicar em "Agendamento" <br> - Clicar em cancelar <br> - Clicar em apagar <br> |
|Critério de Êxito | - O cancelamento foi realizado com sucesso. |
|  	|  	|
| Caso de Teste 	| **CT-07 – Editar Agendamentos** 	|
|Requisito Associado | RF-007	- O sistema deve permitir que o administrador edite os agendamentos |
| Objetivo do Teste 	| Alterar dados no agendamento, caso seja necessário. |
| Passos 	| -  Selecionar a data e hora desejada para o agendamento, dentro da faixa de disponibilidade <br> - Digitar a quantidade desejada <br> - Digitar o nº da sala de reserva do agendamento <br> - Digitar o e-mail institucional <br> - Digitar o ID do funcionário <br> - Selecionar o tipo do evento (aula, prova ou atualização) <br> - Clicar em "salvar" |
|Critério de Êxito | - A edicação foi realizada com sucesso. |
|  	|  	|
| Caso de Teste 	| **CT-08 – Diferenciar usuário** 	|
|Requisito Associado | RF-008	- O sistema precisará diferenciar o usuário por meio do seu e-mail institucional |
| Objetivo do Teste 	| O sistema precisará diferenciar o usuário "administrador" e "professor" por meio do seu e-mail institucional ao selecionar o perfil desejado para fazer login |
| Passos 	| - Acessar a aplicação <br> - Informar o endereço do site <br> - Selecionar o perfil desejado (admininstrador ou professor) <br> - Preencher os campos obrigatórios (e-mail e senha) <br> - Clicar em "Entrar" <br> |
|Critério de Êxito | - As funcionalidades do sistema devem diferir entre os dois usuários. |
|  	|  	|
| Caso de Teste 	| **CT-09 – Meus agendamentos** 	|
|Requisito Associado | RF-009	- Verificar a lista de agendamentos |
| Objetivo do Teste 	| O sistema exibirá uma lista com todos os agendamentos  e informações, são elas: ID do funcionário, data, quantidade, sala, e-mail institucional e tipo do evento |
| Passos 	| - Acessar a aplicação <br> - Informar o endereço do site <br> - Selecionar o perfil desejado (admininstrador ou professor) <br> - Preencher os campos obrigatórios (e-mail e senha) <br> - Clicar em "Entrar" <br> - Clicar em "Meus agendamentos" <br> |
|Critério de Êxito | - Exibir os agendamentos do usuário. |
|  	|  	|
| Caso de Teste 	| **CT-10 – Restrição de agendamento** 	|
|Requisito Associado | RF-010	-O sistema irá restringir mais de 5 agendamentos semanais por usuário (professor) |
| Objetivo do Teste 	| Verificar se o mesmo usuário não excedeu o limite de 5 agendamentos semanais. |
| Passos 	| - O usuário fará a seleção de seus agendamentos semanais corretamente até a quinta solicitação, na sexta solicitação quando o usuário clicar em "salvar agendamento" aparecera uma mensagem do sistema na tela "O usuário atingiu seu limite máximo de agendamentos" |
|Critério de Êxito | - O sistema conseguir identificar com sucesso que nenhum usuário ultrapassou o limite padrão pré-determinado. |


 

