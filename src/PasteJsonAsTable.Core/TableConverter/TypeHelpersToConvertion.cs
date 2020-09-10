﻿using System;
using Newtonsoft.Json.Linq;

namespace ConvertJsonToGherkinExampleTable.Core.TableConverter
{
    public static class TypeHelpersToConvertion
    {
        public static bool IsJArray(this Type type) => type.IsAssignableFrom(typeof(JArray));

        public static bool IsJObject(this Type type) => type.IsAssignableFrom(typeof(JObject));
    }
}
