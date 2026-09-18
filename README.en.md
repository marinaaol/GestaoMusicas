# 🎵 Music Management

A **C#** (.NET) console application created to practise Object-Oriented Programming (OOP) concepts, including classes, constructors, public fields, methods with and without return values, collections (`List<T>`), and arrays.

---

## 🚀 Project Features

The project is based on the `Musica` class and implements the following requirements:

1. **Public fields:**
   - `titulo` (text)
   - `artista` (text)
   - `duracaoSegundos` (integer)
   - `ano` (integer)

2. **Multiple constructors:**
   - An empty constructor.
   - A constructor with three parameters (`titulo`, `artista`, and `duracaoSegundos`), leaving `ano` set to `0`.
   - A complete constructor with all four fields.

3. **Main methods:**
   - `MostrarFicha()`: Prints all music details to the console.
   - `ObterDuracaoFormatada()`: Converts the total number of seconds into a readable format, such as `"3m 45s"`.
   - `AdicionarClassificacao(int nota)`: Adds a rating from `1` to `5` to the internal ratings list and validates the value.
   - `MostrarClassificacoes()`: Displays each rating using a `foreach` loop.
   - `CalcularMedia()`: Calculates and returns the average of the music ratings.
   - `MostrarGeneros()`: Displays the filled music genres from a fixed-size array.
   - `ToString()`: Overrides the default representation, returning one formatted line with the title, artist, formatted duration, and year.

4. **Playlist management (`Main`):**
   - Demonstrates object creation with each constructor.
   - Tests valid and invalid ratings.
   - Groups music objects in a `List<Musica>` named `playlist`.
   - Calculates and displays the total playlist duration in minutes and seconds.

---

## 🛠️ Technologies

- **Language:** C# (.NET)
- **Application type:** Console application, created with *Do not use top-level statements* enabled
- **Tools:** Visual Studio or VS Code, Git, and GitHub

---

## ⚙️ Running the Project

1. Make sure the **.NET SDK** is installed on your computer.
2. Clone the repository:

   ```bash
   git clone https://github.com/marinaaol/GestaoMusicas.git
   ```

3. Move into the project folder:

   ```bash
   cd GestaoMusicas
   ```

4. Run the application:

   ```bash
   dotnet run
   ```

---

## 📚 Learning Goals

This project demonstrates:

- Creating classes and objects.
- Using constructor overloading and `this`.
- Creating methods with and without return values.
- Working with `List<T>` and arrays.
- Using `foreach` and `for` loops.
- Overriding `ToString()`.
- Building and iterating over a list of objects.
