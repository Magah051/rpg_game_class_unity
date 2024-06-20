using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform waypointA;
    public Transform waypointB;
    public float movementeSpeed = 2f;
    private Animator animator;
    private bool isWalking = false;

    private Transform currentTarget;
    private Rigidbody2D rb;
    private Vector3 scale;

    public int enemyHealth = 50;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
