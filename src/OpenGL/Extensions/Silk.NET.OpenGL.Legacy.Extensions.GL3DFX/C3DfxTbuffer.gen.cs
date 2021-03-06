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

namespace Silk.NET.OpenGL.Legacy.Extensions.GL3DFX
{
    [Extension("3DFX_tbuffer")]
    public abstract unsafe partial class C3DfxTbuffer : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTbufferMask3DFX")]
        public abstract void TbufferMask3Dfx([Flow(FlowDirection.In)] uint mask);

        public C3DfxTbuffer(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

