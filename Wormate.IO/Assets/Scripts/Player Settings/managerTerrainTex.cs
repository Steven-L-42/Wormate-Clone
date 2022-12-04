using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class managerTerrainTex : MonoBehaviour
{
    public Transform trPlayer;
    public Renderer renderTerrain;

    public float speedH;
    public float SpeedW;

    void Update()
    {
        transform.position = new Vector3(trPlayer.position.x, trPlayer.position.y, trPlayer.position.z);
        renderTerrain.material.mainTextureOffset = new Vector3(trPlayer.position.x, trPlayer.position.y * speedH, trPlayer.position.z) * SpeedW;

    }
}
