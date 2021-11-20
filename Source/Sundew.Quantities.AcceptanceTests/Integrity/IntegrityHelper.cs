// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IntegrityHelper.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.AcceptanceTests.Integrity;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

internal class IntegrityHelper
{
    public static IEnumerable<Type> GetDerivedTypes(Type baseType, IEnumerable<Type> excludedTypes)
    {
        return
            baseType.GetTypeInfo().Assembly.GetTypes()
                .Where(type => baseType.IsAssignableFrom(type) && type != baseType && !excludedTypes.Contains(type));
    }

    public static string GetTypes(IList<Type> incompleteTypes)
    {
        if (!incompleteTypes.Any())
        {
            return null;
        }

        var stringBuilder = new StringBuilder(incompleteTypes[0].Name);
        for (int i = 1; i < incompleteTypes.Count; i++)
        {
            stringBuilder.Append(", ");
            stringBuilder.Append(incompleteTypes[i].Name);
        }

        return stringBuilder.ToString();
    }
}