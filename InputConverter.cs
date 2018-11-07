﻿using System;

namespace Simple_Calculator
{
    internal class InputConverter
    {
        public double ToNumber(string argTextInput)
        {
            double convertedNumber;
            if (!double.TryParse(argTextInput, out convertedNumber)) throw new ArgumentException("Expected a numberic value!");
            return convertedNumber;
        }
    }
}