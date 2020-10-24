// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnitModel.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Generator
{
    public class UnitModel
    {
        public UnitModel(string identifier, string unit, string name)
        {
            this.Identifier = identifier;
            this.Unit = unit;
            this.Name = name;
        }

        public string Identifier { get; }

        public string Unit { get; }

        public string Name { get; }
    }
}