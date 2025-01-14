﻿using System.Text.Json;

namespace Devon4Net.Infrastructure.Extensions.Helpers
{
    public interface IJsonHelper
    {
        Task<string> Serialize<T>(T input);
        string Serialize(object toPrint, bool useCamelCase = false);
        T Deserialize<T>(string input, bool useCamelCase = false);
    }
}