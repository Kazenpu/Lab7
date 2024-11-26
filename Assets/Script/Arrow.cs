using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private Vector3 direction = new Vector3(1, 0, 0);
    void Start()
    {   
        rb = GetComponent<Rigidbody2D>();
        Destroy (gameObject, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity = speed * direction;
    }
}
