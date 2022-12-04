using Mirror;
using UnityEngine;
using UnityEngine.Networking;

public class MoveWindow : NetworkBehaviour
{
    [SyncVar]
    public Vector3 offset;
 
    public void MoveMainCamera(Transform trPlayer)
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(trPlayer.position.x, trPlayer.position.y, offset.z), 1360); // Camera follows the player with specified offset position

    }
   
}
