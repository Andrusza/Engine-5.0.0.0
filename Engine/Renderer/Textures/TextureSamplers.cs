#region License
//
// (C) Copyright 2010 Patrick Cozzi and Kevin Ring
//
// Distributed under the MIT License.
// See License.txt or http://www.opensource.org/licenses/mit-license.php.
//
#endregion

using System;
using System.Globalization;
using OpenTK.Graphics.OpenGL4;

namespace OpenGlobe.Renderer
{
    public class TextureSamplers
    {
        internal TextureSamplers ()
	    {
            _nearestClamp = Device.CreateTexture2DSampler(
                    TextureMinFilter.Nearest,
                    TextureMagFilter.Nearest,
                    TextureWrapMode.ClampToBorder,
                    TextureWrapMode.ClampToBorder);

            _linearClamp = Device.CreateTexture2DSampler(
                    TextureMinFilter.Linear,
                    TextureMagFilter.Linear,
                    TextureWrapMode.ClampToBorder,
                    TextureWrapMode.ClampToBorder);

            _nearestRepeat = Device.CreateTexture2DSampler(
                    TextureMinFilter.Nearest,
                    TextureMagFilter.Nearest,
                    TextureWrapMode.Repeat,
                    TextureWrapMode.Repeat);

            _linearRepeat = Device.CreateTexture2DSampler(
                    TextureMinFilter.Linear,
                    TextureMagFilter.Linear,
                    TextureWrapMode.Repeat,
                    TextureWrapMode.Repeat);
	    }

        public TextureSampler NearestClamp
        {
            get { return _nearestClamp;  }
        }
        
        public TextureSampler LinearClamp
        {
            get { return _linearClamp;  }
        }

        public TextureSampler NearestRepeat
        {
            get { return _nearestRepeat;  }
        }

        public TextureSampler LinearRepeat
        {
            get { return _linearRepeat;  }
        }

        private readonly TextureSampler _nearestClamp;
        private readonly TextureSampler _linearClamp;
        private readonly TextureSampler _nearestRepeat;
        private readonly TextureSampler _linearRepeat;
    }
}
