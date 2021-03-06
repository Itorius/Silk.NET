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

namespace Silk.NET.OpenGLES.Extensions.QCOM
{
    [Extension("QCOM_alpha_test")]
    public abstract unsafe partial class QComAlphaTest : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glAlphaFuncQCOM")]
        public abstract void AlphaFunc([Flow(FlowDirection.In)] QCOM func, [Flow(FlowDirection.In)] float @ref);

        public QComAlphaTest(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

