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
    [Extension("ARB_shader_subroutine")]
    public abstract unsafe partial class ArbShaderSubroutine : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetActiveSubroutineName")]
        public abstract unsafe void GetActiveSubroutineName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] char* name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetActiveSubroutineName")]
        public abstract void GetActiveSubroutineName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<char> name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformiv")]
        public abstract unsafe void GetActiveSubroutineUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* values);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformiv")]
        public abstract void GetActiveSubroutineUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int values);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformName")]
        public abstract unsafe void GetActiveSubroutineUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] char* name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformName")]
        public abstract void GetActiveSubroutineUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<char> name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetProgramStageiv")]
        public abstract unsafe void GetProgramStage([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] ARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* values);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetProgramStageiv")]
        public abstract void GetProgramStage([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] ARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int values);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetSubroutineIndex")]
        public abstract unsafe uint GetSubroutineIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] char* name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetSubroutineIndex")]
        public abstract uint GetSubroutineIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] Span<char> name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetSubroutineUniformLocation")]
        public abstract unsafe int GetSubroutineUniformLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] char* name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetSubroutineUniformLocation")]
        public abstract int GetSubroutineUniformLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] Span<char> name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetUniformSubroutineuiv")]
        public abstract unsafe void GetUniformSubroutine([Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] int location, [Count(Count = 1), Flow(FlowDirection.Out)] uint* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetUniformSubroutineuiv")]
        public abstract void GetUniformSubroutine([Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] int location, [Count(Count = 1), Flow(FlowDirection.Out)] out uint @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformSubroutinesuiv")]
        public abstract unsafe void UniformSubroutines([Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* indices);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformSubroutinesuiv")]
        public abstract void UniformSubroutines([Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> indices);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetActiveSubroutineName")]
        public abstract unsafe void GetActiveSubroutineName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetActiveSubroutineName")]
        public abstract void GetActiveSubroutineName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformiv")]
        public abstract unsafe void GetActiveSubroutineUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] SubroutineParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* values);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformiv")]
        public abstract void GetActiveSubroutineUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] SubroutineParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int values);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformName")]
        public abstract unsafe void GetActiveSubroutineUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformName")]
        public abstract void GetActiveSubroutineUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetProgramStageiv")]
        public abstract unsafe void GetProgramStage([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] ProgramStagePName pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* values);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetProgramStageiv")]
        public abstract void GetProgramStage([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] ProgramStagePName pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int values);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetSubroutineIndex")]
        public abstract uint GetSubroutineIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] string name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetSubroutineUniformLocation")]
        public abstract int GetSubroutineUniformLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] string name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetUniformSubroutineuiv")]
        public abstract unsafe void GetUniformSubroutine([Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] int location, [Count(Count = 1), Flow(FlowDirection.Out)] uint* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetUniformSubroutineuiv")]
        public abstract void GetUniformSubroutine([Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] int location, [Count(Count = 1), Flow(FlowDirection.Out)] out uint @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformSubroutinesuiv")]
        public abstract unsafe void UniformSubroutines([Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* indices);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformSubroutinesuiv")]
        public abstract void UniformSubroutines([Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> indices);

        public ArbShaderSubroutine(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

