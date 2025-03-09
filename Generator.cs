using System;

namespace npc_generator;

public class Generator
{
  Random random = new Random();
  FileHandler handler = new FileHandler();
  List<string> speciesList = [];
  List<string> positiveTraitsList = [];
  List<string> negativeTraitsList = [];
  List<string> savedList = [];
  bool programRunning = true;

  public void Run()
  {
    handler.ValidateFiles();
    PopulateList(speciesList, handler.SpeciesFilePath);
    PopulateList(positiveTraitsList, handler.PositiveTraitsFilePath);
    PopulateList(negativeTraitsList, handler.NegativeTraitsFilePath);
    do
    {


      string currentNpc = NextNpc();

      do
      {
        Console.Clear();
        System.Console.WriteLine(currentNpc);
        System.Console.WriteLine("\ns: Save\nn: Next\nEsc: Quit");
        var key = Console.ReadKey(true);
        switch (key.Key)
        {
          case ConsoleKey.S:
            handler.SaveNpc(currentNpc);
            System.Console.WriteLine("NPC saved.");
            break;
          case ConsoleKey.N:
            currentNpc = NextNpc();
            break;
          case ConsoleKey.Escape:
            Environment.Exit(0);
            break;
          default:
            continue;
        }
        break;
      } while (true);


    } while (programRunning);
  }

  private void PopulateList(List<string> list, string path)
  {
    foreach (string s in handler.LoadFile(path))
    {
      list.Add(s);
    }
  }

  private string NextNpc()
  {
    // Generates the next random Npc
    string species = speciesList[random.Next(speciesList.Count)];
    string positive = positiveTraitsList[random.Next(speciesList.Count)];
    string negative = negativeTraitsList[random.Next(speciesList.Count)];
    return $"{species}\n{positive}\n{negative}\n\n";
  }
}
