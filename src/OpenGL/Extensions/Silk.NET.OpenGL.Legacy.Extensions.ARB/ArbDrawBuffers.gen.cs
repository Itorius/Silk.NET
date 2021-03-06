// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_draw_buffers")]
    public abstract unsafe partial class ArbDrawBuffers : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawBuffersARB")]
        public abstract unsafe void DrawBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ARB* bufs);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawBuffersARB")]
        public abstract void DrawBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<ARB> bufs);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawBuffersARB")]
        public abstract unsafe void DrawBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] DrawBufferMode* bufs);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDrawBuffersARB")]
        public abstract void DrawBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<DrawBufferMode> bufs);

        public ArbDrawBuffers(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

