// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

namespace Silk.NET.Vulkan
{
    public unsafe struct ImageDrmFormatModifierListCreateInfoEXT
    {
        public ImageDrmFormatModifierListCreateInfoEXT
        (
            StructureType sType = StructureType.ImageDrmFormatModifierListCreateInfoExt,
            void* pNext = default,
            uint drmFormatModifierCount = default,
            ulong* pDrmFormatModifiers = default
        )
        {
           SType = sType;
           PNext = pNext;
           DrmFormatModifierCount = drmFormatModifierCount;
           PDrmFormatModifiers = pDrmFormatModifiers;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint DrmFormatModifierCount;
/// <summary></summary>
        public ulong* PDrmFormatModifiers;
    }
}
