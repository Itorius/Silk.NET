// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

namespace Silk.NET.OpenGLES.Extensions.OES
{
    [Extension("OES_draw_buffers_indexed")]
    public abstract unsafe partial class OesDrawBuffersIndexed : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBlendEquationiOES")]
        public abstract void BlendEquation([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] OES mode);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBlendEquationSeparateiOES")]
        public abstract void BlendEquationSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] OES modeRGB, [Flow(FlowDirection.In)] OES modeAlpha);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBlendFunciOES")]
        public abstract void BlendFunc([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] OES src, [Flow(FlowDirection.In)] OES dst);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBlendFuncSeparateiOES")]
        public abstract void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] OES srcRGB, [Flow(FlowDirection.In)] OES dstRGB, [Flow(FlowDirection.In)] OES srcAlpha, [Flow(FlowDirection.In)] OES dstAlpha);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glColorMaskiOES")]
        public abstract void ColorMask([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] bool r, [Flow(FlowDirection.In)] bool g, [Flow(FlowDirection.In)] bool b, [Flow(FlowDirection.In)] bool a);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDisableiOES")]
        public abstract void Disable([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] uint index);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glEnableiOES")]
        public abstract void Enable([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] uint index);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glIsEnablediOES")]
        public abstract bool IsEnabled([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] uint index);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBlendEquationiOES")]
        public abstract void BlendEquation([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendEquationModeEXT mode);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBlendEquationSeparateiOES")]
        public abstract void BlendEquationSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendEquationModeEXT modeRGB, [Flow(FlowDirection.In)] BlendEquationModeEXT modeAlpha);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBlendFunciOES")]
        public abstract void BlendFunc([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendingFactor src, [Flow(FlowDirection.In)] BlendingFactor dst);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBlendFuncSeparateiOES")]
        public abstract void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendingFactor srcRGB, [Flow(FlowDirection.In)] BlendingFactor dstRGB, [Flow(FlowDirection.In)] BlendingFactor srcAlpha, [Flow(FlowDirection.In)] BlendingFactor dstAlpha);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDisableiOES")]
        public abstract void Disable([Flow(FlowDirection.In)] EnableCap target, [Flow(FlowDirection.In)] uint index);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glEnableiOES")]
        public abstract void Enable([Flow(FlowDirection.In)] EnableCap target, [Flow(FlowDirection.In)] uint index);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glIsEnablediOES")]
        public abstract bool IsEnabled([Flow(FlowDirection.In)] EnableCap target, [Flow(FlowDirection.In)] uint index);

        public OesDrawBuffersIndexed(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

