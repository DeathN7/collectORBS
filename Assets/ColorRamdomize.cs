using UnityEngine;

public class ColorRamdomize : MonoBehaviour
{
    public MeshRenderer meshRenderer;
    // Update is called once per frame
    void Update()
    {
        
    }

    void changeColor()
    {
        meshRenderer.material.color = Random.ColorHSV();
    }
}
