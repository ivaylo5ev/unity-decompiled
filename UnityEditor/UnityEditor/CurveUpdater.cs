﻿// Decompiled with JetBrains decompiler
// Type: UnityEditor.CurveUpdater
// Assembly: UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 01B28312-B6F5-4E06-90F6-BE297B711E41
// Assembly location: C:\Users\Blake\sandbox\unity\test-project\Library\UnityAssemblies\UnityEditor.dll

using System.Collections.Generic;

namespace UnityEditor
{
  internal interface CurveUpdater
  {
    void UpdateCurves(List<int> curveIds, string undoText);

    void UpdateCurves(List<ChangedCurve> curve, string undoText);
  }
}
