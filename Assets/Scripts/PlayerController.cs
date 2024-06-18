using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb;
    public Animator playerAnimator;
    public Slider lifeSlider;
    public float velocidade = 5f;
    bool isWalking = false;
    public int playerHealth = 100;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isWalking = false;
        Debug.Log("Life do Player: " + playerHealth);
    }

    // Update is called once per frame
    void Update()
    {
        float eixoX = Input.GetAxisRaw("Horizontal") * velocidade;
        float eixoY = Input.GetAxisRaw("Vertical") * velocidade;
        isWalking = eixoX != 0 || eixoY != 0;

        rb.velocity = new Vector2(eixoX, eixoY);
        Debug.Log($"Horizontal: {eixoX}, Vertical: {eixoY}");

        if (isWalking)
        {
            playerAnimator.SetFloat("eixoX", eixoX);
            playerAnimator.SetFloat("eixoY", eixoY);
        }

        playerAnimator.SetBool("isWalking", isWalking);
        lifeSlider.value = playerHealth * 0.01f;
    }
}
