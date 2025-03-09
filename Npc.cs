using System;

namespace npc_generator;

public class Npc
{
  // Fields
  string _species = "";
  List<string> _positiveTraits = [];
  List<string> _negativeTraits = [];


  // Properties
  public string Species { get => _species; set => _species = value; }
  public List<string> PositiveTraits { get => _positiveTraits; set => _positiveTraits = value; }
  public List<string> NegativeTraits { get => _negativeTraits; set => _negativeTraits = value; }


  // Constructor
  public Npc(string species, List<string> positiveTraits, List<string> negativeTraits)
  {
    Species = species;
    PositiveTraits = positiveTraits;
    NegativeTraits = negativeTraits;
  }
}
