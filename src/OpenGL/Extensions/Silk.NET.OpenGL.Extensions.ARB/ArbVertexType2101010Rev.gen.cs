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
    [Extension("ARB_vertex_type_2_10_10_10_rev")]
    public abstract unsafe partial class ArbVertexType2101010Rev : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribP1ui")]
        public abstract void VertexAttribP1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribP1uiv")]
        public abstract unsafe void VertexAttribP1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribP1uiv")]
        public abstract void VertexAttribP1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribP2ui")]
        public abstract void VertexAttribP2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribP2uiv")]
        public abstract unsafe void VertexAttribP2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribP2uiv")]
        public abstract void VertexAttribP2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribP3ui")]
        public abstract void VertexAttribP3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribP3uiv")]
        public abstract unsafe void VertexAttribP3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribP3uiv")]
        public abstract void VertexAttribP3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribP4ui")]
        public abstract void VertexAttribP4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribP4uiv")]
        public abstract unsafe void VertexAttribP4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribP4uiv")]
        public abstract void VertexAttribP4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribP1ui")]
        public abstract void VertexAttribP1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribP1uiv")]
        public abstract unsafe void VertexAttribP1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribP1uiv")]
        public abstract void VertexAttribP1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribP2ui")]
        public abstract void VertexAttribP2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribP2uiv")]
        public abstract unsafe void VertexAttribP2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribP2uiv")]
        public abstract void VertexAttribP2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribP3ui")]
        public abstract void VertexAttribP3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribP3uiv")]
        public abstract unsafe void VertexAttribP3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribP3uiv")]
        public abstract void VertexAttribP3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribP4ui")]
        public abstract void VertexAttribP4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribP4uiv")]
        public abstract unsafe void VertexAttribP4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribP4uiv")]
        public abstract void VertexAttribP4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value);

        public ArbVertexType2101010Rev(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

