using UnityEngine;

public class fly : MonoBehaviour
{
    
    public Rigidbody2D myRigidBody;
    public float FlapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();   
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive == true)
        {
            myRigidBody.linearVelocity = Vector2.up * FlapStrength;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
