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

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_memory_object")]
    public abstract unsafe partial class ExtMemoryObject : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBufferStorageMemEXT")]
        public abstract void BufferStorageMem([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCreateMemoryObjectsEXT")]
        public abstract unsafe void CreateMemoryObjects([Flow(FlowDirection.In)] uint n, [Flow(FlowDirection.Out)] uint* memoryObjects);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCreateMemoryObjectsEXT")]
        public abstract void CreateMemoryObjects([Flow(FlowDirection.In)] uint n, [Flow(FlowDirection.Out)] Span<uint> memoryObjects);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDeleteMemoryObjectsEXT")]
        public abstract unsafe void DeleteMemoryObjects([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* memoryObjects);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDeleteMemoryObjectsEXT")]
        public abstract void DeleteMemoryObjects([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> memoryObjects);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMemoryObjectParameterivEXT")]
        public abstract unsafe void GetMemoryObjectParameter([Flow(FlowDirection.In)] uint memoryObject, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMemoryObjectParameterivEXT")]
        public abstract void GetMemoryObjectParameter([Flow(FlowDirection.In)] uint memoryObject, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.Out)] Span<int> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetUnsignedBytevEXT")]
        public abstract unsafe void GetUnsignedByte([Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] byte* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetUnsignedBytevEXT")]
        public abstract void GetUnsignedByte([Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out byte data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetUnsignedBytei_vEXT")]
        public abstract unsafe void GetUnsignedByte([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] byte* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetUnsignedBytei_vEXT")]
        public abstract void GetUnsignedByte([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out byte data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glIsMemoryObjectEXT")]
        public abstract bool IsMemoryObject([Flow(FlowDirection.In)] uint memoryObject);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMemoryObjectParameterivEXT")]
        public abstract unsafe void MemoryObjectParameter([Flow(FlowDirection.In)] uint memoryObject, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMemoryObjectParameterivEXT")]
        public abstract void MemoryObjectParameter([Flow(FlowDirection.In)] uint memoryObject, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] Span<int> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedBufferStorageMemEXT")]
        public abstract void NamedBufferStorageMem([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexStorageMem2DEXT")]
        public abstract void TexStorageMem2D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexStorageMem2DMultisampleEXT")]
        public abstract void TexStorageMem2DMultisample([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedSampleLocations, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexStorageMem3DEXT")]
        public abstract void TexStorageMem3D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexStorageMem3DMultisampleEXT")]
        public abstract void TexStorageMem3DMultisample([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedSampleLocations, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureStorageMem2DEXT")]
        public abstract void TextureStorageMem2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureStorageMem2DMultisampleEXT")]
        public abstract void TextureStorageMem2DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedSampleLocations, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureStorageMem3DEXT")]
        public abstract void TextureStorageMem3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureStorageMem3DMultisampleEXT")]
        public abstract void TextureStorageMem3DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedSampleLocations, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBufferStorageMemEXT")]
        public abstract void BufferStorageMem([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMemoryObjectParameterivEXT")]
        public abstract unsafe void GetMemoryObjectParameter([Flow(FlowDirection.In)] uint memoryObject, [Flow(FlowDirection.In)] MemoryObjectParameterName pname, [Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMemoryObjectParameterivEXT")]
        public abstract void GetMemoryObjectParameter([Flow(FlowDirection.In)] uint memoryObject, [Flow(FlowDirection.In)] MemoryObjectParameterName pname, [Flow(FlowDirection.Out)] Span<int> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetUnsignedBytevEXT")]
        public abstract void GetUnsignedByte([Flow(FlowDirection.In)] GetPName pname, [Flow(FlowDirection.Out)] string data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetUnsignedBytei_vEXT")]
        public abstract void GetUnsignedByte([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.Out)] string data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMemoryObjectParameterivEXT")]
        public abstract unsafe void MemoryObjectParameter([Flow(FlowDirection.In)] uint memoryObject, [Flow(FlowDirection.In)] MemoryObjectParameterName pname, [Flow(FlowDirection.In)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMemoryObjectParameterivEXT")]
        public abstract void MemoryObjectParameter([Flow(FlowDirection.In)] uint memoryObject, [Flow(FlowDirection.In)] MemoryObjectParameterName pname, [Flow(FlowDirection.In)] Span<int> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexStorageMem2DEXT")]
        public abstract void TexStorageMem2D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexStorageMem2DMultisampleEXT")]
        public abstract void TexStorageMem2DMultisample([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedSampleLocations, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexStorageMem3DEXT")]
        public abstract void TexStorageMem3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexStorageMem3DMultisampleEXT")]
        public abstract void TexStorageMem3DMultisample([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedSampleLocations, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="memory">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        public unsafe void BufferStorageMem([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset)
        {
            // IntPtrOverloader
            BufferStorageMem(target, new UIntPtr(size), memory, offset);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="memoryObjects">
        /// To be added.
        /// </param>
        public unsafe uint CreateMemoryObject()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreateMemoryObjects(n, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="memoryObjects">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        public unsafe void DeleteMemoryObject([Count(Parameter = "n"), Flow(FlowDirection.In)] uint memoryObjects)
        {
            // ArrayParameterOverloader
            DeleteMemoryObjects(1, &memoryObjects);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        public unsafe byte GetUnsignedByte([Flow(FlowDirection.In)] EXT pname)
        {
            // ReturnTypeOverloader
            byte ret = default;
            GetUnsignedByte(pname, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="memory">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        public unsafe void NamedBufferStorageMem([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset)
        {
            // IntPtrOverloader
            NamedBufferStorageMem(buffer, new UIntPtr(size), memory, offset);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="memory">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        public unsafe void BufferStorageMem([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset)
        {
            // IntPtrOverloader
            BufferStorageMem(target, new UIntPtr(size), memory, offset);
        }

        public ExtMemoryObject(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

