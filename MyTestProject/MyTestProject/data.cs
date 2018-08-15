namespace MyTestProject
{
    /// <summary>
    /// five zodiac elements
    /// </summary>
    public enum Zodiac_Element
    {
        Metal = 0,
        Wood = 1,
        Water = 2,
        Fire = 3,
        Earth = 4
    }

    /// <summary>
    /// chinese zodiac animal type
    /// </summary>
    public enum Zodiac_AnimalType
    {
        Rat = 0,
        Ox = 1,
        Tiger = 2,
        Rabbit = 3,
        Dragon = 4,
        Snake = 5,
        Horse = 6,
        Sheep = 7,
        Monkey = 8,
        Rooster = 9,
        Dog = 10,
        Pig = 11
    }

    /// <summary>
    /// western counterpart of chinese zodiac animal
    /// </summary>
    public enum Zodiac_WesternCounterpart
    {
        Aries = 0,
        Taurus = 1,
        Gemini = 2,
        Cancer = 3,
        Leo = 4,
        Virgo = 5,
        Libra = 6,
        Scorpio = 7,
        Sagittarius = 8,
        Capricorn = 9,
        Aquarius = 10,
        Pisces = 11
    }

    /// <summary>
    /// user & friend data: with these, model can return various zodiac data
    /// </summary>
    public struct Zodiac_Data
    {
        string Name;
        int BirthYear;
    }
}