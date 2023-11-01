namespace BuberBreakfast.Services.Breakfasts;

using System;
using BuberBreakfast.Models;

public interface IBreakfastsService
{
    void CreateBreakfast(Breakfast breakfast);
    void DeleteBreakfast(Guid id);
    Breakfast GetBreakfast(Guid id);
    void UpdateBreakfast(Breakfast breakfast);
}