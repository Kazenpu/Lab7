using System.Collections;
using UnityEditor;
using UnityEngine;

public class Balls : MonoBehaviour
{
    public GameObject[] prefabBalls;
    private GameObject createdBall;
    public float delay;
    private Rigidbody2D rb;

    private int minX = -5;
    private int maxX = 7;
    private float y = -7f;
    private Vector2 randomPosition;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(PrefabBall());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator PrefabBall()
    {
        while (true)
        {
            int RandomX = Random.Range(minX, maxX);
            randomPosition = new Vector2(RandomX, y);

            int randomIndex = Random.Range(0, prefabBalls.Length);
            GameObject selectedPrefab = prefabBalls[randomIndex];

            createdBall = Instantiate(selectedPrefab, randomPosition, Quaternion.identity);

            yield return new WaitForSeconds(delay);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Border"))
        {
            Destroy(collision.gameObject);
        }
    }
}
