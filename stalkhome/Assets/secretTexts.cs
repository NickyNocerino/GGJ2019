using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class secretTexts : MonoBehaviour
{
    public string secretText;
    public string trans = "";
    public GameObject transText;
    // Start is called before the first frame update
    void Start()
    {
        trans = "";
        transText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseOver()
    {
        trans = "";
        foreach (char c in secretText)
        {
            if (globalVars.masterCipher.ContainsKey(char.ToLower(c).ToString()))
            {
                if (globalVars.masterCipher[char.ToLower(c).ToString()] == "-")
                {
                    trans += "*";
                }
                else
                {
                    
                    Debug.Log(globalVars.masterCipher[char.ToLower(c).ToString()]);
                    trans += globalVars.masterCipher[char.ToLower(c).ToString()];
                }
            }
            else if (c.ToString() == " ")
            {
                trans += " ";
            }
            else
            {
                trans += "*";
            }
        }
        print(trans.ToString());
        transText.SetActive(true);
        transText.transform.position = Input.mousePosition;
        transText.GetComponentInChildren<Text>().text = trans;
    }
    void OnMouseExit()
    {
        transText.SetActive(false);
    }
}
