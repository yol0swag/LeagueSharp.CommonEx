﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Streams.cs" company="LeagueSharp">
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
//   Provides extensions to <see cref="System.IO.Stream" />
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace LeagueSharp.SDK.Core.Extensions
{
    using System.IO;

    /// <summary>
    ///     Provides extensions to <see cref="System.IO.Stream" />
    /// </summary>
    public static class Streams
    {
        #region Public Methods and Operators

        /// <summary>
        ///     Gets all of the bytes of the stream.
        /// </summary>
        /// <param name="stream">The Stream</param>
        /// <returns>All of the bytes of the stream.</returns>
        public static byte[] GetAllBytes(this Stream stream)
        {
            using (var memoryStream = new MemoryStream())
            {
                stream.CopyTo(memoryStream);
                return memoryStream.ToArray();
            }
        }

        #endregion
    }
}