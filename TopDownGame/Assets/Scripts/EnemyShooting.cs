using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public AudioClip enemyshootingsfx;
    public Vector3 bulletOffset = new Vector3(0, 0.5f, 0);
    public GameObject bulletPrefab;
    private float cooldownTimer = 0;
    int bulletlayer;
    public float fireDelay = 0.50f;
    public Transform firePoint;

    public GameObject bulletprefab;

    public float bulletForce = 20f;
    Transform player;
    void Start()
    {
        bulletlayer = gameObject.layer;
    }

    void Update()
    {
        if (player == null)
        {
            //Find Player Ship

            GameObject go = GameObject.FindWithTag("Player");

            Debug.Log("Enemey is finding player");
            if (go != null)
            {
                Debug.Log("Enemey is finding player");
                player = go.transform;
            }
        }


        
    }
}
