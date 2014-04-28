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
    internal class HighResolutionSnapScaleUniform : DrawAutomaticUniform
    {
        public HighResolutionSnapScaleUniform(Uniform uniform)
        {
            _uniform = (Uniform<float>)uniform;
        }

        #region DrawAutomaticUniform Members

        public override void Set(Context context, DrawState drawState, SceneState sceneState)
        {
            _uniform.Value = (float)sceneState.HighResolutionSnapScale;
        }

        #endregion

        private Uniform<float> _uniform;
    }
}
