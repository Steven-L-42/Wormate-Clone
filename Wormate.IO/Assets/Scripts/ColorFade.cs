using System;
using UnityEngine;

public class ColorFade : MonoBehaviour
{
    [SerializeField] [Range(0f, 5f)] float fadeTime = 1;
    [SerializeField] Color[] colors;
    public SpriteRenderer sprite;
    int colorIndex = 0;
    float t = 0f;
    int len;
    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        len = colors.Length;
    }
    void Update()
    {
        
        sprite.color = Color.Lerp(sprite.color, colors[colorIndex], fadeTime*Time.deltaTime);

        t = Mathf.Lerp(t, 1f, fadeTime*Time.deltaTime);
        if (t > .9f)
        {
            t = 0f;
            colorIndex++;
            colorIndex = (colorIndex >= len) ? 0 : colorIndex;
        }
        
    }

}
