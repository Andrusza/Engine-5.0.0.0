using OpenEngine.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenEngine.GL
{
    public class MouseGL : Mouse
    {
        private OpenTK.Input.MouseDevice mouseDevice;

        public MouseGL(OpenTK.Input.MouseDevice mouseDevice)
        {
            // TODO: Complete member initialization
            this.mouseDevice = mouseDevice;
        }
    }
}
