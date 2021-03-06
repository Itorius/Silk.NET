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
    [Extension("ARB_shader_storage_buffer_object")]
    public abstract unsafe partial class ArbShaderStorageBufferObject : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glShaderStorageBlockBinding")]
        public abstract void ShaderStorageBlockBinding([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint storageBlockIndex, [Flow(FlowDirection.In)] uint storageBlockBinding);

        public ArbShaderStorageBufferObject(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

