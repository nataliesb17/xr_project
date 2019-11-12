﻿// Copyright © 2018 – Property of Tobii AB (publ) - All Rights Reserved

using Tobii.G2OM;
using UnityEngine;

//Monobehaviour which implements the "IGazeFocusable" interface, meaning it will be called on when the object receives focus
public class HighlightAtGaze : MonoBehaviour, IGazeFocusable
{
    public Color HighlightColor = Color.red;
    public float AnimationTime = 0.1f;

    private Renderer _renderer;
    private Color _originalColor;
    private Color _targetColor;
    private GameObject p;
    private timerGame s;
    public GameObject ghostPrefab;
    public float fl = 2.0f;
    public bool isFocused;

    public GameObject myObject;

    public bool hasHit;

    //The method of the "IGazeFocusable" interface, which will be called when this object receives or loses focus
    public void GazeFocusChanged(bool hasFocus)
    {
        //If this object received focus, fade the object's color to highlight color
        if (hasFocus)
        {
            isFocused = true;
            _targetColor = HighlightColor;
           
        }
        //If this object lost focus, fade the object's color to it's original color
        else
        {
            _targetColor = _originalColor;
            isFocused = false;
        }
    }

    private void Start()
    {
        _renderer = GetComponent<Renderer>();
        _originalColor = _renderer.material.color;
        _targetColor = _originalColor;

        p = GameObject.Find("logging");
        s = p.GetComponent<timerGame>();
       
    }

    private void Update()
    {
        //This lerp will fade the color of the object
        _renderer.material.color = Color.Lerp(_renderer.material.color, _targetColor, Time.deltaTime * (1 / AnimationTime));

        if (isFocused == true)
        {
            fl -= Time.deltaTime;
            if (fl <= 0.0f)
            {
                s.GhostHit();
                Destroy(ghostPrefab);
            }
        }
        if (isFocused == false)
        {
        
        }
    }
}