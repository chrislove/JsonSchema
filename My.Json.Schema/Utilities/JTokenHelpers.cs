﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace My.Json.Schema.Utilities
{
    internal static class JTokenHelpers
    {

        public static bool IsString(this JToken t)
        {
            return (t.Type == JTokenType.Undefined
                    || t.Type == JTokenType.Null
                    || t.Type == JTokenType.String);
        }

        public static JToken GetRootParent(this JToken token)
        {
            while (token.Parent != null)
                token = token.Parent;
            return token;
        }
    }
}
