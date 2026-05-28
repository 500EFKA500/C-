using System;
using System.Collections.Generic;
using System.Linq;

class Validator<T>
{
    private readonly List<Predicate<T>> rules = new List<Predicate<T>>();

    public void AddRule(Predicate<T> rule)
    {
        rules.Add(rule);
    }

    public bool Validate(T item)
    {
        return rules.All(rule => rule(item));
    }
}
