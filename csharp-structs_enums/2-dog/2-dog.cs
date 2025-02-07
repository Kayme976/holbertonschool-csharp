using Sytem;

struct Dog
{
    public string name;
    public float age;
    public string owner;
    public Rating rating;

    public Dog(string_name, float_age, string_owner, Rating_rating)
    {
        name = _name;
        age = _age;
        owner = _owner;
        rating = _rating;
    }
}

enum Rating
{
    Good,
    Great,
    Excellent
}