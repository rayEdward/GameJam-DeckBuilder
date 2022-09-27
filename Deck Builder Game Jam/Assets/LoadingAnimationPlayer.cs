using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class LoadingAnimationPlayer : MonoBehaviour
{
    [SerializeField]
    GameObject card1;
    [SerializeField]
    GameObject card2;
    [SerializeField]
    GameObject card3;

    Animator c1;
    Animator c2;
    Animator c3;

    bool c1Check = false;
    bool c2Check = false;
    bool c3Check = false;
    
    // Start is called before the first frame update
    void Start()
    {
        c1 = card1.GetComponent<Animator>();
        c2 = card2.GetComponent<Animator>();
        c3 = card3.GetComponent<Animator>();
    }

    private void OnEnable()
    {
        c1.enabled = true;
        c2.enabled = true;
        c3.enabled = true;
    }
    private void Awake()
    {
        if (c1 != null)
        {
            c1.enabled = true;
        }


        /*c1.gameObject.SetActive(true);
        c2.enabled = true;
        c3.enabled = true;
        */
    }
    // Update is called once per frame
    private void Update()
    {
        
    }
}
