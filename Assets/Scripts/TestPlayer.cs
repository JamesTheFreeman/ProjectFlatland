using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPlayer : MonoBehaviour
{

    public Vector2 moveDirection;

    public int defense;
    public int attack;
    public int health;

    // Start is called before the first frame update
    void Start() {
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0) {
            // End Game
            Debug.Log("Player Died");
        }
        
    }

    private void FixedUpdate()
    {

        // Get user input
        if (Input.GetKey(KeyCode.W))
        {
            moveDirection += Vector2.up;
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveDirection += Vector2.down;
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveDirection += Vector2.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveDirection += Vector2.right;
        }

        // Move Player in accordance to input
        this.transform.position = new Vector3(
            this.transform.position.x + moveDirection.x / 3,
            this.transform.position.y + moveDirection.y / 3,
            0.0f
        );


        // Reset Player direction
        moveDirection = Vector2.zero;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check for collision with an enemy and calls calcDamage
        if (collision.tag == "Enemy") {
            Debug.Log("Smack");
            calcDamage(collision.gameObject.GetComponent<TestEnemy>().attack);
        }
    }

    private void calcDamage(int enemAtk) {
        // Calculate damage reduction percentage
        float damReduc = Mathf.Floor(-25 + 16 * Mathf.Log(defense + 4.772f)) / 100;
        // Calculate the amount of damage left over after damage reduction is factored
        int damage = (int) Mathf.Round(enemAtk * (1 - damReduc));
        // Subtract the calculated damage from player health
        health -= damage;
    }
}
