
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public static bool gameHasEnded;

    public AnimationCurve DistanceVersusSpeed;
    // public float thrust;
    public Rigidbody rb;
   
    public Transform target;
    public float flashTime;

    public Color origionalColor;
    public MeshRenderer renderer;


    public static int POINT=0;
    public static int badPoint=0;


    public static int whiteNoHappened=0;
    public  bool alreadyDone = false;
    public static int badScore = 0;
    public  bool alreadyBadDone = false;

    // public float speed=0;        //Speed, updated through script
    public static float acceleration=5000f; //Every second, the speed will increase by this much
    private float _initialDistanceToTarget;
    public static float speed=4180f;
    private float _distanceToTarget;

  
    // Start is called before the first frame update
    void Start()
    {
       
        //speed = 0;
        _initialDistanceToTarget = (target.position - transform.position).magnitude;
        //Debug.Log("wait .2f");
        //new WaitForSeconds(0.2f);
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
     
        //  transform.rotation = Quaternion.RotateTowards(transform.rotation, target, 1 * Time.deltaTime);




        if (POINT >= 10)
        {
            new WaitForSeconds(2.2f);
            //FindObjectOfType<GameManager>().Awake();
            FindObjectOfType<PauseMenu>().YouWon();

        }
        Debug.Log("YOU WON UPDATE");

    }

    // Update is called once per frame
    void FixedUpdate()
    {
           Debug.Log("move toward position");
        speed += Time.deltaTime * acceleration;

        rb.AddForce((target.position - transform.position)*3.234f);
        //Add acceleration to speed, make sure it's not above topSpeed)
        Debug.Log("move toward position");
        //  rb.AddForce(target.position - transform.position);      
        // Calculate our distance from target
        Vector3 deltaPosition = target.position - transform.position;
        _distanceToTarget = deltaPosition.magnitude;

        // Update our speed based on our distance from the target
        speed = DistanceVersusSpeed.Evaluate((_initialDistanceToTarget * _distanceToTarget) * _initialDistanceToTarget);

        // If we need to move father than we can in this update, then limit how much we move
      //  if (_distanceToTarget < speed)
      //      deltaPosition = deltaPosition.normalized * speed;

        // Set our position
        transform.position += deltaPosition * speed * Time.deltaTime;




    }

    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Destroyd");

        if (col.collider.tag == ("Player"))
        {
            // WaitForSeconds(0.2f);

            MakeBlue();
            //ResetColor();
            Vector3 velocity = GetComponent<Rigidbody>().velocity;
            velocity.y = 22.0f;
            //velocity.z = -35.0f;
            // velocity. = -35.0f;
            rb.velocity = -transform.forward * speed;
            GetComponent<Rigidbody>().velocity = velocity;
            GetComponent<Rigidbody>().AddForce(Vector3.forward);


             //  FindObjectOfType<GameManager>().EndGame().gameHasEnded;
            //bool  GAMEOVER = gameHasEnded;



            // if (GAMEOVER = true)
            // {
            //     GetComponent<Rigidbody>().velocity = 0;
            //     GetComponent<Rigidbody>().velocity = Vector3.zero;
            //     GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            // }




            // GetComponent<Collider>().enabled = false;

            // if (rb.velocity < 10)
            // { rb.AddForce(Vector3.right * speed, forcemode3d.Impulse); }
            // else
            // {
            //     rb.AddForce(Vector3.right * speed * Time.deltaTime);
            //

            if (!alreadyDone)
            {
                alreadyDone = true;
           
                POINT++;
            }

        }



        if (col.collider.tag == ("BadPoint")&&(!alreadyDone))
        {
            if (!alreadyBadDone)
            {
                alreadyBadDone = true;

                badScore++;
            }

        }


    }


    void MakeBlue()
    {
     
        renderer.material.color = new Color(1.0f, 1, 1);
        //whiteHappened == true;
       
    }


   // void ResetColor()
   // {
   //     renderer.material.color = new Color(5f, 1,5 ); 
   // }
   // 
}
