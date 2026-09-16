# 🎵 GestaoMusicas

Aplicação de consola desenvolvida em **C#** (.NET) com o objetivo de consolidar conceitos de Programação Orientada a Objetos (POO), tais como a criação de classes, construtores, encapsulamento de dados, métodos com e sem retorno, manipulação de coleções (`List<T>`) e arrays.

---

## 🚀 Funcionalidades do Projeto

O projeto baseia-se na classe `Musica` e implementa os seguintes requisitos:

1. **Campos Públicos:**
   * `titulo` (texto)
   * `artista` (texto)
   * `duracaoSegundos` (inteiro)
   * `ano` (inteiro)

2. **Construtores Múltiplos:**
   * Construtor vazio.
   * Construtor com 3 parâmetros (`titulo`, `artista`, `duracaoSegundos` — o ano assume o valor `0` por defeito).
   * Construtor completo com os 4 dados.

3. **Métodos Principais:**
   * `MostrarFicha()`: Escreve na consola todos os dados da música detalhadamente.
   * `ObterDuracaoFormatada()`: Converte os segundos totais num formato legível (ex: `"3m 45s"`).
   * `AdicionarClassificacao(int nota)`: Adiciona uma nota de `1` a `5` a uma lista interna de classificações, validando o valor inserido.
   * `MostrarClassificacoes()`: Lista todas as classificações atribuídas através de um ciclo `foreach`.
   * `CalcularMedia()`: Calcula e devolve a média inteira das classificações da música.
   * `MostrarGeneros()`: Percorre e apresenta os géneros musicais preenchidos num array de tamanho fixo.
   * `ToString()`: *Override* para retornar uma linha formatada com o título, artista, duração formatada e ano.

4. **Gestão de Playlist (`Main`):**
   * Demonstração da criação de objetos com diferentes construtores.
   * Validação de notas válidas e inválidas.
   * Agrupamento de músicas numa `List<Musica>` (`playlist`), permitindo calcular e exibir a duração total acumulada formatada em minutos e segundos.

---

## 🛠️ Tecnologias Utilizadas

* **Linguagem:** C# (.NET)
* **Ambiente de Execução:** Aplicação de Consola (com opção *Do not use top-level statements* ativada)
* **Ferramentas:** Visual Studio / VS Code, Git e GitHub

---

## ⚙️ Como Executar o Projeto

1. Certifica-te de que tens o **.NET SDK** instalado no teu computador.
2. Clona este repositório:
   ```bash
   git clone [https://github.com/teu-utilizador/GestaoMusicas.git](https://github.com/teu-utilizador/GestaoMusicas.git)