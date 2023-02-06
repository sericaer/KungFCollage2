using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class DynamicXmal : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        var xaml = ScriptableObject.CreateInstance<NoesisXaml>();
        xaml.content = File.ReadAllBytes(Path.Combine(Application.streamingAssetsPath, "test.xaml"));
        xaml.Load();

        var view = GetComponent<NoesisView>();
        view.Xaml = xaml;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
