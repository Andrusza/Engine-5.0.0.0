﻿#region License
//
// (C) Copyright 2010 Patrick Cozzi and Deron Ohlarik
//
// Distributed under the MIT License.
// See License.txt or http://www.opensource.org/licenses/mit-license.php.
//
#endregion

using Engine.Core;

namespace OpenGlobe.Renderer
{
    internal class Wgs84HeightUniform : DrawAutomaticUniform
    {
        public Wgs84HeightUniform(Uniform uniform)
        {
            _uniform = (Uniform<float>)uniform;
        }

        #region DrawAutomaticUniform Members

        public override void Set(Context context, DrawState drawState, SceneState sceneState)
        {
            _uniform.Value = 0; //ToDO
        }

        #endregion

        private Uniform<float> _uniform;
    }
}
