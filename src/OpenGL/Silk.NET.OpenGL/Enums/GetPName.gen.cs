// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

namespace Silk.NET.OpenGL
{
    public enum GetPName
    {
        PointSize = 0xB11,
        PointSizeRange = 0xB12,
        SmoothPointSizeRange = 0xB12,
        PointSizeGranularity = 0xB13,
        SmoothPointSizeGranularity = 0xB13,
        LineSmooth = 0xB20,
        LineWidth = 0xB21,
        LineWidthRange = 0xB22,
        SmoothLineWidthRange = 0xB22,
        LineWidthGranularity = 0xB23,
        SmoothLineWidthGranularity = 0xB23,
        PolygonMode = 0xB40,
        PolygonSmooth = 0xB41,
        CullFace = 0xB44,
        CullFaceMode = 0xB45,
        FrontFace = 0xB46,
        DepthRange = 0xB70,
        DepthTest = 0xB71,
        DepthWritemask = 0xB72,
        DepthClearValue = 0xB73,
        DepthFunc = 0xB74,
        StencilTest = 0xB90,
        StencilClearValue = 0xB91,
        StencilFunc = 0xB92,
        StencilValueMask = 0xB93,
        StencilFail = 0xB94,
        StencilPassDepthFail = 0xB95,
        StencilPassDepthPass = 0xB96,
        StencilRef = 0xB97,
        StencilWritemask = 0xB98,
        Viewport = 0xBA2,
        Modelview0StackDepthExt = 0xBA3,
        Modelview0MatrixExt = 0xBA6,
        AlphaTestQCom = 0xBC0,
        AlphaTestFuncQCom = 0xBC1,
        AlphaTestRefQCom = 0xBC2,
        Dither = 0xBD0,
        BlendDst = 0xBE0,
        BlendSrc = 0xBE1,
        Blend = 0xBE2,
        LogicOpMode = 0xBF0,
        ColorLogicOp = 0xBF2,
        DrawBuffer = 0xC01,
        DrawBufferExt = 0xC01,
        ReadBuffer = 0xC02,
        ReadBufferExt = 0xC02,
        ReadBufferNV = 0xC02,
        ScissorBox = 0xC10,
        ScissorTest = 0xC11,
        ColorClearValue = 0xC22,
        ColorWritemask = 0xC23,
        Doublebuffer = 0xC32,
        Stereo = 0xC33,
        LineSmoothHint = 0xC52,
        PolygonSmoothHint = 0xC53,
        UnpackSwapBytes = 0xCF0,
        UnpackLsbFirst = 0xCF1,
        UnpackRowLength = 0xCF2,
        UnpackSkipRows = 0xCF3,
        UnpackSkipPixels = 0xCF4,
        UnpackAlignment = 0xCF5,
        PackSwapBytes = 0xD00,
        PackLsbFirst = 0xD01,
        PackRowLength = 0xD02,
        PackSkipRows = 0xD03,
        PackSkipPixels = 0xD04,
        PackAlignment = 0xD05,
        MaxClipDistances = 0xD32,
        MaxTextureSize = 0xD33,
        MaxViewportDims = 0xD3A,
        SubpixelBits = 0xD50,
        Texture1D = 0xDE0,
        Texture2D = 0xDE1,
        PolygonOffsetUnits = 0x2A00,
        PolygonOffsetPoint = 0x2A01,
        PolygonOffsetLine = 0x2A02,
        BlendColor = 0x8005,
        BlendColorExt = 0x8005,
        BlendEquationExt = 0x8009,
        BlendEquationRgb = 0x8009,
        PackCmykHintExt = 0x800E,
        UnpackCmykHintExt = 0x800F,
        Convolution1DExt = 0x8010,
        Convolution2DExt = 0x8011,
        Separable2DExt = 0x8012,
        PostConvolutionRedScaleExt = 0x801C,
        PostConvolutionGreenScaleExt = 0x801D,
        PostConvolutionBlueScaleExt = 0x801E,
        PostConvolutionAlphaScaleExt = 0x801F,
        PostConvolutionRedBiasExt = 0x8020,
        PostConvolutionGreenBiasExt = 0x8021,
        PostConvolutionBlueBiasExt = 0x8022,
        PostConvolutionAlphaBiasExt = 0x8023,
        HistogramExt = 0x8024,
        MinmaxExt = 0x802E,
        PolygonOffsetFill = 0x8037,
        PolygonOffsetFactor = 0x8038,
        PolygonOffsetBiasExt = 0x8039,
        RescaleNormalExt = 0x803A,
        TextureBinding1D = 0x8068,
        TextureBinding2D = 0x8069,
        Texture3DBindingExt = 0x806A,
        TextureBinding3D = 0x806A,
        PackSkipImages = 0x806B,
        PackSkipImagesExt = 0x806B,
        PackImageHeight = 0x806C,
        PackImageHeightExt = 0x806C,
        UnpackSkipImages = 0x806D,
        UnpackSkipImagesExt = 0x806D,
        UnpackImageHeight = 0x806E,
        UnpackImageHeightExt = 0x806E,
        Texture3DExt = 0x806F,
        Max3DTextureSize = 0x8073,
        Max3DTextureSizeExt = 0x8073,
        VertexArrayCountExt = 0x807D,
        NormalArrayCountExt = 0x8080,
        ColorArrayCountExt = 0x8084,
        IndexArrayCountExt = 0x8087,
        TextureCoordArrayCountExt = 0x808B,
        EdgeFlagArrayCountExt = 0x808D,
        InterlaceSgix = 0x8094,
        DetailTexture2DBindingSgis = 0x8096,
        MultisampleSgis = 0x809D,
        SampleAlphaToMaskSgis = 0x809E,
        SampleAlphaToOneSgis = 0x809F,
        SampleMaskSgis = 0x80A0,
        SampleBuffers = 0x80A8,
        SampleBuffersSgis = 0x80A8,
        Samples = 0x80A9,
        SamplesSgis = 0x80A9,
        SampleCoverageValue = 0x80AA,
        SampleMaskValueSgis = 0x80AA,
        SampleCoverageInvert = 0x80AB,
        SampleMaskInvertSgis = 0x80AB,
        SamplePatternSgis = 0x80AC,
        ColorMatrixSgi = 0x80B1,
        ColorMatrixStackDepthSgi = 0x80B2,
        MaxColorMatrixStackDepthSgi = 0x80B3,
        PostColorMatrixRedScaleSgi = 0x80B4,
        PostColorMatrixGreenScaleSgi = 0x80B5,
        PostColorMatrixBlueScaleSgi = 0x80B6,
        PostColorMatrixAlphaScaleSgi = 0x80B7,
        PostColorMatrixRedBiasSgi = 0x80B8,
        PostColorMatrixGreenBiasSgi = 0x80B9,
        PostColorMatrixBlueBiasSgi = 0x80BA,
        PostColorMatrixAlphaBiasSgi = 0x80BB,
        TextureColorTableSgi = 0x80BC,
        BlendDstRgb = 0x80C8,
        BlendSrcRgb = 0x80C9,
        BlendDstAlpha = 0x80CA,
        BlendSrcAlpha = 0x80CB,
        ColorTableSgi = 0x80D0,
        PostConvolutionColorTableSgi = 0x80D1,
        PostColorMatrixColorTableSgi = 0x80D2,
        MaxElementsVertices = 0x80E8,
        MaxElementsIndices = 0x80E9,
        PointSizeMinSgis = 0x8126,
        PointSizeMaxSgis = 0x8127,
        PointFadeThresholdSize = 0x8128,
        PointFadeThresholdSizeSgis = 0x8128,
        DistanceAttenuationSgis = 0x8129,
        FogFuncPointsSgis = 0x812B,
        MaxFogFuncPointsSgis = 0x812C,
        PackSkipVolumesSgis = 0x8130,
        PackImageDepthSgis = 0x8131,
        UnpackSkipVolumesSgis = 0x8132,
        UnpackImageDepthSgis = 0x8133,
        Texture4DSgis = 0x8134,
        Max4DTextureSizeSgis = 0x8138,
        PixelTexGenSgix = 0x8139,
        PixelTileBestAlignmentSgix = 0x813E,
        PixelTileCacheIncrementSgix = 0x813F,
        PixelTileWidthSgix = 0x8140,
        PixelTileHeightSgix = 0x8141,
        PixelTileGridWidthSgix = 0x8142,
        PixelTileGridHeightSgix = 0x8143,
        PixelTileGridDepthSgix = 0x8144,
        PixelTileCacheSizeSgix = 0x8145,
        SpriteSgix = 0x8148,
        SpriteModeSgix = 0x8149,
        SpriteAxisSgix = 0x814A,
        SpriteTranslationSgix = 0x814B,
        Texture4DBindingSgis = 0x814F,
        MaxClipmapDepthSgix = 0x8177,
        MaxClipmapVirtualDepthSgix = 0x8178,
        PostTextureFilterBiasRangeSgix = 0x817B,
        PostTextureFilterScaleRangeSgix = 0x817C,
        ReferencePlaneSgix = 0x817D,
        ReferencePlaneEquationSgix = 0x817E,
        IRInstrument1Sgix = 0x817F,
        InstrumentMeasurementsSgix = 0x8181,
        CalligraphicFragmentSgix = 0x8183,
        FramezoomSgix = 0x818B,
        FramezoomFactorSgix = 0x818C,
        MaxFramezoomFactorSgix = 0x818D,
        GenerateMipmapHintSgis = 0x8192,
        DeformationsMaskSgix = 0x8196,
        FogOffsetSgix = 0x8198,
        FogOffsetValueSgix = 0x8199,
        SharedTexturePaletteExt = 0x81FB,
        MajorVersion = 0x821B,
        MinorVersion = 0x821C,
        NumExtensions = 0x821D,
        ContextFlags = 0x821E,
        ProgramPipelineBinding = 0x825A,
        MaxViewports = 0x825B,
        ViewportSubpixelBits = 0x825C,
        ViewportBoundsRange = 0x825D,
        LayerProvokingVertex = 0x825E,
        ViewportIndexProvokingVertex = 0x825F,
        MaxComputeUniformComponents = 0x8263,
        MaxComputeAtomicCounterBuffers = 0x8264,
        MaxComputeAtomicCounters = 0x8265,
        MaxCombinedComputeUniformComponents = 0x8266,
        MaxDebugGroupStackDepth = 0x826C,
        DebugGroupStackDepth = 0x826D,
        MaxUniformLocations = 0x826E,
        VertexBindingDivisor = 0x82D6,
        VertexBindingOffset = 0x82D7,
        VertexBindingStride = 0x82D8,
        MaxVertexAttribRelativeOffset = 0x82D9,
        MaxVertexAttribBindings = 0x82DA,
        MaxLabelLength = 0x82E8,
        ConvolutionHintSgix = 0x8316,
        AsyncMarkerSgix = 0x8329,
        PixelTexGenModeSgix = 0x832B,
        AsyncHistogramSgix = 0x832C,
        MaxAsyncHistogramSgix = 0x832D,
        PixelTextureSgis = 0x8353,
        AsyncTexImageSgix = 0x835C,
        AsyncDrawPixelsSgix = 0x835D,
        AsyncReadPixelsSgix = 0x835E,
        MaxAsyncTexImageSgix = 0x835F,
        MaxAsyncDrawPixelsSgix = 0x8360,
        MaxAsyncReadPixelsSgix = 0x8361,
        VertexPreclipSgix = 0x83EE,
        VertexPreclipHintSgix = 0x83EF,
        FragmentLightingSgix = 0x8400,
        FragmentColorMaterialSgix = 0x8401,
        FragmentColorMaterialFaceSgix = 0x8402,
        FragmentColorMaterialParameterSgix = 0x8403,
        MaxFragmentLightsSgix = 0x8404,
        MaxActiveLightsSgix = 0x8405,
        LightEnvModeSgix = 0x8407,
        FragmentLightModelLocalViewerSgix = 0x8408,
        FragmentLightModelTwoSideSgix = 0x8409,
        FragmentLightModelAmbientSgix = 0x840A,
        FragmentLightModelNormalInterpolationSgix = 0x840B,
        FragmentLight0Sgix = 0x840C,
        PackResampleSgix = 0x842E,
        UnpackResampleSgix = 0x842F,
        AliasedLineWidthRange = 0x846E,
        ActiveTexture = 0x84E0,
        MaxRenderbufferSize = 0x84E8,
        TextureCompressionHint = 0x84EF,
        TextureBindingRectangle = 0x84F6,
        MaxRectangleTextureSize = 0x84F8,
        MaxTextureLodBias = 0x84FD,
        TextureBindingCubeMap = 0x8514,
        MaxCubeMapTextureSize = 0x851C,
        PackSubsampleRateSgix = 0x85A0,
        UnpackSubsampleRateSgix = 0x85A1,
        VertexArrayBinding = 0x85B5,
        ProgramPointSize = 0x8642,
        NumCompressedTextureFormats = 0x86A2,
        CompressedTextureFormats = 0x86A3,
        NumProgramBinaryFormats = 0x87FE,
        ProgramBinaryFormats = 0x87FF,
        StencilBackFunc = 0x8800,
        StencilBackFail = 0x8801,
        StencilBackPassDepthFail = 0x8802,
        StencilBackPassDepthPass = 0x8803,
        MaxDrawBuffers = 0x8824,
        BlendEquationAlpha = 0x883D,
        MaxVertexAttribs = 0x8869,
        MaxTextureImageUnits = 0x8872,
        ArrayBufferBinding = 0x8894,
        ElementArrayBufferBinding = 0x8895,
        PixelPackBufferBinding = 0x88ED,
        PixelUnpackBufferBinding = 0x88EF,
        MaxDualSourceDrawBuffers = 0x88FC,
        MaxArrayTextureLayers = 0x88FF,
        MinProgramTexelOffset = 0x8904,
        MaxProgramTexelOffset = 0x8905,
        SamplerBinding = 0x8919,
        UniformBufferBinding = 0x8A28,
        UniformBufferStart = 0x8A29,
        UniformBufferSize = 0x8A2A,
        MaxVertexUniformBlocks = 0x8A2B,
        MaxGeometryUniformBlocks = 0x8A2C,
        MaxFragmentUniformBlocks = 0x8A2D,
        MaxCombinedUniformBlocks = 0x8A2E,
        MaxUniformBufferBindings = 0x8A2F,
        MaxUniformBlockSize = 0x8A30,
        MaxCombinedVertexUniformComponents = 0x8A31,
        MaxCombinedGeometryUniformComponents = 0x8A32,
        MaxCombinedFragmentUniformComponents = 0x8A33,
        UniformBufferOffsetAlignment = 0x8A34,
        MaxFragmentUniformComponents = 0x8B49,
        MaxVertexUniformComponents = 0x8B4A,
        MaxVaryingFloats = 0x8B4B,
        MaxVaryingComponents = 0x8B4B,
        MaxVertexTextureImageUnits = 0x8B4C,
        MaxCombinedTextureImageUnits = 0x8B4D,
        FragmentShaderDerivativeHint = 0x8B8B,
        CurrentProgram = 0x8B8D,
        ImplementationColorReadType = 0x8B9A,
        ImplementationColorReadFormat = 0x8B9B,
        TextureBinding1DArray = 0x8C1C,
        TextureBinding2DArray = 0x8C1D,
        MaxGeometryTextureImageUnits = 0x8C29,
        MaxTextureBufferSize = 0x8C2B,
        TextureBindingBuffer = 0x8C2C,
        TransformFeedbackBufferStart = 0x8C84,
        TransformFeedbackBufferSize = 0x8C85,
        TransformFeedbackBufferBinding = 0x8C8F,
        StencilBackRef = 0x8CA3,
        StencilBackValueMask = 0x8CA4,
        StencilBackWritemask = 0x8CA5,
        DrawFramebufferBinding = 0x8CA6,
        RenderbufferBinding = 0x8CA7,
        ReadFramebufferBinding = 0x8CAA,
        MaxElementIndex = 0x8D6B,
        MaxGeometryUniformComponents = 0x8DDF,
        NumShaderBinaryFormats = 0x8DF9,
        ShaderCompiler = 0x8DFA,
        MaxVertexUniformVectors = 0x8DFB,
        MaxVaryingVectors = 0x8DFC,
        MaxFragmentUniformVectors = 0x8DFD,
        Timestamp = 0x8E28,
        ProvokingVertex = 0x8E4F,
        MaxSampleMaskWords = 0x8E59,
        PrimitiveRestartIndex = 0x8F9E,
        MinMapBufferAlignment = 0x90BC,
        ShaderStorageBufferBinding = 0x90D3,
        ShaderStorageBufferStart = 0x90D4,
        ShaderStorageBufferSize = 0x90D5,
        MaxVertexShaderStorageBlocks = 0x90D6,
        MaxGeometryShaderStorageBlocks = 0x90D7,
        MaxTessControlShaderStorageBlocks = 0x90D8,
        MaxTessEvaluationShaderStorageBlocks = 0x90D9,
        MaxFragmentShaderStorageBlocks = 0x90DA,
        MaxComputeShaderStorageBlocks = 0x90DB,
        MaxCombinedShaderStorageBlocks = 0x90DC,
        MaxShaderStorageBufferBindings = 0x90DD,
        ShaderStorageBufferOffsetAlignment = 0x90DF,
        MaxComputeWorkGroupInvocations = 0x90EB,
        DispatchIndirectBufferBinding = 0x90EF,
        TextureBinding2DMultisample = 0x9104,
        TextureBinding2DMultisampleArray = 0x9105,
        MaxColorTextureSamples = 0x910E,
        MaxDepthTextureSamples = 0x910F,
        MaxIntegerSamples = 0x9110,
        MaxServerWaitTimeout = 0x9111,
        MaxVertexOutputComponents = 0x9122,
        MaxGeometryInputComponents = 0x9123,
        MaxGeometryOutputComponents = 0x9124,
        MaxFragmentInputComponents = 0x9125,
        TextureBufferOffsetAlignment = 0x919F,
        MaxComputeUniformBlocks = 0x91BB,
        MaxComputeTextureImageUnits = 0x91BC,
        MaxComputeWorkGroupCount = 0x91BE,
        MaxComputeWorkGroupSize = 0x91BF,
        MaxVertexAtomicCounters = 0x92D2,
        MaxTessControlAtomicCounters = 0x92D3,
        MaxTessEvaluationAtomicCounters = 0x92D4,
        MaxGeometryAtomicCounters = 0x92D5,
        MaxFragmentAtomicCounters = 0x92D6,
        MaxCombinedAtomicCounters = 0x92D7,
        MaxFramebufferWidth = 0x9315,
        MaxFramebufferHeight = 0x9316,
        MaxFramebufferLayers = 0x9317,
        MaxFramebufferSamples = 0x9318,
        NumDeviceUuidsExt = 0x9596,
        DeviceUuidExt = 0x9597,
        DriverUuidExt = 0x9598,
        DeviceLuidExt = 0x9599,
        DeviceNodeMaskExt = 0x959A,
    }
}
