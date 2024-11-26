using UnityEngine;

public class Bow : MonoBehaviour
{   
    private Rigidbody2D rb;
    private Vector2 move;
    public float speed = 5f;
    private Animator animator;
    private Vector3 direction = new Vector3(1, 0, 0);

    public Transform arrowPos;
    public GameObject prefabArrow;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        move.x = Input.GetAxis("Horizontal");
        move.y = Input.GetAxis("Vertical");

        rb.linearVelocity = move * speed;

        if (Input.GetKeyDown(KeyCode.J))
        {
            animator.SetTrigger("Shooting");
            PrefabArrow();
        }
    }
    void PrefabArrow()
    {
        Vector3 spawnPos = arrowPos.position + direction * 1;

        GameObject createdArrow = Instantiate (prefabArrow, spawnPos, Quaternion.identity);
    }
}
