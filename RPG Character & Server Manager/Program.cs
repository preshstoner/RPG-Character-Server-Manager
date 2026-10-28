using System;

// 1. Global Configuration and Utilities (Static Scope)
public static class GameSettings
{
    // Static property: Shared globally across the entire program
    public static string ServerName = "Alpha-Mainfram-01";
    public static int MaxLevel = 99;

    // Static method: Utility function that doesn't rely on indivdual player data
    public static int CalculateGlobalDamage(int baseAttack, int armorRating)
    {
        int finalDamage = baseAttack - (armorRating / 2);
        return finalDamage > 0 ? finalDamage : 1;
    }
}

// 2. Individual Player Blueprint (Instance Scope)
public class PlayerCharacter
{
    // Instance properties: Every player object has it's own unique name and health
    public string CharacterName { get; set; } = "Unknown Hero";
    public int Health { get; set; } = 100;

    // Instance method: Operates on a specific player's data
    public void TakeDamage(int amount)
    {
        Health -= amount;
        Console.WriteLine($"⚔️ [{CharacterName}] took {amount} damage! Remaining Health: {Health}");
    }
}

// 3. Program Execution
class Program
{
    public static void Main(string[] args)
    {
        // ------------------------------------------------------------
        // PART A: Using Static Members Directly (No object required)
        // ------------------------------------------------------------
        Console.WriteLine($"--- Connecting to {GameSettings.ServerName} ---");
        Console.WriteLine($"Server Max Level Cap: {GameSettings.MaxLevel}");

        // Using a static utility method directly from the class name
        int calculatedDmg = GameSettings.CalculateGlobalDamage(40, 10);
        Console.WriteLine($"Global calculated hit damage: {calculatedDmg}\n");

        // --------------------------------------------------------
        // PART B: Avoiding the CS0120 Error with Instance Members
        // --------------------------------------------------------
        // ❌ IF YOU TRIED THIS:
        // Console.WriteLine(CharacterName); //CS0120 Error!
        // TakeDamage(15);
        // Reason: Main is static, but CharacterName and TakeDamage belong to an instance.

        // ✔️ THE SOLUTION: Explicitly create Object instances using 'new
        Console.WriteLine("--- Spawning Players (Objects) ---");

        PlayerCharacter player1 = new PlayerCharacter();
        player1.CharacterName = "Aragorn";

        PlayerCharacter player2 = new PlayerCharacter();
        player2.CharacterName = "Legolas";

        // Now we can safely utilize the instance methods and properties via their objects
        player1.TakeDamage(calculatedDmg);
        player2.TakeDamage(20);

        // Verify that each object maintains it's own independent state
        Console.WriteLine($"\nFinal Status -> {player1.CharacterName} HP: {player1.Health} | {player2.CharacterName} HP: {player2.Health}");

    }
}
