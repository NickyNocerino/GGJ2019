using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class updateCipher : MonoBehaviour
{
    public InputField input;
    public GameObject daddy;
    // Start is called before the first frame update
    void Start()
    {
        //print(daddy.GetComponent<Text>().text);
    }

    // Update is called once per frame
    void Update()
    {
        string value = daddy.GetComponent<Text>().text;
        string value2 = input.text;
        if (!globalVars.masterCipher.ContainsKey(value.ToLower()))
        {
            globalVars.masterCipher.Add(value.ToLower(), value2.ToLower());
        }
        else
        {
            globalVars.masterCipher[value.ToLower()] = value2.ToLower();
        }
        //globalVars.masterCipher.Add(value.ToLower(), value2.ToLower());
    }
    public void InputChanged(string input)
    {
        print(input);
        //Do code with 'value' here.
    }

}
