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
    internal unsafe struct cef_domvisitor_t
    {
        internal cef_base_ref_counted_t _base;
        internal delegate* unmanaged<cef_domvisitor_t*, cef_domdocument_t*, void> _visit;
        
        internal GCHandle _obj;
        
        [UnmanagedCallersOnly]
        public static void add_ref(cef_domvisitor_t* self)
        {
            var obj = (CefDomVisitor)self->_obj.Target;
            obj.add_ref(self);
        }
        
        [UnmanagedCallersOnly]
        public static int release(cef_domvisitor_t* self)
        {
            var obj = (CefDomVisitor)self->_obj.Target;
            return obj.release(self);
        }
        
        [UnmanagedCallersOnly]
        public static int has_one_ref(cef_domvisitor_t* self)
        {
            var obj = (CefDomVisitor)self->_obj.Target;
            return obj.has_one_ref(self);
        }
        
        [UnmanagedCallersOnly]
        public static int has_at_least_one_ref(cef_domvisitor_t* self)
        {
            var obj = (CefDomVisitor)self->_obj.Target;
            return obj.has_at_least_one_ref(self);
        }
        
        [UnmanagedCallersOnly]
        public static void visit(cef_domvisitor_t* self, cef_domdocument_t* document)
        {
            var obj = (CefDomVisitor)self->_obj.Target;
            obj.visit(self, document);
        }
        
        internal static cef_domvisitor_t* Alloc(CefDomVisitor obj)
        {
            var ptr = (cef_domvisitor_t*)NativeMemory.Alloc((UIntPtr)sizeof(cef_domvisitor_t));
            *ptr = default(cef_domvisitor_t);
            ptr->_base._size = (UIntPtr)sizeof(cef_domvisitor_t);
            ptr->_obj = GCHandle.Alloc(obj);
            ptr->_base._add_ref = (delegate* unmanaged<cef_base_ref_counted_t*, void>)(delegate* unmanaged<cef_domvisitor_t*, void>)&add_ref;
            ptr->_base._release = (delegate* unmanaged<cef_base_ref_counted_t*, int>)(delegate* unmanaged<cef_domvisitor_t*, int>)&release;
            ptr->_base._has_one_ref = (delegate* unmanaged<cef_base_ref_counted_t*, int>)(delegate* unmanaged<cef_domvisitor_t*, int>)&has_one_ref;
            ptr->_base._has_at_least_one_ref = (delegate* unmanaged<cef_base_ref_counted_t*, int>)(delegate* unmanaged<cef_domvisitor_t*, int>)&has_at_least_one_ref;
            ptr->_visit = &visit;
            return ptr;
        }
        
        internal static void Free(cef_domvisitor_t* ptr)
        {
            ptr->_obj.Free();
            NativeMemory.Free((void*)ptr);
        }
        
    }
}