using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 4;
    public float deadZone = -31;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position += (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            Debug.Log("Pipe deleted");
            Destroy(gameObject);
        }
    }
}
