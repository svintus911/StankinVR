using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class zadnieScript : MonoBehaviour
{
    private GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        obj = GameObject.FindWithTag("schetchik");
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        TextMeshProUGUI t = obj.GetComponent<TextMeshProUGUI>();
        t.text = (Convert.ToInt32(t.text) + 1).ToString();
    }
}