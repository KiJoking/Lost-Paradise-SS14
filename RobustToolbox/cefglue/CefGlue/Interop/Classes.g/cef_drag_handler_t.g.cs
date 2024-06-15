﻿//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace Xilium.CefGlue.Interop
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.InteropServices;
    using System.Security;
    
    [StructLayout(LayoutKind.Sequential, Pack = libcef.ALIGN)]
    [SuppressMessage("Microsoft.Design", "CA1049:TypesThatOwnNativeResourcesShouldBeDisposable")]
    internal unsafe struct cef_drag_handler_t
    {
        internal cef_base_ref_counted_t _base;
        internal delegate* unmanaged<cef_drag_handler_t*, cef_browser_t*, cef_drag_data_t*, CefDragOperationsMask, int> _on_drag_enter;
        internal delegate* unmanaged<cef_drag_handler_t*, cef_browser_t*, cef_frame_t*, UIntPtr, cef_draggable_region_t*, void> _on_draggable_regions_changed;
        
        internal GCHandle _obj;
        
        [UnmanagedCallersOnly]
        public static void add_ref(cef_drag_handler_t* self)
        {
            var obj = (CefDragHandler)self->_obj.Target;
            obj.add_ref(self);
        }
        
        [UnmanagedCallersOnly]
        public static int release(cef_drag_handler_t* self)
        {
            var obj = (CefDragHandler)self->_obj.Target;
            return obj.release(self);
        }
        
        [UnmanagedCallersOnly]
        public static int has_one_ref(cef_drag_handler_t* self)
        {
            var obj = (CefDragHandler)self->_obj.Target;
            return obj.has_one_ref(self);
        }
        
        [UnmanagedCallersOnly]
        public static int has_at_least_one_ref(cef_drag_handler_t* self)
        {
            var obj = (CefDragHandler)self->_obj.Target;
            return obj.has_at_least_one_ref(self);
        }
        
        [UnmanagedCallersOnly]
        public static int on_drag_enter(cef_drag_handler_t* self, cef_browser_t* browser, cef_drag_data_t* dragData, CefDragOperationsMask mask)
        {
            var obj = (CefDragHandler)self->_obj.Target;
            return obj.on_drag_enter(self, browser, dragData, mask);
        }
        
        [UnmanagedCallersOnly]
        public static void on_draggable_regions_changed(cef_drag_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, UIntPtr regionsCount, cef_draggable_region_t* regions)
        {
            var obj = (CefDragHandler)self->_obj.Target;
            obj.on_draggable_regions_changed(self, browser, frame, regionsCount, regions);
        }
        
        internal static cef_drag_handler_t* Alloc(CefDragHandler obj)
        {
            var ptr = (cef_drag_handler_t*)NativeMemory.Alloc((UIntPtr)sizeof(cef_drag_handler_t));
            *ptr = default(cef_drag_handler_t);
            ptr->_base._size = (UIntPtr)sizeof(cef_drag_handler_t);
            ptr->_obj = GCHandle.Alloc(obj);
            ptr->_base._add_ref = (delegate* unmanaged<cef_base_ref_counted_t*, void>)(delegate* unmanaged<cef_drag_handler_t*, void>)&add_ref;
            ptr->_base._release = (delegate* unmanaged<cef_base_ref_counted_t*, int>)(delegate* unmanaged<cef_drag_handler_t*, int>)&release;
            ptr->_base._has_one_ref = (delegate* unmanaged<cef_base_ref_counted_t*, int>)(delegate* unmanaged<cef_drag_handler_t*, int>)&has_one_ref;
            ptr->_base._has_at_least_one_ref = (delegate* unmanaged<cef_base_ref_counted_t*, int>)(delegate* unmanaged<cef_drag_handler_t*, int>)&has_at_least_one_ref;
            ptr->_on_drag_enter = &on_drag_enter;
            ptr->_on_draggable_regions_changed = &on_draggable_regions_changed;
            return ptr;
        }
        
        internal static void Free(cef_drag_handler_t* ptr)
        {
            ptr->_obj.Free();
            NativeMemory.Free((void*)ptr);
        }
        
    }
}