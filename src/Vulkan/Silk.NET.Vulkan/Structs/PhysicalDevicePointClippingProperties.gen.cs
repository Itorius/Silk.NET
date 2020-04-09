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
    public unsafe struct PhysicalDevicePointClippingProperties
    {
        public PhysicalDevicePointClippingProperties
        (
            StructureType sType = StructureType.PhysicalDevicePointClippingProperties,
            void* pNext = default,
            PointClippingBehavior pointClippingBehavior = default
        )
        {
           SType = sType;
           PNext = pNext;
           PointClippingBehavior = pointClippingBehavior;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public PointClippingBehavior PointClippingBehavior;
    }
}
