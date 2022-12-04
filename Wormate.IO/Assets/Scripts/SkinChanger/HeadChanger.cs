using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeadChanger : MonoBehaviour
{
  
    [Header("Skin To Change")]
    [SerializeField] GameObject spriteHead;

    [Header("Styles to Cycle Through")]
    public List<Sprite> SkinOptions = new List<Sprite>();

    private int currentHead = 0;
 
    public void NextOptionHead()
    {
        currentHead++;
        if (currentHead >= SkinOptions.Count)
        {
            currentHead = 0;
        }
        spriteHead.GetComponent<Image>().sprite = SkinOptions[currentHead];
    }

    public void PrevOptionHead()
    {
        currentHead--;
        if (currentHead <= 0)
        {
            currentHead = SkinOptions.Count - 1;
        }
        spriteHead.GetComponent<Image>().sprite = SkinOptions[currentHead];
    }
}
