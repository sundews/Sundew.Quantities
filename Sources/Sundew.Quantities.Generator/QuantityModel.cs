// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QuantityModel.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

namespace Sundew.Quantities.Generator
{
    public class QuantityModel
    {
        public QuantityModel(string name, IReadOnlyList<UnitModel> units, string baseUnit, IReadOnlyList<string> defaultUnits, bool useGlobalUsings, IReadOnlyList<string> usings)
        {
            this.Name = name;
            this.Units = units;
            this.BaseUnit = baseUnit;
            this.DefaultUnits = defaultUnits;
            this.UseGlobalUsings = useGlobalUsings;
            this.Usings = usings;
        }

        public string Name { get; }

        public IReadOnlyList<UnitModel> Units { get; }

        public string BaseUnit { get; }

        public IReadOnlyList<string> DefaultUnits { get; }

        public bool UseGlobalUsings { get; }

        public IReadOnlyList<string> Usings { get; }
    }
}