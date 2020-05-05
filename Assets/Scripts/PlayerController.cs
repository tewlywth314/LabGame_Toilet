using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] float speed;
    [SerializeField] Animator anim;
    Scene scene;
    float rotate = 180;
    float X, Y, Z;
    // Start is called before the first frame update
    void Start()
    {
        
        if (PlayerPrefs.GetInt("Ch") == 1)
        {
            X = PlayerPrefs.GetFloat("x");
            Y = PlayerPrefs.GetFloat("y");
            Z = PlayerPrefs.GetFloat("z");
            rb.transform.position = new Vector3(X, Y, Z);
            PlayerPrefs.SetInt("Ch", 0);
        }
        else
        {

        }

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F5))
        {
            PlayerPrefs.DeleteAll();
        }
        if(Input.GetKeyDown(KeyCode.I))
        {
            scene = SceneManager.GetActiveScene();
            PlayerPrefs.SetString("CS", scene.name);
            SceneManager.LoadSceneAsync("Inventory");
            X = rb.transform.position.x;
            Y = rb.transform.position.y;
            Z = rb.transform.position.z;
            PlayerPrefs.SetFloat("x", X);
            PlayerPrefs.SetFloat("y", Y);
            PlayerPrefs.SetFloat("z", Z);
        }
        if(Input.GetKey(KeyCode.D))
        {
            rb.transform.position = rb.transform.position + new Vector3( speed * Time.deltaTime,0f,0f);
            anim.SetBool("IsWalking", true);
            if (rotate != 0)
            {
                transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                rotate = 0f;
            }
            
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb.transform.position = rb.transform.position - new Vector3(speed * Time.deltaTime, 0f, 0f);
            anim.SetBool("IsWalking", true);
            if (rotate != 180)
            {
                transform.rotation = Quaternion.Euler(0f, 180f, 0f);
                rotate = 180;
            }
        }
        else
        {
            anim.SetBool("IsWalking", false);
        }

    }
        
    
}
