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

namespace Silk.NET.OpenGL.Legacy.Extensions.APPLE
{
    [Extension("APPLE_vertex_array_object")]
    public abstract unsafe partial class AppleVertexArrayObject : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindVertexArrayAPPLE")]
        public abstract void BindVertexArray([Flow(FlowDirection.In)] uint array);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDeleteVertexArraysAPPLE")]
        public abstract unsafe void DeleteVertexArrays([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* arrays);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDeleteVertexArraysAPPLE")]
        public abstract void DeleteVertexArrays([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> arrays);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGenVertexArraysAPPLE")]
        public abstract unsafe void GenVertexArrays([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* arrays);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGenVertexArraysAPPLE")]
        public abstract void GenVertexArrays([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> arrays);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glIsVertexArrayAPPLE")]
        public abstract bool IsVertexArray([Flow(FlowDirection.In)] uint array);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="arrays">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        public unsafe void DeleteVertexArray([Count(Parameter = "n"), Flow(FlowDirection.In)] uint arrays)
        {
            // ArrayParameterOverloader
            DeleteVertexArrays(1, &arrays);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="arrays">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        public unsafe uint GenVertexArray()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenVertexArrays(n, &ret);
            return ret;
        }

        public AppleVertexArrayObject(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

