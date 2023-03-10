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

public abstract class BrushShader : Animatable {
  internal BrushShader(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(BrushShader obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  protected BrushShader() {
  }

  ~BrushShader() {
    if (_constantsHandle.IsAllocated) {
      _constantsHandle.Free();
    }
  }

  protected void SetConstantBuffer<T>(T constants) where T : class {
    if (constants == null) {
      Log.Error("Null argument 'constants'");
      return;
    }
    if (!typeof(T).IsLayoutSequential) {
      Log.Error("Constants class must have [StructLayout(LayoutKind.Sequential)] applied");
      return;
    }
    _constantsHandle = GCHandle.Alloc(constants, GCHandleType.Pinned);
    SetConstantBuffer(_constantsHandle.AddrOfPinnedObject(), (uint)Marshal.SizeOf<T>());
  }

  private GCHandle _constantsHandle;

  protected enum Target {
    Path,
    Path_AA,
    SDF,
    SDF_LCD,
    Opacity
  }

  protected void SetPixelShader(IntPtr shader, Target target) {
    SetPixelShader(shader, (int)target);
  }

#if UNITY_5_3_OR_NEWER
  protected NoesisShader CreateShader(int numTextures) {
    string name = GetType().Name.Replace("Brush", ".noesisbrush");
    NoesisShader shader = NoesisShaderProvider.instance.GetShader(name);

    if (shader != null) {
      shader.brush_path = NoesisRenderer.CreatePixelShader((byte)Shader.Enum.Path_Pattern, numTextures, shader.brush_path_bytecode);
      shader.brush_path_aa = NoesisRenderer.CreatePixelShader((byte)Shader.Enum.Path_AA_Pattern, numTextures, shader.brush_path_aa_bytecode);
      shader.brush_sdf = NoesisRenderer.CreatePixelShader((byte)Shader.Enum.SDF_Pattern, numTextures, shader.brush_sdf_bytecode);
      shader.brush_opacity = NoesisRenderer.CreatePixelShader((byte)Shader.Enum.Opacity_Pattern, numTextures, shader.brush_opacity_bytecode);
      return shader;
    }

    Log.Error($"Can't find asset '{name}' for class '{GetType().Name}'");
    return null;
  }

  protected void SetShader(NoesisShader shader) {
    if (shader != null) {
      SetPixelShader(shader.brush_path, BrushShader.Target.Path);
      SetPixelShader(shader.brush_path_aa, BrushShader.Target.Path_AA);
      SetPixelShader(shader.brush_sdf, BrushShader.Target.SDF);
      SetPixelShader(shader.brush_opacity, BrushShader.Target.Opacity);
    }
  }

  protected void SetTexture(UnityEngine.Texture texture, uint index) {
    NoesisGUI_PINVOKE.BrushShader_SetTexture(swigCPtr, Noesis.Extend.GetInstanceHandle(texture), index);
  }
#endif

  private void SetPixelShader(IntPtr value, int target) {
    NoesisGUI_PINVOKE.BrushShader_SetPixelShader(swigCPtr, value, target);
  }

  protected void SetTexture(ImageSource texture, uint index) {
    NoesisGUI_PINVOKE.BrushShader_SetTexture(swigCPtr, ImageSource.getCPtr(texture), index);
  }

  private void SetConstantBuffer(IntPtr buffer, uint size) {
    NoesisGUI_PINVOKE.BrushShader_SetConstantBuffer(swigCPtr, buffer, size);
  }

  protected void InvalidateConstantBuffer() {
    NoesisGUI_PINVOKE.BrushShader_InvalidateConstantBuffer(swigCPtr);
  }

  internal new static IntPtr Extend(string typeName) {
    return NoesisGUI_PINVOKE.Extend_BrushShader(Marshal.StringToHGlobalAnsi(typeName));
  }
}

}

