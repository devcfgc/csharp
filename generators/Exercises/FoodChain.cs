﻿using Generators.Input;

namespace Generators.Exercises
{
    public class FoodChain : Exercise
    {
        protected override void UpdateCanonicalData(CanonicalData canonicalData)
        {
            foreach (var canonicalDataCase in canonicalData.Cases)
            {
                canonicalDataCase.Expected = ConvertHelper.ToMultiLineString(canonicalDataCase.Expected);
                canonicalDataCase.UseVariableForExpected = true;
            }
        }
    }
}