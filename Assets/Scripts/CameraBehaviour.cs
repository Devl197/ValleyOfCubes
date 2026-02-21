using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{

    public Transform target;
    public float trackingOffset = 2f;
    public bool gameOver;

    // Update is called once per frame
    void LateUpdate()
    {
        if (target.position.z > transform.position.z - 3f && !gameOver)
        {
            transform.position = new Vector3(transform.position.x,
            target.position.y + trackingOffset,
            target.position.z + 3f);
        }
    }
}
