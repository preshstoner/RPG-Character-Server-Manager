# RPG Character & Server Manager 🎮⚔️

A C# console application designed to demonstrate the fundamental differences between **static scopes** and **instance scopes**, helping developers understand and resolve the common **CS0120** error (`An object reference is required for the non-static field, method, or property`).

---

## 🌟 Key Concepts Demonstrated

* **Static Scope (`GameSettings`):** 
  * Features static properties (`ServerName`) and static utility methods (`CalculateGlobalDamage`).
  * Can be called directly from the class name (`GameSettings.ServerName`) without needing to create an object instance.
* **Instance Scope (`PlayerCharacter`):** 
  * Features unique instance properties (`CharacterName`, `Health`) and behavior (`TakeDamage`).
  * Requires explicit object instantiation (`PlayerCharacter p = new PlayerCharacter();`) to access them within a static method like `Main`.
* **Avoiding CS0120 Errors:** Shows the precise syntax for how to transition safely from a static context (`Main`) to non-static object references.

---

## 📂 Project Structure

* **`GameSettings`**: A static class housing global server constants and shared utility calculations.
* **`PlayerCharacter`**: An instance blueprint defining individual player data and states.
* **`Program`**: The execution entry point containing the `Main` method demonstrating static vs. instance invocation rules.

---

## 🚀 Getting Started

### Prerequisites
* [.NET 8.0 SDK or higher](https://dotnet.microsoft.com/)

### Running the Application
1. Clone the repository and navigate into the project folder.
2. Run the application using the .NET CLI:
   ```powershell
   dotnet run
