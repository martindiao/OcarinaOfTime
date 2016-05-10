﻿using System.Collections;
using UnityEngine;

public class timemanager : MonoBehaviour
{
    public int frame = 0;
    // Use this for initialization
    void Start()
    {
        GameObject.DontDestroyOnLoad(gameObject);

    }

    // Update is called once per frame
    void Update()
    {
        var vars = GameObject.FindGameObjectWithTag("GameController");
        var check = vars.GetComponent<VarTracker>();
        if (frame == 30)
        {
            check.time++;
            frame = 0;
        }
        frame++;
    }
}