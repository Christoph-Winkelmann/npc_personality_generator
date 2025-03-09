using System;

namespace npc_generator;

public class FileHandler
{
  private const string speciesFilePath = "species.txt";
  private const string positiveTraitsFilePath = "positiveTraits.txt";
  private const string negativeTraitsFilePath = "negativeTraits.txt";
  private const string savedFilePath = "save.txt";

  public string SpeciesFilePath { get => speciesFilePath; }
  public string PositiveTraitsFilePath { get => positiveTraitsFilePath; }
  public string NegativeTraitsFilePath { get => negativeTraitsFilePath; }
  public string SavedFilePath { get => savedFilePath; }

  public string[] LoadFile(string path)
  {
    return File.ReadAllLines(path);
  }

  public void ValidateFiles()
  {
    if (!File.Exists(speciesFilePath))
    {
      throw new Exception($"File not found: {speciesFilePath}");
    }
    else if (!File.Exists(positiveTraitsFilePath))
    {
      throw new Exception($"File not found: {positiveTraitsFilePath}");
    }
    else if (!File.Exists(negativeTraitsFilePath))
    {
      throw new Exception($"File not found: {negativeTraitsFilePath}");
    }
  }

  public void SaveNpc(string npc)
  {
    if (!File.Exists(SavedFilePath))
    {
      File.Create(SavedFilePath).Dispose();
    }

    try
    {
      File.AppendAllText(SavedFilePath, npc);
    }
    catch (Exception)
    {
      System.Console.WriteLine($"Failed to write to file: {savedFilePath}");
    }
  }
}
