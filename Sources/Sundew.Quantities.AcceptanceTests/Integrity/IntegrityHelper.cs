// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="IntegrityHelper.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.AcceptanceTests.Integrity
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    internal class IntegrityHelper
    {
        public static IEnumerable<Type> GetDerivedTypes(Type baseType, IEnumerable<Type> excludedTypes)
        {
            return
                baseType.Assembly.GetTypes()
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
}