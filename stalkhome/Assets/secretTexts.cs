using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class secretTexts : MonoBehaviour
{
    public string secretText;
    public string trans = "";
    public GameObject transText;
    public GameObject tran;
    public bool sign;
    public GameObject signBox;
    public GameObject signSign;
    public Sprite zoomSign;
    public bool speak;
    public GameObject speakBox;
    // Start is called before the first frame update
    void Start()
    {
        trans = "";
        transText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //print("found it");
        tran.SetActive(true);
        trans = "";
        //secretText = this.GetComponent<Text>().text;
        foreach (char c in secretText)
        {
            if (globalVars.masterCipher.ContainsKey(char.ToLower(c).ToString()))
            {
                if (globalVars.masterCipher[char.ToLower(c).ToString()] == "-" || globalVars.masterCipher[char.ToLower(c).ToString()] == "")
                {
                    trans += "?";
                }
                else
                {
                    // Debug.Log(globalVars.masterCipher[char.ToLower(c).ToString()]);
                    trans += globalVars.masterCipher[char.ToLower(c).ToString()];
                }
            }
            else if (c.ToString() == " ")
            {
                trans += " ";
            }
            else
            {
                trans += "?";
            }
        }
        // print(trans.ToString());
        // tran.transform.position = Input.mousePosition;
        tran.GetComponent<Text>().text = trans;
    }
    void OnMouseOver()
    {
        trans = "";
        foreach (char c in secretText)
        {
            if (globalVars.masterCipher.ContainsKey(char.ToLower(c).ToString()))
            {
                if (globalVars.masterCipher[char.ToLower(c).ToString()] == "-" || globalVars.masterCipher[char.ToLower(c).ToString()] == "")
                {
                    trans += "?";
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
                trans += "?";
            }
        }
        print(trans.ToString());
        transText.SetActive(true);
        transText.transform.position = Input.mousePosition;
        transText.GetComponentInChildren<Text>().text = trans;
        if (Input.GetMouseButtonDown(0))
        {
            if (sign)
            {
                speakBox.SetActive(false);
                signBox.SetActive(true);
                Image im = signSign.GetComponent<Image>();
                im.sprite = zoomSign;
                signBox.GetComponentInChildren<secretTexts>().secretText = secretText;
            }
            if(speak)
            {
                signBox.SetActive(false);
                speakBox.SetActive(true);
                speakBox.GetComponentInChildren<secretTexts>().secretText = secretText;
            }
        }
    }
    void OnMouseExit()
    {
        transText.SetActive(false);
    }
    public void OnPointerEnter(GameObject tran)
    {
       //print("found it");
       tran.SetActive(true);
       trans = "";
       secretText = this.GetComponent<Text>().text;
       foreach (char c in secretText)
       {
           if (globalVars.masterCipher.ContainsKey(char.ToLower(c).ToString()))
           {
               if (globalVars.masterCipher[char.ToLower(c).ToString()] == "-" || globalVars.masterCipher[char.ToLower(c).ToString()] == "")
               {
                   trans += "?";
               }
               else
               {
                  // Debug.Log(globalVars.masterCipher[char.ToLower(c).ToString()]);
                   trans += globalVars.masterCipher[char.ToLower(c).ToString()];
               }
           }
           else if (c.ToString() == " ")
           {
                trans += " ";
           }
           else
           {
               trans += "?";
           }
       }
      // print(trans.ToString());
      // tran.transform.position = Input.mousePosition;
       tran.GetComponentInChildren<Text>().text = trans;
    }
    public void OnPointerExit(GameObject tran)
    {
      //  print("lost it");
        tran.SetActive(false);

    }
    public void OnPointerEnterImage(GameObject tran)
    {
        //print("found it");
        tran.SetActive(true);
        trans = "";
        //secretText = this.GetComponent<Text>().text;
        foreach (char c in secretText)
        {
            if (globalVars.masterCipher.ContainsKey(char.ToLower(c).ToString()))
            {
                if (globalVars.masterCipher[char.ToLower(c).ToString()] == "-" || globalVars.masterCipher[char.ToLower(c).ToString()] == "")
                {
                    trans += "?";
                }
                else
                {
                    // Debug.Log(globalVars.masterCipher[char.ToLower(c).ToString()]);
                    trans += globalVars.masterCipher[char.ToLower(c).ToString()];
                }
            }
            else if (c.ToString() == " ")
            {
                trans += " ";
            }
            else
            {
                trans += "?";
            }
        }
        // print(trans.ToString());
        // tran.transform.position = Input.mousePosition;
        tran.GetComponentInChildren<Text>().text = trans;
    }
}
