using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BattleUI : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI nameText;
    public Slider HpGuage;
    public GameObject BattleBoard;
 

    public void SetUI(BattleUnit unit)
    {
        nameText.text = unit.Name;
        HpGuage.maxValue = unit.MaxHp;
        HpGuage.value = unit.CurrentHp;
    }
    public void Hp(float hp)
    {
        HpGuage.value = hp;
    }
    private void Update()
    {
        if(BattleSystem.State == BattleState.ENEMYTURN)
        {
            BattleBoard.SetActive(true);
        }
        else
        {
            BattleBoard.SetActive(false);
        }
    }
  
}
