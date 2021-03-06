// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Vulkan;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

namespace Silk.NET.Vulkan.Extensions.KHR
{
    [Extension("VK_KHR_display")]
    public abstract unsafe partial class KhrDisplay : NativeExtension<Vk>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCreateDisplayModeKHR")]
        public abstract unsafe Result CreateDisplayMode([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0), Flow(FlowDirection.In)] DisplayModeCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] DisplayModeKHR* pMode);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCreateDisplayModeKHR")]
        public abstract Result CreateDisplayMode([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0), Flow(FlowDirection.In)] ref DisplayModeCreateInfoKHR pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out DisplayModeKHR pMode);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCreateDisplayPlaneSurfaceKHR")]
        public abstract unsafe Result CreateDisplayPlaneSurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] DisplaySurfaceCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] SurfaceKHR* pSurface);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCreateDisplayPlaneSurfaceKHR")]
        public abstract Result CreateDisplayPlaneSurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] ref DisplaySurfaceCreateInfoKHR pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out SurfaceKHR pSurface);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetDisplayModePropertiesKHR")]
        public abstract unsafe Result GetDisplayModeProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0)] uint* pPropertyCount, [Count(Computed = "pPropertyCount"), Flow(FlowDirection.Out)] DisplayModePropertiesKHR* pProperties);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetDisplayModePropertiesKHR")]
        public abstract Result GetDisplayModeProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] DisplayKHR display, [Count(Count = 0)] ref uint pPropertyCount, [Count(Computed = "pPropertyCount"), Flow(FlowDirection.Out)] out DisplayModePropertiesKHR pProperties);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetDisplayPlaneCapabilitiesKHR")]
        public abstract unsafe Result GetDisplayPlaneCapabilities([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] DisplayModeKHR mode, [Count(Count = 0)] uint planeIndex, [Count(Count = 0), Flow(FlowDirection.Out)] DisplayPlaneCapabilitiesKHR* pCapabilities);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetDisplayPlaneCapabilitiesKHR")]
        public abstract Result GetDisplayPlaneCapabilities([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] DisplayModeKHR mode, [Count(Count = 0)] uint planeIndex, [Count(Count = 0), Flow(FlowDirection.Out)] out DisplayPlaneCapabilitiesKHR pCapabilities);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetDisplayPlaneSupportedDisplaysKHR")]
        public abstract unsafe Result GetDisplayPlaneSupportedDisplays([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint planeIndex, [Count(Count = 0)] uint* pDisplayCount, [Count(Computed = "pDisplayCount"), Flow(FlowDirection.Out)] DisplayKHR* pDisplays);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetDisplayPlaneSupportedDisplaysKHR")]
        public abstract Result GetDisplayPlaneSupportedDisplays([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint planeIndex, [Count(Count = 0)] ref uint pDisplayCount, [Count(Computed = "pDisplayCount"), Flow(FlowDirection.Out)] out DisplayKHR pDisplays);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceDisplayPlanePropertiesKHR")]
        public abstract unsafe Result GetPhysicalDeviceDisplayPlaneProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pPropertyCount, [Count(Computed = "pPropertyCount"), Flow(FlowDirection.Out)] DisplayPlanePropertiesKHR* pProperties);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceDisplayPlanePropertiesKHR")]
        public abstract Result GetPhysicalDeviceDisplayPlaneProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] ref uint pPropertyCount, [Count(Computed = "pPropertyCount"), Flow(FlowDirection.Out)] out DisplayPlanePropertiesKHR pProperties);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceDisplayPropertiesKHR")]
        public abstract unsafe Result GetPhysicalDeviceDisplayProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pPropertyCount, [Count(Computed = "pPropertyCount"), Flow(FlowDirection.Out)] DisplayPropertiesKHR* pProperties);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceDisplayPropertiesKHR")]
        public abstract Result GetPhysicalDeviceDisplayProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] ref uint pPropertyCount, [Count(Computed = "pPropertyCount"), Flow(FlowDirection.Out)] out DisplayPropertiesKHR pProperties);

        public KhrDisplay(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

