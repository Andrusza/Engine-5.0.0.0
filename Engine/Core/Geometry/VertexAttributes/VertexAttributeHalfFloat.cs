﻿#region License
//
// (C) Copyright 2009 Patrick Cozzi and Deron Ohlarik
//
// Distributed under the MIT License.
// See License.txt or http://www.opensource.org/licenses/mit-license.php.
//
#endregion

using Engine.Core;
namespace Engine.Core
{
    public class VertexAttributeHalfFloat : VertexAttribute<Half>
    {
        public VertexAttributeHalfFloat(string name)
            : base(name, VertexAttributeType.HalfFloat)
        {
        }

        public VertexAttributeHalfFloat(string name, int capacity)
            : base(name, VertexAttributeType.HalfFloat, capacity)
        {
        }
    }
}
