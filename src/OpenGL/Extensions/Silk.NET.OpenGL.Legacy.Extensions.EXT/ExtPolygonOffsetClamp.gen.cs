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
    [Extension("EXT_polygon_offset_clamp")]
    public abstract unsafe partial class ExtPolygonOffsetClamp : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPolygonOffsetClampEXT")]
        public abstract void PolygonOffsetClamp([Flow(FlowDirection.In)] float factor, [Flow(FlowDirection.In)] float units, [Flow(FlowDirection.In)] float clamp);

        public ExtPolygonOffsetClamp(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

