using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EyeChanger : MonoBehaviour
{
   
    [Header("Skin To Change")]
    [SerializeField] GameObject spriteEye;
 
    [Header("Styles to Cycle Through")]
    public List<Sprite> SkinOptions = new List<Sprite>();

    private int currentEye = 0;

    public void Start()
    {
        spriteEye.GetComponent<Image>().sprite = SkinOptions[2];    
    }

    public void NextOptionEye()
    {
        currentEye++;
        if (currentEye >= SkinOptions.Count)
        {
            currentEye = 0;
        }
        spriteEye.GetComponent<Image>().sprite = SkinOptions[currentEye];
    }

    public void PrevOptionEye()
    {
        currentEye--;
        if (currentEye <= 0)
        {
            currentEye = SkinOptions.Count - 1;
        }
        spriteEye.GetComponent<Image>().sprite = SkinOptions[currentEye];
    }
}
