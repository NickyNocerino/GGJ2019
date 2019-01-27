using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moveRooms : MonoBehaviour
{
    public GameObject newCam;
    public GameObject cam;
    public string roomName;
    public GameObject transText;
    private string trans;
    public GameObject sign;
    public GameObject text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseOver()
    {
        trans = "";
        foreach (char c in roomName)
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
            cam.GetComponent<Transform>().position = newCam.GetComponent<Transform>().position;
            sign.SetActive(false);
            text.SetActive(false);
        }
    }
    void OnMouseExit()
    {
        transText.SetActive(false);
    }
}
