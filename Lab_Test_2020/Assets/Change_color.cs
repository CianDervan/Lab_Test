using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_color : MonoBehaviour
{
    private enum LightColours
    {
        Green,
        Yellow,
        Red
    }

    private LightColours the_Colour;
    public Renderer colour_Renderer;

    private void Start()
    {
        the_Colour = (LightColours)Random.Range(0, 3);
        colour_Renderer = GetComponent<MeshRenderer>();
        StartCoroutine(change_Color());
    }

    void Update()
    {
        if (the_Colour == LightColours.Green)
        {
            colour_Renderer.material.color = Color.green;
        }
        if (the_Colour == LightColours.Yellow)
        {
            colour_Renderer.material.color = Color.yellow;
        }
        if (the_Colour == LightColours.Red)
        {
            colour_Renderer.material.color = Color.red;
        }
    }

    IEnumerator change_Color()
    {
        if (the_Colour == LightColours.Yellow)
        {
            yield return new WaitForSeconds(4);
        }
        else
        {
            yield return new WaitForSeconds(Random.Range(5, 10));
        }

        the_Colour++;

        if (the_Colour > LightColours.Red)
        {
            the_Colour = LightColours.Green;
        }

        StartCoroutine(change_Color());
    }
}

