#region License
//
// (C) Copyright 2009 Patrick Cozzi and Deron Ohlarik
//
// Distributed under the MIT License.
// See License.txt or http://www.opensource.org/licenses/mit-license.php.
//
#endregion

namespace Engine.Renderer.Textures
{
    public abstract class TextureUnit
    {
        public abstract Texture2D Texture { get; set; }
        public abstract TextureSampler TextureSampler { get; set; }
    }
}
