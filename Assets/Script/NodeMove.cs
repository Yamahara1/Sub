using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NodeMove : MonoBehaviour
{
    public Rigidbody2D rigidBody;
    [SerializeField]
    private float moveSpeed = -10.0f;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveSpeed, 0, 0);
        if (transform.position.x < -20.0f && gameObject.activeSelf)
        {
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Judge")&& Input.GetKeyDown(KeyCode.Return))
        {
            gameObject.SetActive(false);
        }
    }
}
