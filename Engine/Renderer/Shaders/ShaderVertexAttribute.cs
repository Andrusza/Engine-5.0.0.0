#region License

//
// (C) Copyright 2009 Patrick Cozzi and Deron Ohlarik
//
// Distributed under the MIT License.
// See License.txt or http://www.opensource.org/licenses/mit-license.php.
//

#endregion License

using OpenTK.Graphics.OpenGL4;

namespace OpenGlobe.Renderer
{
    public class ShaderVertexAttribute
    {
        public ShaderVertexAttribute(string name, int location, ActiveAttribType type, int length)
        {
            _name = name;
            _location = location;
            _type = type;
            _length = length;
        }

        public string Name
        {
            get { return _name; }
        }

        public int Location
        {
            get { return _location; }
        }

        public ActiveAttribType Datatype
        {
            get { return _type; }
        }

        public int Length
        {
            get { return _length; }
        }

        private string _name;
        private int _location;
        private ActiveAttribType _type;
        private int _length;                            // TODO:  Array type
    }
}