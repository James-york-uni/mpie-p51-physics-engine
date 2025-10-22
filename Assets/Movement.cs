using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
        public float force = 0.0f;
        public bool thrown = false;
    // Update is called once per frame
    void Update()
    {
        float move = 0f; 
        if(!thrown) {
            if(Input.GetKey (KeyCode.A)) {
                move += 0.5f * Time.deltaTime;
            }
            if(Input.GetKey (KeyCode.D)) {
                move -= 0.5f * Time.deltaTime; 
                get
            }
            Transform t = gameObject.transform; 
            t.Translate (-move, 0f, 0f);

            if(Input.GetKey (KeyCode.W)) {
                force += 50f; 
                if(force > 100000f) {
                    force = 100000f; 
                }
            }
            else if(Input.GetKey (KeyCode.S)) {
                force -= 50f; 
                if(force < 0f) {
                    force = 0f;
                }
            }

            if(Input.GetKeyDown (KeyCode.Space)) {
                thrown = true; 
                Rigidbody rb = GetComponent<Rigidbody> ();
                rb.AddForce(new Vector3(0f, 0f, -force));
            }
        }
        if(Input.GetKeyDown (KeyCode.R)) {
                thrown = true;
            }
    }
}
