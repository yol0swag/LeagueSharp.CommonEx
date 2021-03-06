﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IDrawableButton.cs" company="LeagueSharp">
//   Copyright (C) 2015 LeagueSharp
//   
//   This program is free software: you can redistribute it and/or modify
//   it under the terms of the GNU General Public License as published by
//   the Free Software Foundation, either version 3 of the License, or
//   (at your option) any later version.
//   
//   This program is distributed in the hope that it will be useful,
//   but WITHOUT ANY WARRANTY; without even the implied warranty of
//   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//   GNU General Public License for more details.
//   
//   You should have received a copy of the GNU General Public License
//   along with this program.  If not, see <http://www.gnu.org/licenses/>.
// </copyright>
// <summary>
//   Defines how to draw a Button
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace LeagueSharp.SDK.Core.UI.IMenu.Skins
{
    using LeagueSharp.SDK.Core.UI.IMenu.Values;

    using SharpDX;

    /// <summary>
    ///     Defines how to draw a Button
    /// </summary>
    public interface IDrawableButton
    {
        #region Public Methods and Operators

        /// <summary>
        ///     Calculate the Rectangle that defines the Button
        /// </summary>
        /// <param name="component">The <see cref="MenuButton"/></param>
        /// <returns>The <see cref="Rectangle" /></returns>
        Rectangle ButtonBoundaries(MenuButton component);

        /// <summary>
        ///     Draws a <see cref="MenuButton"/>
        /// </summary>
        /// <param name="component">The <see cref="MenuButton"/></param>
        void Draw(MenuButton component);

        /// <summary>
        ///     Gets the width of the MenuButton
        /// </summary>
        /// <param name="component">
        ///     The component.
        /// </param>
        /// <returns>
        ///     The <see cref="int" />.
        /// </returns>
        int Width(MenuButton component);

        #endregion
    }
}