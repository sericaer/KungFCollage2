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

public class Italic : Span {
  internal new static Italic CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new Italic(cPtr, cMemoryOwn);
  }

  internal Italic(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(Italic obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public Italic() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    registerExtend = false;
    return NoesisGUI_PINVOKE.new_Italic__SWIG_0();
  }

  public Italic(Inline childInline) : this(NoesisGUI_PINVOKE.new_Italic__SWIG_1(Inline.getCPtr(childInline)), true) {
  }

}

}
