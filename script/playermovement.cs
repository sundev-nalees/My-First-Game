

using UnityEngine;

public class playermovement : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float forwardForce = 2000f;
    [SerializeField] private float sidewaysForce = 500f;
    [SerializeField] private bool MoveLeft;
    [SerializeField] private bool MoveRight;
   
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        MoveLeft = false;
        MoveRight = false;
    }
    void Start()
    {
        
    }
    [SerializeField] private void PointerDownLeft()
    {
        MoveLeft = true;
    }
    [SerializeField] private void PointerUpLeft()
    {
        MoveLeft = false;
    }

    [SerializeField] private void PointerDownRight()
    {
        MoveRight = true;
    }

    [SerializeField] private void PointerUpRight()
    {
        MoveRight = false;
    }
    [SerializeField] private void update()
    {
    }
    void FixedUpdate()
    {

        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if(Input.GetKey(KeyCode.D))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

      
        
        if (MoveLeft)
        {
            Debug.Log("h");
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if(MoveRight)
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        
        
    }
   
    
    
 }
