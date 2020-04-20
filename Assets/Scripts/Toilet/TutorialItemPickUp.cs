using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialItemPickUp : MonoBehaviour
{
    public GameObject Player;
    [SerializeField] KeyCode PickUp;
    public GameObject mop;
    public GameObject mophand;
    public GameObject GoAheadText;
    public GameObject InteractButton;
    public GameObject MapChange;
    // Start is called before the first frame update


    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.Equals(Player))
        {
            if (Input.GetKeyDown(PickUp))
            {
                mop.SetActive(false);
                mophand.SetActive(true);
                StartCoroutine(GoAhead());
            }
        }

    }
    // Update is called once per frame
    private void Update()
    {
        
    }
    IEnumerator GoAhead()
    {
        yield return new WaitForSeconds(10);
        GoAheadText.SetActive(true);
        InteractButton.SetActive(true);
        MapChange.SetActive(true);
    }
}
