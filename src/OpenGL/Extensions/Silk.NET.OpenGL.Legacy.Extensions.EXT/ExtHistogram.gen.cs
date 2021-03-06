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
    [Extension("EXT_histogram")]
    public abstract unsafe partial class ExtHistogram : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetHistogramEXT")]
        public abstract unsafe void GetHistogram([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetHistogramEXT")]
        public abstract void GetHistogram<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetHistogramParameterfvEXT")]
        public abstract unsafe void GetHistogramParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetHistogramParameterfvEXT")]
        public abstract void GetHistogramParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetHistogramParameterivEXT")]
        public abstract unsafe void GetHistogramParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetHistogramParameterivEXT")]
        public abstract void GetHistogramParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMinmaxEXT")]
        public abstract unsafe void GetMinmax([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMinmaxEXT")]
        public abstract void GetMinmax<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMinmaxParameterfvEXT")]
        public abstract unsafe void GetMinmaxParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMinmaxParameterfvEXT")]
        public abstract void GetMinmaxParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMinmaxParameterivEXT")]
        public abstract unsafe void GetMinmaxParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMinmaxParameterivEXT")]
        public abstract void GetMinmaxParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glHistogramEXT")]
        public abstract void Histogram([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] bool sink);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMinmaxEXT")]
        public abstract void Minmax([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] bool sink);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glResetHistogramEXT")]
        public abstract void ResetHistogram([Flow(FlowDirection.In)] EXT target);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glResetMinmaxEXT")]
        public abstract void ResetMinmax([Flow(FlowDirection.In)] EXT target);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetHistogramEXT")]
        public abstract unsafe void GetHistogram([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetHistogramEXT")]
        public abstract void GetHistogram<T0>([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetHistogramParameterfvEXT")]
        public abstract unsafe void GetHistogramParameter([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetHistogramParameterfvEXT")]
        public abstract void GetHistogramParameter([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetHistogramParameterivEXT")]
        public abstract unsafe void GetHistogramParameter([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetHistogramParameterivEXT")]
        public abstract void GetHistogramParameter([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMinmaxEXT")]
        public abstract unsafe void GetMinmax([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMinmaxEXT")]
        public abstract void GetMinmax<T0>([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMinmaxParameterfvEXT")]
        public abstract unsafe void GetMinmaxParameter([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] GetMinmaxParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMinmaxParameterfvEXT")]
        public abstract void GetMinmaxParameter([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] GetMinmaxParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMinmaxParameterivEXT")]
        public abstract unsafe void GetMinmaxParameter([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] GetMinmaxParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMinmaxParameterivEXT")]
        public abstract void GetMinmaxParameter([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] GetMinmaxParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glHistogramEXT")]
        public abstract void Histogram([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] bool sink);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMinmaxEXT")]
        public abstract void Minmax([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] bool sink);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glResetHistogramEXT")]
        public abstract void ResetHistogram([Flow(FlowDirection.In)] HistogramTargetEXT target);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glResetMinmaxEXT")]
        public abstract void ResetMinmax([Flow(FlowDirection.In)] MinmaxTargetEXT target);

        public ExtHistogram(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

