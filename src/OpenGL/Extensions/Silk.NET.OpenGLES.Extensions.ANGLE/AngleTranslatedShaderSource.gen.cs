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

namespace Silk.NET.OpenGLES.Extensions.ANGLE
{
    [Extension("ANGLE_translated_shader_source")]
    public abstract unsafe partial class AngleTranslatedShaderSource : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTranslatedShaderSourceANGLE")]
        public abstract unsafe void GetTranslatedShaderSource([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Flow(FlowDirection.Out)] char* source);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTranslatedShaderSourceANGLE")]
        public abstract void GetTranslatedShaderSource([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Flow(FlowDirection.Out)] Span<char> source);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTranslatedShaderSourceANGLE")]
        public abstract unsafe void GetTranslatedShaderSource([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Flow(FlowDirection.Out)] string source);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTranslatedShaderSourceANGLE")]
        public abstract void GetTranslatedShaderSource([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Flow(FlowDirection.Out)] string source);

        public AngleTranslatedShaderSource(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

