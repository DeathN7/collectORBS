using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColor : MonoBehaviour
{
    public Material mat;
    void Start()
    {
        Color[] colors = new Color[3];
        colors[0] = Color.green;
        colors[1] = Color.red;
        colors[2] = Color.blue;

        mat.color = colors[Random.Range(0, colors.Length)];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
