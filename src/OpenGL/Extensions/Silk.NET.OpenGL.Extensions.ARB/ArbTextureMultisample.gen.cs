// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_texture_multisample")]
    public abstract unsafe partial class ArbTextureMultisample : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMultisamplefv")]
        public abstract unsafe void GetMultisample([Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] uint index, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* val);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMultisamplefv")]
        public abstract void GetMultisample([Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] uint index, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float val);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSampleMaski")]
        public abstract void SampleMask([Flow(FlowDirection.In)] uint maskNumber, [Flow(FlowDirection.In)] uint mask);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexImage2DMultisample")]
        public abstract void TexImage2DMultisample([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexImage3DMultisample")]
        public abstract void TexImage3DMultisample([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMultisamplefv")]
        public abstract unsafe void GetMultisample([Flow(FlowDirection.In)] GetMultisamplePNameNV pname, [Flow(FlowDirection.In)] uint index, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* val);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMultisamplefv")]
        public abstract void GetMultisample([Flow(FlowDirection.In)] GetMultisamplePNameNV pname, [Flow(FlowDirection.In)] uint index, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float val);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexImage2DMultisample")]
        public abstract void TexImage2DMultisample([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexImage3DMultisample")]
        public abstract void TexImage3DMultisample([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        public ArbTextureMultisample(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

