﻿#region License
//
// (C) Copyright 2009 Patrick Cozzi and Deron Ohlarik
//
// Distributed under the MIT License.
// See License.txt or http://www.opensource.org/licenses/mit-license.php.
//
#endregion

namespace Engine.Renderer
{
    public abstract class DrawAutomaticUniform
    {
        public abstract void Set(Context context, DrawState drawState, SceneState sceneState);
    }
}
