using Atividade3.Menus;
using Atividade3.Modelos;

Perguntas pergunta1 = new("Qual é o maior planeta do sistema solar?\n1- Terra\n2- Júpiter\n3- Marte\n4- Saturno\n", 2);
Perguntas pergunta2 = new("\nQuem escreveu o livro 'Dom Quixote'?\n1- William Shakespeare\n2- GabrielGarcía Márquez\n3- Miguel de Cervantes\n4- Jorge Luis Borges", 3);
Perguntas pergunta3 = new("\nQual elemento químico tem o símbolo 'O' na tabela periódica?\n1- Ouro\n2- Oxigênio\n3- Ósmio\n4- Óxido", 2);
Perguntas pergunta4 = new("\nQual é o valor de π (pi) aproximado com duas casas decimais?\n1- 3,12\n2- 3,14\n3- 3,16\n4- 3,18", 2);
Perguntas pergunta5 = new("Em que ano o homem pisou na Lua pela primeira vez?\n1- 1965\n2- 1967\n3- 1969\n4- 1971", 3);

Dictionary<string, Perguntas> questoes = new();
questoes.Add(pergunta1.Pergunta, pergunta1);
questoes.Add(pergunta2.Pergunta, pergunta2);
questoes.Add(pergunta3.Pergunta, pergunta3);
questoes.Add(pergunta4.Pergunta, pergunta4);
questoes.Add(pergunta5.Pergunta, pergunta5);

Menu quiz = new MenuExecutar();
quiz.Executar(questoes);