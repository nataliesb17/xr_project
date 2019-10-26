// Copyright © 2018 – Property of Tobii AB (publ) - All Rights Reserved

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

    public bool focused;
    public float timer;

    public GameObject cube;

    //The method of the "IGazeFocusable" interface, which will be called when this object receives or loses focus
    public void GazeFocusChanged(bool hasFocus)
    {
        //If this object received focus, fade the object's color to highlight color
        if(hasFocus) 
        {
            focused = true;
            _targetColor = HighlightColor;
        }
        //If this object lost focus, fade the object's color to it's original color
        else
        {
            focused = false;
            _targetColor = _originalColor;
        }
    }

    private void Start()
    {
        _renderer = GetComponent<Renderer>();
        _originalColor = _renderer.material.color;
        _targetColor = _originalColor;
        focused = true;
        timer = 2.0f;


    }

    private void Update()
    {
        //This lerp will fade the color of the object
        _renderer.material.color = Color.Lerp(_renderer.material.color, _targetColor, Time.deltaTime * (1 / AnimationTime));

        while (focused == true)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                cube.SetActive(false);
            }
        }
        while (focused == false)
        {
            timer = 2.0f;
        }
    }


}