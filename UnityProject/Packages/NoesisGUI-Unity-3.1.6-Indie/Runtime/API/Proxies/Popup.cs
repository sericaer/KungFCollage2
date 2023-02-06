//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace Noesis
{

public class Popup : FrameworkElement {
  internal new static Popup CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new Popup(cPtr, cMemoryOwn);
  }

  internal Popup(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(Popup obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  #region Events
  #region Closed
  public delegate void ClosedHandler(object sender, EventArgs e);
  public event ClosedHandler Closed {
    add {
      long ptr = swigCPtr.Handle.ToInt64();
      if (!_Closed.ContainsKey(ptr)) {
        _Closed.Add(ptr, null);

        NoesisGUI_PINVOKE.BindEvent_Popup_Closed(_raiseClosed, swigCPtr.Handle);
      }

      _Closed[ptr] += value;
    }
    remove {
      long ptr = swigCPtr.Handle.ToInt64();
      if (_Closed.ContainsKey(ptr)) {

        _Closed[ptr] -= value;

        if (_Closed[ptr] == null) {
          NoesisGUI_PINVOKE.UnbindEvent_Popup_Closed(_raiseClosed, swigCPtr.Handle);

          _Closed.Remove(ptr);
        }
      }
    }
  }

  internal delegate void RaiseClosedCallback(IntPtr cPtr, IntPtr sender, IntPtr e);
  private static RaiseClosedCallback _raiseClosed = RaiseClosed;

  [MonoPInvokeCallback(typeof(RaiseClosedCallback))]
  private static void RaiseClosed(IntPtr cPtr, IntPtr sender, IntPtr e) {
    try {
      if (Noesis.Extend.Initialized) {
        long ptr = cPtr.ToInt64();
        if (sender == IntPtr.Zero && e == IntPtr.Zero) {
          _Closed.Remove(ptr);
          return;
        }
        ClosedHandler handler = null;
        if (!_Closed.TryGetValue(ptr, out handler)) {
          throw new InvalidOperationException("Delegate not registered for Closed event");
        }
        handler?.Invoke(Noesis.Extend.GetProxy(sender, false), new EventArgs(e, false));
      }
    }
    catch (Exception exception) {
      Noesis.Error.UnhandledException(exception);
    }
  }

  internal static Dictionary<long, ClosedHandler> _Closed =
      new Dictionary<long, ClosedHandler>();
  #endregion

  #region Opened
  public delegate void OpenedHandler(object sender, EventArgs e);
  public event OpenedHandler Opened {
    add {
      long ptr = swigCPtr.Handle.ToInt64();
      if (!_Opened.ContainsKey(ptr)) {
        _Opened.Add(ptr, null);

        NoesisGUI_PINVOKE.BindEvent_Popup_Opened(_raiseOpened, swigCPtr.Handle);
      }

      _Opened[ptr] += value;
    }
    remove {
      long ptr = swigCPtr.Handle.ToInt64();
      if (_Opened.ContainsKey(ptr)) {

        _Opened[ptr] -= value;

        if (_Opened[ptr] == null) {
          NoesisGUI_PINVOKE.UnbindEvent_Popup_Opened(_raiseOpened, swigCPtr.Handle);

          _Opened.Remove(ptr);
        }
      }
    }
  }

  internal delegate void RaiseOpenedCallback(IntPtr cPtr, IntPtr sender, IntPtr e);
  private static RaiseOpenedCallback _raiseOpened = RaiseOpened;

  [MonoPInvokeCallback(typeof(RaiseOpenedCallback))]
  private static void RaiseOpened(IntPtr cPtr, IntPtr sender, IntPtr e) {
    try {
      if (Noesis.Extend.Initialized) {
        long ptr = cPtr.ToInt64();
        if (sender == IntPtr.Zero && e == IntPtr.Zero) {
          _Opened.Remove(ptr);
          return;
        }
        OpenedHandler handler = null;
        if (!_Opened.TryGetValue(ptr, out handler)) {
          throw new InvalidOperationException("Delegate not registered for Opened event");
        }
        handler?.Invoke(Noesis.Extend.GetProxy(sender, false), new EventArgs(e, false));
      }
    }
    catch (Exception exception) {
      Noesis.Error.UnhandledException(exception);
    }
  }

  internal static Dictionary<long, OpenedHandler> _Opened =
      new Dictionary<long, OpenedHandler>();
  #endregion

  #endregion

  public Popup() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    if (type == typeof(Popup)) {
      registerExtend = false;
      return NoesisGUI_PINVOKE.new_Popup();
    }
    else {
      return base.CreateExtendCPtr(type, out registerExtend);
    }
  }

  public static DependencyProperty AllowsTransparencyProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Popup_AllowsTransparencyProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty ChildProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Popup_ChildProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty HasDropShadowProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Popup_HasDropShadowProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty HorizontalOffsetProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Popup_HorizontalOffsetProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty IsOpenProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Popup_IsOpenProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty PlacementProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Popup_PlacementProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty PlacementRectangleProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Popup_PlacementRectangleProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty PlacementTargetProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Popup_PlacementTargetProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty PopupAnimationProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Popup_PopupAnimationProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty StaysOpenProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Popup_StaysOpenProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty VerticalOffsetProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Popup_VerticalOffsetProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public bool AllowsTransparency {
    set {
      NoesisGUI_PINVOKE.Popup_AllowsTransparency_set(swigCPtr, value);
    } 
    get {
      bool ret = NoesisGUI_PINVOKE.Popup_AllowsTransparency_get(swigCPtr);
      return ret;
    } 
  }

  public UIElement Child {
    set {
      NoesisGUI_PINVOKE.Popup_Child_set(swigCPtr, UIElement.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Popup_Child_get(swigCPtr);
      return (UIElement)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public bool HasDropShadow {
    set {
      NoesisGUI_PINVOKE.Popup_HasDropShadow_set(swigCPtr, value);
    } 
    get {
      bool ret = NoesisGUI_PINVOKE.Popup_HasDropShadow_get(swigCPtr);
      return ret;
    } 
  }

  public float HorizontalOffset {
    set {
      NoesisGUI_PINVOKE.Popup_HorizontalOffset_set(swigCPtr, value);
    } 
    get {
      float ret = NoesisGUI_PINVOKE.Popup_HorizontalOffset_get(swigCPtr);
      return ret;
    } 
  }

  public bool IsOpen {
    set {
      NoesisGUI_PINVOKE.Popup_IsOpen_set(swigCPtr, value);
    } 
    get {
      bool ret = NoesisGUI_PINVOKE.Popup_IsOpen_get(swigCPtr);
      return ret;
    } 
  }

  public PlacementMode Placement {
    set {
      NoesisGUI_PINVOKE.Popup_Placement_set(swigCPtr, (int)value);
    } 
    get {
      PlacementMode ret = (PlacementMode)NoesisGUI_PINVOKE.Popup_Placement_get(swigCPtr);
      return ret;
    } 
  }

  public Rect PlacementRectangle {
    set {
      NoesisGUI_PINVOKE.Popup_PlacementRectangle_set(swigCPtr, ref value);
    }

    get {
      IntPtr ret = NoesisGUI_PINVOKE.Popup_PlacementRectangle_get(swigCPtr);
      if (ret != IntPtr.Zero) {
        return Marshal.PtrToStructure<Rect>(ret);
      }
      else {
        return new Rect();
      }
    }

  }

  public UIElement PlacementTarget {
    set {
      NoesisGUI_PINVOKE.Popup_PlacementTarget_set(swigCPtr, UIElement.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Popup_PlacementTarget_get(swigCPtr);
      return (UIElement)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public PopupAnimation PopupAnimation {
    set {
      NoesisGUI_PINVOKE.Popup_PopupAnimation_set(swigCPtr, (int)value);
    } 
    get {
      PopupAnimation ret = (PopupAnimation)NoesisGUI_PINVOKE.Popup_PopupAnimation_get(swigCPtr);
      return ret;
    } 
  }

  public bool StaysOpen {
    set {
      NoesisGUI_PINVOKE.Popup_StaysOpen_set(swigCPtr, value);
    } 
    get {
      bool ret = NoesisGUI_PINVOKE.Popup_StaysOpen_get(swigCPtr);
      return ret;
    } 
  }

  public float VerticalOffset {
    set {
      NoesisGUI_PINVOKE.Popup_VerticalOffset_set(swigCPtr, value);
    } 
    get {
      float ret = NoesisGUI_PINVOKE.Popup_VerticalOffset_get(swigCPtr);
      return ret;
    } 
  }

  internal new static IntPtr Extend(string typeName) {
    return NoesisGUI_PINVOKE.Extend_Popup(Marshal.StringToHGlobalAnsi(typeName));
  }
}

}
