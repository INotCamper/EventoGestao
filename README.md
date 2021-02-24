# EventoGestao :atm:

Uma solução para organizar um treinamento, com sistemas de cadastro de salas e pessoas, e procura das mesmas.

## O que esperar :thinking:

Uma interface segregada em cadastro de cada item, uma seção para organizar o evento e por último uma maneira de consultar cada item adicionado (pessoas, salas e espaços).
Também foi feita a persistência de dados via arquivo JSON (é um bom formato para caso precise modificar algo:+1:).
O evento é formado em duas fases/etapas, onde na primeira o grupo de pessoas é separado para cada sala, mas na segunda etapa é criada a mesma sala de pessoas, mas metade dessa sala será colocada na próxima sala, e quando todas salas acabarem, a primeira sala recebe as pessoas da última sala.

## Como usar :question:

1. Baixe o repositório (vou usar zip como exemplo).
2. Descompacte a pasta em algum lugar.
3. Abra a pasta e execute EventoGestao.sln
4. Espere o Visual Studio abrir.
5. Logo que ele abrir você pode apertar o botão Start em cima, ou apertar F5 para executar o programa.
6. O Visual Studio irá buildar a solução e logo após a interface irá aparecer.

Assim que você tiver o programa aberto haverá um menu na esquerda com os itens
- Cadastro
  - Pessoa: Cadastra uma pessoa com nome e sobrenome.
  - Sala de Evento: Cadastra uma sala de evento com nome e lotação.
  - Espaço de Café: Cadastra um espaço de café com nome e lotação.
- Organizar: Organiza o evento com as pessoas criadas, salas de evento e espaços de café.
- Consulta
  - Pessoa: Procura uma pessoa com base no nome e sobrenome.
  - Sala de Evento: Procura uma sala de evento com base no nome.
  - Espaço de Café: Procura um espaço de café com base no nome.

Quando você querer criar um treinamento:
1. Adicione cada pessoa.
2. Adicione cada sala.
3. Adicione cada espaço.
4. Organize o evento.
5. Agora com o evento organizado você pode:
  - Consultar as salas você terá uma lista de pessoas que estão nessa sala em cada etapa.
  - Consultar os espaços e também haverá uma lista de pessoas em cada etapa.
  - Consultar cada pessoa e você terá cada sala que essa pessoa irá ficar em cada etapa (Etapa 1: uma sala e um espaço, Etapa 2: uma sala e um espaço)

## Onde ficam os arquivos :question:

:warning: **Editar os aqruivos pode causar erros não esperados** :warning:
Caso você queira editar os arquivos JSON eles são criados nessa pasta:
```
EventoGestao\bin\Debug
```
Você pode excluir esses arquivos caso queira criar um treinamento novo com outras pessoas, salas e espaços.
