/**
 * Controll the camera's movement
 */
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public Vector3 initialOffset = new Vector3(0, 0, 0);

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = player.position - offset + initialOffset;
        
        if (initialOffset.y > 0)
        {
            initialOffset.y -= 0.05f;
        }
    }
}
