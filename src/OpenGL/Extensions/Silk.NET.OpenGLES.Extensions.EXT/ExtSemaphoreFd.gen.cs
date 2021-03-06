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
    [Extension("EXT_semaphore_fd")]
    public abstract unsafe partial class ExtSemaphoreFd : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glImportSemaphoreFdEXT")]
        public abstract void ImportSemaphoreF([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] EXT handleType, [Flow(FlowDirection.In)] int fd);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glImportSemaphoreFdEXT")]
        public abstract void ImportSemaphoreF([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] ExternalHandleType handleType, [Flow(FlowDirection.In)] int fd);

        public ExtSemaphoreFd(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

