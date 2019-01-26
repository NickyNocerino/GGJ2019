using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class listenConverse1 : MonoBehaviour
{
    public GameObject dialogBox;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnMouseDown()
    {
        dialogBox.SetActive(true);
        dialogBox.GetComponentInChildren<Text>().text = "yo dawg whats crackalackin";

    }
}
