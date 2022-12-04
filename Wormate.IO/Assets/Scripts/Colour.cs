using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colour : MonoBehaviour
{
    public List<Material> Mats = new List<Material>();

    void Awake()
    {
        GetComponent<Renderer>().material = Mats[Random.Range(0,Mats.Count)];
    }
}
