﻿#region License
//
// (C) Copyright 2010 Patrick Cozzi and Deron Ohlarik
//
// Distributed under the MIT License.
// See License.txt or http://www.opensource.org/licenses/mit-license.php.
//
#endregion

namespace Engine.Renderer
{
    internal class SunPositionUniformFactory : DrawAutomaticUniformFactory
    {
        #region DrawAutomaticUniformFactory Members

        public override string Name
        {
            get { return "og_sunPosition"; }
        }

        public override DrawAutomaticUniform Create(Uniform uniform)
        {
            return new SunPositionUniform(uniform);
        }

        #endregion
    }
}
