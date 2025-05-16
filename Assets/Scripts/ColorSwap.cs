using System.Collections.Generic;
using UnityEngine;


public class ColorSwap : MonoBehaviour
{
    [SerializeField]
    Color trueColor;

    [SerializeField]
    Color falseColor;

    [SerializeField]
    SpriteRenderer sprite;

    public void SetColor(bool val)
    {
        sprite.color = val ? trueColor : falseColor;
    }
}