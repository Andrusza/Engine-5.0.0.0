#region License
//
// (C) Copyright 2010 Patrick Cozzi and Deron Ohlarik
//
// Distributed under the MIT License.
// See License.txt or http://www.opensource.org/licenses/mit-license.php.
//
#endregion

using Engine.Core;
using OpenTK.Graphics.OpenGL4;

namespace OpenGlobe.Renderer
{
    public enum SynchronizationStatus
    {
        Unsignaled,
        Signaled
    }

    //public enum WaitSyncStatus
    //{
    //    AlreadySignaled,
    //    Signaled,
    //    TimeoutExpired
    //}

    public abstract class Fence : Disposable
    {
        public abstract void ServerWait();
        public abstract WaitSyncStatus ClientWait();
        public abstract WaitSyncStatus ClientWait(int timeoutInNanoseconds);
        public abstract SynchronizationStatus Status();
    }
}
