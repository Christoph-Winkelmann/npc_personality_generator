using System;

namespace npc_generator;

public class PersonalityTrait
{
  string _name;
  string _definition;
  List<string> _categories;
  List<string> _similarAttributes;
  List<string> _possibleCauses;
  List<string> _associatedBehaviours;
  List<string> _associatedThoughts;
  List<string> _associatedEmotions;
  string _positiveAspects;
  string _negativeAspects;
  string _examples;
  List<string> _conflictingTraitsInOther;
  List<string> _challengingScenarios;
}
