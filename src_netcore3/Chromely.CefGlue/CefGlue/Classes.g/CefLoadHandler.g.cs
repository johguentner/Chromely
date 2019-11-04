﻿//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
#pragma warning disable 1591
namespace Xilium.CefGlue
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    using Xilium.CefGlue.Interop;
    
    // Role: HANDLER
    public abstract unsafe partial class CefLoadHandler
    {
        private static Dictionary<IntPtr, CefLoadHandler> _roots = new Dictionary<IntPtr, CefLoadHandler>();
        
        private int _refct;
        private cef_load_handler_t* _self;
        
        protected object SyncRoot { get { return this; } }
        
        private cef_load_handler_t.add_ref_delegate _ds0;
        private cef_load_handler_t.release_delegate _ds1;
        private cef_load_handler_t.has_one_ref_delegate _ds2;
        private cef_load_handler_t.has_at_least_one_ref_delegate _ds3;
        private cef_load_handler_t.on_loading_state_change_delegate _ds4;
        private cef_load_handler_t.on_load_start_delegate _ds5;
        private cef_load_handler_t.on_load_end_delegate _ds6;
        private cef_load_handler_t.on_load_error_delegate _ds7;
        
        protected CefLoadHandler()
        {
            _self = cef_load_handler_t.Alloc();
        
            _ds0 = new cef_load_handler_t.add_ref_delegate(add_ref);
            _self->_base._add_ref = Marshal.GetFunctionPointerForDelegate(_ds0);
            _ds1 = new cef_load_handler_t.release_delegate(release);
            _self->_base._release = Marshal.GetFunctionPointerForDelegate(_ds1);
            _ds2 = new cef_load_handler_t.has_one_ref_delegate(has_one_ref);
            _self->_base._has_one_ref = Marshal.GetFunctionPointerForDelegate(_ds2);
            _ds3 = new cef_load_handler_t.has_at_least_one_ref_delegate(has_at_least_one_ref);
            _self->_base._has_at_least_one_ref = Marshal.GetFunctionPointerForDelegate(_ds3);
            _ds4 = new cef_load_handler_t.on_loading_state_change_delegate(on_loading_state_change);
            _self->_on_loading_state_change = Marshal.GetFunctionPointerForDelegate(_ds4);
            _ds5 = new cef_load_handler_t.on_load_start_delegate(on_load_start);
            _self->_on_load_start = Marshal.GetFunctionPointerForDelegate(_ds5);
            _ds6 = new cef_load_handler_t.on_load_end_delegate(on_load_end);
            _self->_on_load_end = Marshal.GetFunctionPointerForDelegate(_ds6);
            _ds7 = new cef_load_handler_t.on_load_error_delegate(on_load_error);
            _self->_on_load_error = Marshal.GetFunctionPointerForDelegate(_ds7);
        }
        
        ~CefLoadHandler()
        {
            Dispose(false);
        }
        
        protected virtual void Dispose(bool disposing)
        {
            if (_self != null)
            {
                cef_load_handler_t.Free(_self);
                _self = null;
            }
        }
        
        private void add_ref(cef_load_handler_t* self)
        {
            lock (SyncRoot)
            {
                var result = ++_refct;
                if (result == 1)
                {
                    lock (_roots) { _roots.Add((IntPtr)_self, this); }
                }
            }
        }
        
        private int release(cef_load_handler_t* self)
        {
            lock (SyncRoot)
            {
                var result = --_refct;
                if (result == 0)
                {
                    lock (_roots) { _roots.Remove((IntPtr)_self); }
                    return 1;
                }
                return 0;
            }
        }
        
        private int has_one_ref(cef_load_handler_t* self)
        {
            lock (SyncRoot) { return _refct == 1 ? 1 : 0; }
        }
        
        private int has_at_least_one_ref(cef_load_handler_t* self)
        {
            lock (SyncRoot) { return _refct != 0 ? 1 : 0; }
        }
        
        internal cef_load_handler_t* ToNative()
        {
            add_ref(_self);
            return _self;
        }
        
        [Conditional("DEBUG")]
        private void CheckSelf(cef_load_handler_t* self)
        {
            if (_self != self) throw ExceptionBuilder.InvalidSelfReference();
        }
        
    }
}
