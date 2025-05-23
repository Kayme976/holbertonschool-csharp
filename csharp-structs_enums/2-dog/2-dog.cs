﻿using System;

struct Dog
{
    public string name;
    public float age;
    public string owner;
    public Rating rating;

    public Dog(string _name, float _age, string _owner, Rating _rating)
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