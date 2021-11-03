﻿using System;

namespace Aula217ExtensionMethodsDemo2.Extensions
{
    static class StringExtensions
    {
        public static string Cut(this String thisObj, int count)
        {
            if (thisObj.Length < count)
            {
                return thisObj;
            }
            else
            {
                return $"{thisObj.Substring(0, count)}...";
            }
        }
    }
}
