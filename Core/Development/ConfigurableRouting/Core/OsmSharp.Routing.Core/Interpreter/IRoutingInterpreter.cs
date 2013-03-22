﻿// OsmSharp - OpenStreetMap tools & library.
// Copyright (C) 2012 Abelshausen Ben
// 
// This file is part of OsmSharp.
// 
// OsmSharp is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 2 of the License, or
// (at your option) any later version.
// 
// OsmSharp is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with OsmSharp. If not, see <http://www.gnu.org/licenses/>.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OsmSharp.Routing.Core.Constraints;
using OsmSharp.Tools.Math.Geo;
using OsmSharp.Routing.Core.Interpreter.Roads;

namespace OsmSharp.Routing.Core.Interpreter
{
    /// <summary>
    /// Interprets routing data abstracting the type of data.
    /// </summary>
    public interface IRoutingInterpreter
    {
        /// <summary>
        /// Returns true if the given vertices can be traversed in the given order.
        /// </summary>
        /// <param name="from"></param>
        /// <param name="along"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        bool CanBeTraversed(long from, long along, long to);

        /// <summary>
        /// Returns the edge interpreter.
        /// </summary>
        IEdgeInterpreter EdgeInterpreter
        {
            get;
        }

        /// <summary>
        /// Returns the routing constraints.
        /// </summary>
        IRoutingConstraints Constraints
        {
            get;
        }
    }
}