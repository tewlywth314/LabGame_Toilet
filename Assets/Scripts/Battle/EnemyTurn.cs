using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTurn : MonoBehaviour
{
    // Start is called before the first frame update
    public bool FinishedTurn;
    public int AttackAmounts;
    public int atkNumb;
    void Start()
    {
        FinishedTurn = false;
        atkNumb = Random.Range(1, AttackAmounts);
        GetComponent<Animator>().SetInteger("AtkDex", atkNumb);
    }
    public void AttackDone()
    {
        FinishedTurn = true;
        BattleSystem.EnemFin = BattleSystem.EnemyPat.GetComponent<EnemyTurn>().FinishedTurn;
    }

    // Update is called once per frame
    
}
