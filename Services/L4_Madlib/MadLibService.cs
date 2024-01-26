namespace allforone.Services.L4_Madlib;
public class MadLibService : IMadLibService
{
    public string MadLib(string noun1, string holiday1, string pronoun1, string animal1, string exclamation1, string color1, string noun2, string verb1_ing, string bluntObject1, string hours1)
    {
        return $"A {noun1} ran down the street to get to the work {holiday1} party. {pronoun1} tripped over a {animal1} and screamed, {exclamation1}! A {color1} {noun2} rushed over to help, but ended up {verb1_ing} the {noun1} with a {bluntObject1}. The {noun1} made it to the party {hours1} hours late.";
    }
}
