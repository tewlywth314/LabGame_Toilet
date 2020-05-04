using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heart : MonoBehaviour
{
    public float speed;
    [SerializeField] KeyCode MoveUp;
    [SerializeField] KeyCode MoveDown;
    [SerializeField] KeyCode MoveLeft;
    [SerializeField] KeyCode MoveRight;
    public Rigidbody Rb;
    public Transform StartPos;
    public static bool isDead;
    public BattleUI playerUI;







    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    private void Update()
    {
        Move();
        
      

    }
    public  void SetHeart()
    {
        transform.position = StartPos.position;
    }
    public void Move()
    {
        if (Input.GetKey(MoveUp))
        {
            Rb.AddForce(0f, speed * Time.deltaTime, 0f, ForceMode.VelocityChange);
        }
        else
        {
            Rb.velocity = Vector3.zero;
        }
        if (Input.GetKey(MoveDown))
        {
            Rb.AddForce(0f, -1 * speed * Time.deltaTime, 0f, ForceMode.VelocityChange);
        }
        else
        {
            Rb.velocity = Vector3.zero;
        }
        if (Input.GetKey(MoveLeft))
        {
            Rb.AddForce(-1 * speed * Time.deltaTime, 0f, 0f, ForceMode.VelocityChange);
        }
        else
        {
            Rb.velocity = Vector3.zero;
        }
        if (Input.GetKey(MoveRight))
        {
            Rb.AddForce(speed * Time.deltaTime, 0f, 0f, ForceMode.VelocityChange);
        }
        else
        {
            Rb.velocity = Vector3.zero;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(EnemyAttack());
    }
    IEnumerator EnemyAttack()
    {
        isDead = BattleSystem.playerUnit.TakeDamage(BattleSystem.enemyUnit.damage);
        playerUI.Hp(BattleSystem.playerUnit.CurrentHp);

        yield return new WaitForSeconds(0.2f);
    }

}
