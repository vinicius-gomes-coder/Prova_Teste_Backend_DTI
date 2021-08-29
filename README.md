# Prova_Teste_Backend_DTI
Prova de teste para vaga DTI

Premissas assumidas:
  * Ao iniciar o sistema, também são iniciadas com valores as listas de clientes com suas consultas e a lista de dos grupos de alimentos
  * Assumi que os grupos de alimentos já são pré conhecidos, por isso já inicio o sistema com os grupos de alimentos e não tem opção de cadastrar mais alimentos nos grupos
  * Assumi que os dados de data serão preenchidos no formato certo

Decisões de projeto:
  * O cliente é uma classe model com nome, endereço, telefone, e-mail, data de nascimento e uma lista de consultas
  * A consulta é uma classe model com data, hora, peso, gordura corporal, sensação física, restrições alimentares
  * O alimento é uma classe model com grupo, nome e caloria
  * O grupo de alimentos é uma lista de alimentos que tem o mesmo grupo
  * A dieta é uma lista de alimentos com um alimento de cada grupo
  * As opções de dieta é uma lista de dietas
  * O método main executa um menu em loop que vai acessar todo o resto do sistema
  * Como não é necessário persistir os dados entre as execuções do sistema, os dados que precisam ser salvos durante a execução do sistema são salvos em listas

Instruções para executar o sistema:
  * Clonar o repositório e abrir o projeto com o Visual Studio e executar o projeto
