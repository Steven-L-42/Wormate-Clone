using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouthChanger : MonoBehaviour
{
    [Header("Skin To Change")]
    [SerializeField] GameObject spriteMouth;
   
    [Header("Styles to Cycle Through")]
    public List<Sprite> SkinOptions = new List<Sprite>();

    private int currentMouth = 0;

    public void NextOptionMouth()
    {
        currentMouth++;
        if (currentMouth >= SkinOptions.Count)
        {
            currentMouth = 0;
        }
        spriteMouth.GetComponent<Image>().sprite = SkinOptions[currentMouth];
    }

    public void PrevOptionMouth()
    {
        currentMouth--;
        if (currentMouth <= 0)
        {
            currentMouth = SkinOptions.Count - 1;
        }
        spriteMouth.GetComponent<Image>().sprite = SkinOptions[currentMouth];
    }
}
