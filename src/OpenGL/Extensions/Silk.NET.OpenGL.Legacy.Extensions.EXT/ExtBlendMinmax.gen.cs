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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_blend_minmax")]
    public abstract unsafe partial class ExtBlendMinmax : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBlendEquationEXT")]
        public abstract void BlendEquation([Flow(FlowDirection.In)] EXT mode);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBlendEquationEXT")]
        public abstract void BlendEquation([Flow(FlowDirection.In)] BlendEquationModeEXT mode);

        public ExtBlendMinmax(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

