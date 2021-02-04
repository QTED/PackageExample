using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class EditorExample
{

    static string version = "v0.1.0";

    [MenuItem("QTED/EditorExample")]
    static void EditorExampleFunc() {

        Debug.Log("EditorExample: " + version);
    }

}
