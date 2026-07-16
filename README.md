# XO Game (Tic-Tac-Toe) 🎮

A classic Tic-Tac-Toe game built from scratch in **C# / Windows Forms**, created as a hands-on project to learn the fundamentals of C# programming, object-oriented design, and desktop UI development.

> Two players, one board, nine squares, and a race to three in a row.

---

## 📸 Screenshots

<!-- Replace these placeholders with real screenshots of your game -->
| Game Board | Win State |
|---|---|
| ![Game board placeholder](<img width="1295" height="758" alt="Screenshot 2026-07-16 171045" src="https://github.com/user-attachments/assets/9629c08c-4415-4367-bdf5-8c0e886d2693" />
) | ![Win state placeholder](<img width="1296" height="760" alt="Screenshot 2026-07-16 171111" src="https://github.com/user-attachments/assets/b5f9ac0d-f011-4c0d-8ec1-c32f58221a8b" />
) |

---

## ✨ Features

- 🎯 **Classic 2-player Tic-Tac-Toe** on a 3x3 grid
- 🔄 **Turn tracking** with a live "current player" label
- 🏆 **Automatic win detection** across all rows, columns, and both diagonals
- 🎨 **Visual win highlight** — the winning line lights up when a player wins
- 🤝 **Draw detection** when the board fills up with no winner
- 🔁 **One-click restart** to reset the board and play again
- 🖌️ **Custom UI** with hand-picked graphics for X, O, and the board grid

---

## 🛠️ Technologies Used

- **Language:** C#
- **Framework:** .NET Framework 4.7.2
- **UI Toolkit:** Windows Forms (WinForms)
- **IDE:** Visual Studio

---

## 🚀 How to Run

### Option 1 — Run the compiled build
1. Download or clone this repository.
2. Navigate to `bin/Debug/`.
3. Run `XO_Game.exe`.

### Option 2 — Build it yourself
1. Clone the repository:
   ```bash
   git clone https://github.com/<your-username>/XO_Game.git
   ```
2. Open `XO_Game.sln` in **Visual Studio**.
3. Press **F5** (or click *Start*) to build and run the project.

> Requires Visual Studio with the **.NET desktop development** workload installed.

---

## 🎮 How to Play

1. Player 1 (**X**) and Player 2 (**O**) take turns clicking empty squares on the board.
2. The current turn is shown at the top of the window.
3. The first player to line up three of their marks — horizontally, vertically, or diagonally — wins.
4. If all nine squares fill up with no winner, the game ends in a draw.
5. Click **Restart Game** to reset the board and play again.

---

## 📚 What I Learned

Building this project helped me practice and understand:

- **Windows Forms fundamentals** — working with `Button`, `Label`, event handlers, and the WinForms designer
- **Object-oriented basics in C#** — using `enum`s to represent game state (players, winner status) and a `struct` to group related state together
- **Control state via the `Tag` property** — storing custom per-control data instead of a separate tracking array
- **Writing reusable methods** — building a single `CheckValues()` method and calling it for every row, column, and diagonal instead of duplicating win-check logic 8 times
- **Custom drawing with GDI+** — overriding `Paint` and using `Graphics`/`Pen` to draw the board grid manually
- **Debugging real logic bugs** — tracking down an edge case where winning on the final move could incorrectly get overwritten by the draw-check logic
- **The value of separating game logic from UI code** — a lesson I'm carrying into my next project, where I plan to decouple the game engine from the Form so it's testable on its own

---

## 🔮 Possible Future Improvements

- [ ] Separate game logic into its own class (no `Button` dependency), enabling unit tests
- [ ] Add a single-player mode vs. a simple AI opponent
- [ ] Track and display a running score across multiple rounds
- [ ] Make the board resizable / responsive
- [ ] Port the same game logic to a console or WPF version

---

## 📄 License

This project is open source and available under the [MIT License](LICENSE).

---

### 🙋 About This Project

This is a **beginner learning project** built to strengthen my understanding of C# and Windows Forms fundamentals — event-driven programming, state management, and building a complete, working application from an empty solution. Feedback and suggestions are always welcome!
