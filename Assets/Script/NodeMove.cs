using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NodeMove : MonoBehaviour
{
    public Rigidbody2D rigidBody;
    [SerializeField]
    private float moveSpeed = -10.0f;

    [SerializeField]
    private bool DamageflgP ;

    [SerializeField]
    private bool DamageflgE;

    public bool GetSetDamageflgP
    {
        get { return DamageflgP; }
        set { DamageflgP = value; }
    }
    public bool GetSetDamageflgE
    {
        get { return DamageflgE; }
        set { DamageflgE = value; }
    }

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        gameObject.SetActive(true);
        GetSetDamageflgE = false;
        GetSetDamageflgP = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveSpeed, 0, 0);
        if (transform.position.x < -20.0f && gameObject.activeSelf) 
        {
            GetSetDamageflgP = true;
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Judge") && Input.GetKeyDown(KeyCode.Return)) 
        {
            GetSetDamageflgE = true;
            Debug.Log("aaaa");
            gameObject.SetActive(false);
        }
    }
}
