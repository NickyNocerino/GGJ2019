using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class globalVars : MonoBehaviour
{
    public static Dictionary<string, string> masterCipher;

    // Start is called before the first frame update
    void Start()
    {
        masterCipher = new Dictionary<string, string>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
