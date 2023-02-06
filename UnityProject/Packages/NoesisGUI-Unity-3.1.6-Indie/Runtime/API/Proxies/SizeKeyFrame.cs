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

namespace Noesis
{

public class SizeKeyFrame : Freezable {
  internal new static SizeKeyFrame CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new SizeKeyFrame(cPtr, cMemoryOwn);
  }

  internal SizeKeyFrame(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(SizeKeyFrame obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  protected SizeKeyFrame() {
  }

  public static DependencyProperty KeyTimeProperty {
    get {
      return NoesisGUI_.KeyFrame_KeyTimeProperty();
    }
  }

  public static DependencyProperty ValueProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.SizeKeyFrame_ValueProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public KeyTime KeyTime {
    set {
      NoesisGUI_PINVOKE.SizeKeyFrame_KeyTime_set(swigCPtr, ref value);
    }

    get {
      IntPtr ret = NoesisGUI_PINVOKE.SizeKeyFrame_KeyTime_get(swigCPtr);
      if (ret != IntPtr.Zero) {
        return Marshal.PtrToStructure<KeyTime>(ret);
      }
      else {
        return new KeyTime();
      }
    }

  }

  public Size Value {
    set {
      NoesisGUI_PINVOKE.SizeKeyFrame_Value_set(swigCPtr, ref value);
    }

    get {
      IntPtr ret = NoesisGUI_PINVOKE.SizeKeyFrame_Value_get(swigCPtr);
      if (ret != IntPtr.Zero) {
        return Marshal.PtrToStructure<Size>(ret);
      }
      else {
        return new Size();
      }
    }

  }

}

}
