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
}
