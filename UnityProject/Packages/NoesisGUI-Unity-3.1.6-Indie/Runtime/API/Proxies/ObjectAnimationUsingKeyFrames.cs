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

public sealed class ObjectAnimationUsingKeyFrames : ObjectAnimationBase {
  internal new static ObjectAnimationUsingKeyFrames CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new ObjectAnimationUsingKeyFrames(cPtr, cMemoryOwn);
  }

  internal ObjectAnimationUsingKeyFrames(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(ObjectAnimationUsingKeyFrames obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  protected internal override object GetCurrentValueCore(object defaultOriginValue, object defaultDestinationValue, AnimationClock animationClock) {
    return GetCurrentValueCoreHelper(defaultOriginValue, defaultDestinationValue, animationClock);
  }

  public ObjectAnimationUsingKeyFrames() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    registerExtend = false;
    return NoesisGUI_PINVOKE.new_ObjectAnimationUsingKeyFrames();
  }

  public ObjectKeyFrameCollection KeyFrames {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ObjectAnimationUsingKeyFrames_KeyFrames_get(swigCPtr);
      return (ObjectKeyFrameCollection)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  private object GetCurrentValueCoreHelper(object src, object dst, AnimationClock clock) {
    IntPtr cPtr = NoesisGUI_PINVOKE.ObjectAnimationUsingKeyFrames_GetCurrentValueCoreHelper(swigCPtr, Noesis.Extend.GetInstanceHandle(src), Noesis.Extend.GetInstanceHandle(dst), AnimationClock.getCPtr(clock));
    return Noesis.Extend.GetProxy(cPtr, false);
  }

}

}

