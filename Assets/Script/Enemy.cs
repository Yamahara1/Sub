using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    private static int currentHP = 20;
    public Slider slider;
    NodeMove node;

    public int GetSetEnemyHP
    {
        get { return currentHP; }
        set { currentHP = value; }
    }

    // Start is called before the first frame update
    void Start()
    {
        node = gameObject.GetComponent<NodeMove>();
        // Slider�𖞃^��
        slider.value = currentHP;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)||node.GetSetDamageflgE)
        {
            // �_���[�W
            int damage = 1;

            // HP����_���[�W������
            currentHP -= damage;

            slider.value = currentHP;
            Debug.Log("bbbb");
            node.GetSetDamageflgE = false;
        }
    }
}
