using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnZone : MonoBehaviour
{
    // Start is called before the first frame update
    private PlayerController thePlayer;
    private CameraFollow theCamera;

    public Vector2 facingDirection = Vector2.zero;
    public string placeName;
    void Start()
    {
        thePlayer = FindObjectOfType<PlayerController>();
        theCamera = FindObjectOfType<CameraFollow>();
        if (!placeName.Equals(thePlayer.nextPlaceName)){
            return;
        }
        thePlayer.transform.position = this.transform.position;
        theCamera.transform.position = new Vector3(
            this.transform.position.x,
            this.transform.position.y,
            theCamera.transform.position.z
        );
        thePlayer.lastMovement = facingDirection;
    }
}
