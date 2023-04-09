# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Cenários de testes utilizados na realização dos testes da aplicação AgendAI atendendo aos requisitos pré-definidos na seção "2 - Especificação do Projeto". 
 
| **Caso de Teste** 	| **CT-01 - Login** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-001 - O sistema deve fornecer ao usuário a opção de login através do e-mail institucional. Caso seja o perfil administrativo, o sistema também irá requerir a senha|
| Objetivo do Teste 	| Verificar se o usuário consegue efetuar o Login apartir das informações corretas (email e senha). |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar em "Login" <br> - Preencher os campos obrigatórios (email e senha) <br> - Clicar em "Entrar" |
|Critério de Êxito | - O Login foi realizado com sucesso. |
|  	|  	|
| Caso de Teste	| **CT-02 – Cadastrar Equipamentos** |
|	Requisito Associado 	| RF-002 O perfil administrador terá a possibilidade de: registrar os equipamentos com suas identificações ( ex: SJOHNNTXXX ), especificações ( Nº DE SÉRIE, SISTEMA OPERACIONAL, MODELO ETC ), além do controle de estoque. Ademais, o administrador gerencia operações específicas do sistema como: permissão, alteração e/ou cancelamento de agendamentos|
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar na aplicação os equipamentos com suas respectivas especificações de identificação. |
| Passos 	|  - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar em "Admnistrador" <br> - Clicar em "Equipamentos" <br>- Preencher os campos obrigatórios em Cadastro de Equipamentos(Hostname, Nº de Série, Sistema Operacional, Modelo, Quantidade) <br> - Clicar em "Cadastrar"|
|Critério de Êxito | - O cadastro foi realizado com sucesso. |
|  	|  	|
| Caso de Teste	| **CT-03 - Informe de Login Inválido** 	|
|	Requisito Associado 	| RF-003 - O sistema deve impossibilitar o usuário de continuar o login caso esteja informando um e-mail não autorizado, fazendo-o retomar a etapa de informar o e-mail institucional  |
| Objetivo do Teste 	| Caso as informações de Login (email e senha) estejam erradas, o sistema deve emitir um alerta de erro ao usuário.  |
| Passos 	| Acessar o navegador <br> - Informar o endereço do site <br> - Clicar em "Login" <br> - Preencher os campos obrigatórios com informações erradas (email e senha) <br> - Clicar em "Entrar" <br> - Um "balão" de aviso deve subir alertando o usuário sobre o erro |
|Critério de Êxito | - Login inválido. |
|  	|  	|
| Caso de Teste 	| **CT-04 – Efetuar Agendamento**	|
|Requisito Associado | RF-004	- O usuário poderá realizar o agendamento do empréstimo do equipamento na data desejada, desde que o horário esteja disponível e o usuário preencha os dados requisitados ( dentre eles: e-mail institucional, sala, turma e a quantidade de notebooks) necessários para o agendamento|
| Objetivo do Teste 	| Verificar se fez o agendamento corretamente. |
| Passos 	|  - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar em "Professor" <br> - Clicar em uma data no calendário <br>- Selecionar o horário dentro da faixa de disponibilidade <br>- Preencher os campos obrigatórios de Agendamento(Nome do Professor,Email Institucional,Turma, Quantidade de Equipamentos) <br> - Clicar em "Salvar Agendamento"|
|Critério de Êxito | - O agendamento foi realizado com sucesso. |
| Caso de Teste 	| **CT-05 - Controle de Horário** 	|
|	Requisito Associado 	| RF-005 - 	O sistema deve possuir uma condição de controle de horário do empréstimo para evitar a interseção de agendamentos por parte dos usuários |
| Objetivo do Teste 	| Verificar se o sistema vai impedir o "usuário 1" de alugar o mesmo equipamento no mesmo horário que o "usuário 2" alugou.  |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar em "Login" <br> - Preencher os campos obrigatórios (email e senha) <br> - Clicar em "Entrar" <br> - Na homepage da aplicação, clicar em um dia aleatório <br> - Selecionar horários, preencher as credenciais corretas e escolher a quantidade na tela seguinte <br> - Após todos os trâmites realizados anteriormente, repetir o processo de aluguel com as credenciais de outro professor, no mesmo dia e horário, selecionando o mesmo equipamento <br> - Um "balão" de aviso deve subir alertando o usuário sobre o erro |
|Critério de Êxito | - Indisponível. |
|  	|  	|
| Caso de Teste 	| **CT-06 – Cancelar Agendamento**	|
|Requisito Associado | RF-006	- O sistema deve fornecer aos usuários a possibilidade de cancelamento do seu próprio agendamento por meio do preenchimento de um formulário com: e-mail institucional e justificativa; OBS: esse formulário será enviado para o suporte administrativo, para ter ciência do ocorrido|
| Objetivo do Teste 	| Verificar se o cancelamento foi realizado. |
| Passos 	|-Buscar em "Pesquisar datas" o seu agendamento no sistema <br> - Clicar no resultado da busca <br> - Clicar em "Atualizar Status" onde aparecerá o icone "Cancelar" no qual será solicitado o cancelamento do agendamento.|
|Critério de Êxito | - O cancelamento foi realizado com sucesso. |
| Caso de Teste 	| **CT-07 - Formulário** 	|
|	Requisito Associado 	| RF-007 - O sistema deve fornecer aos usuários a possibilidade de informar ao perfil administrativo por meio de uma TAG quaisquer informações relacionadas a avarias nos equipamentos e requisições adicionais ao software; O perfil administrativo terá uma aba de notificações com as mensagens recebidas separadas por TAGS |
| Objetivo do Teste 	| Verificar se o formulário será enviado corretamente e se a mensagem chegará na caixa de entrada do Administrador |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar em "Login" <br> - Preencher os campos obrigatórios (email e senha) <br> - Clicar em "Entrar" <br> - No canto inferior esquerdo, clicar em "AJUDA" <br> - Preencher o formulário e clicar em "Enviar" <br> - No perfil administrativo, clicar na aba de mensagens e verificar se chegou. |
|Critério de Êxito | - Sua mensagem foi enviada. |
|  	|  	|
| Caso de Teste 	| **CT-08 – Busca por datas** 	|
|Requisito Associado | RF-008	-Mecanismo de busca por datas ( ex: 20/10/2023 ) |
| Objetivo do Teste 	| Fazer uma busca de agendamento por data. |
| Passos 	| - Após selecionar seu perfil de "Administrador" ou de "Professor" <br>-Clicar em "Pesquisar datas" <br>- Selecionar a data que deseja buscar <br>-Clicar em "Buscar" <br>|
|Critério de Êxito | - O sistema retornar os agendamento feitos para a data selecionada na busca. |
|Caso de Teste  	| **CT-09 - Diferenciar Usuários** 	|
|	Requisito Associado 	| RF-009 - O sistema precisará diferenciar o usuário por meio do seu e-mail institucional  |
| Objetivo do Teste 	|  O sistema precisará diferenciar o usuário de "administrador" ou "professor" por meio do seu e-mail institucional no momento do Login |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar em "Login" <br> - Preencher os campos obrigatórios (email e senha) <br> - Clicar em "Entrar" <br> - Repetir esse processo duas vezes, sendo a primeira com o perfil de administrador e a segunda com o perfil de professor |
|Critério de Êxito | - As funcionalidades do sistema devem diferir entre os dois usuários. |
|  	|  	|
| Caso de Teste 	| **CT-10 – Restrição de agendamento** 	|
|Requisito Associado | RF-010	-O sistema irá restringir mais de 5 agendamentos semanais por usuário (professor) |
| Objetivo do Teste 	| Verificar se o mesmo usuário não excedeu o limite de 5 agendamentos semanais. |
| Passos 	| - O usuário fará a seleção de seus agendamentos semanais corretamente até a quinta solicitação, na sexta solicitação quando o usuário clicar em "salvar agendamento" aparecera uma mensagem do sistema na tela "O usuário atingiu seu limite máximo de agendamentos" |
|Critério de Êxito | - O sistema conseguir identificar com sucesso que nenhum usuário ultrapassou o limite padrão pré-determinado. |
 

