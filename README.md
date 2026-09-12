# Roguelike em C#

Projeto educacional de um jogo Roguelike desenvolvido para praticar C#, .NET e conceitos de Engenharia de Software.

## Objetivo

Construir um jogo por turnos com geração de mapas, movimentação, combate e comportamentos de inimigos, aplicando boas práticas de arquitetura e testes automatizados.

## Tecnologias utilizadas

- C#
- .NET 10
- Git
- xUnit

## Tecnologias planejadas

- SadConsole
- RogueSharp

## Estado do projeto

🚧 Em desenvolvimento, com um protótipo no console e testes automatizados para as regras atuais do jogador.

Os próximos objetivos são implementar geração de mapas, movimentação, combate por turnos e comportamentos de inimigos.

## Funcionalidades implementadas

- **Jogador:** reúne nome, vida e ataque do personagem.
- **Recebimento de dano:** desconta danos positivos da vida, desconsidera valores zero ou negativos e limita a vida restante a zero.
- **Estado `IsAlive`:** retorna `true` quando o jogador tem vida e `false` quando ela chega a zero.
- **Simulação no console:** mostra os efeitos dos danos recebidos e encerra a sequência quando o jogador é derrotado.
- **Testes unitários com xUnit:** verificam as regras de dano, o limite mínimo de vida e o estado de derrota.

## Aprendizados

- Organização de solutions e projects no .NET
- Processo de build e execução
- Versionamento com Git
- Commits pequenos e descritivos
