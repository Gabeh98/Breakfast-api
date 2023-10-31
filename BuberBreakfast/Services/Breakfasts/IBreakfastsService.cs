namespace BuberBreakfast.Services.Breakfasts;

using System;
using BuberBreakfast.Models;

public interface IBreakfastsService
{
    void CreateBreakfast(Breakfast breakfast);
    Breakfast GetBreakfast(Guid id);
}