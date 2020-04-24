using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public enum BattleState { START, PLAYERTURN, ENEMYTURN, WON, LOST }
public class BattleSystem : MonoBehaviour
{
    public BattleState State;
    public Slider AttackGuage;
    public GameObject AttackBar;
    public GameObject player;
    public GameObject enemy;
    public GameObject AttackBut;

    public Transform PlayerPos;
    public Transform EnemyPos;

    BattleUnit playerUnit;
    BattleUnit enemyUnit;

    public BattleUI playerUI;
    public BattleUI enemyUI;

    public TextMeshProUGUI EncounterDialog;

    [SerializeField] float multiplier;
    [SerializeField] KeyCode AttackButton;
    public float ATK;
    private bool IsAttacking = false;

   
   
    // Start is called before the first frame update
    void Start()
    {
        State = BattleState.START;
        SetUpBattle();
    }

    // Update is called once per frame
   
    public void StartAttack()
    {
        if (State != BattleState.PLAYERTURN)
            return;
        AttackBar.SetActive(true);
        AttackBut.SetActive(false);
        IsAttacking = true;
        

    }
    private void Update()
    {
        AttackDamage();
    }
    public void AttackDamage()
    {
        
        AttackGuage.maxValue = 20 * multiplier;
        
        
        if (IsAttacking == true)
        {
            AttackGuage.value = Mathf.Abs(AttackGuage.maxValue * Mathf.Sin(multiplier*Time.time));
            if (Input.GetKeyDown(AttackButton)  && State==BattleState.PLAYERTURN)
            {
                ATK = AttackGuage.value;
                EncounterDialog.text = "Direct hit !!";
                IsAttacking = false;
                AttackGuage.value = ATK;
                playerUnit.damage = ATK;
                StartCoroutine(PlayerAttack());
            }
        }
       


    }
    IEnumerator PlayerAttack()
    {
       
        
        bool IsDead = enemyUnit.TakeDamage(playerUnit.damage);
        enemyUI.Hp(enemyUnit.CurrentHp);
        


        yield return new WaitForSeconds(2f);
        if (IsDead == true && IsAttacking == false)
        {
            State = BattleState.WON;

            EndBattle();
        }
        else if(IsDead == false && IsAttacking == false)
        {
            State = BattleState.ENEMYTURN;
            StartCoroutine(EnemyTurn());
        }
    }
    public void EndBattle()
    {
        if(State == BattleState.WON)
        {
            EncounterDialog.text = "You Win !!";
        }
        else if(State == BattleState.LOST)
        {
            EncounterDialog.text = "You Lose !!";
        }
    }
    IEnumerator EnemyTurn()
    {
        
        AttackBar.SetActive(false);
        EncounterDialog.text = enemyUnit.Name + "is attacking !!";
        yield return new WaitForSeconds(1f);
        bool isDead = playerUnit.TakeDamage(enemyUnit.damage);
        playerUI.Hp(playerUnit.CurrentHp);
        yield return new WaitForSeconds(2f);
        if (isDead)
        {
            State = BattleState.LOST;
            EnemyTurn();
        }
        else
        {
            State = BattleState.PLAYERTURN;
            PlayerTurn();
        }
    }
    
    void SetUpBattle()
    {
        GameObject PlayerStand = Instantiate(player, PlayerPos);
        playerUnit = PlayerStand.GetComponent<BattleUnit>();

        GameObject EnemyStand = Instantiate(enemy, EnemyPos);
        enemyUnit = EnemyStand.GetComponent<BattleUnit>();

        EncounterDialog.text = "Enemy " + enemyUnit.Name + " wants to smash you...";

        playerUI.SetUI(playerUnit);
        enemyUI.SetUI(enemyUnit);

        State = BattleState.PLAYERTURN;
        PlayerTurn();
    }
    void PlayerTurn()
    {
        EncounterDialog.text = "What am i gonna do ?";
        AttackBut.SetActive(true);
    }

}
