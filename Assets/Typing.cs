using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Typing : MonoBehaviour
{
    [Header("Text")]
    public Text playerName;
    public Text say;

    [Header("Delay")]
    public float textDelay;

    [Header("FinishCheck")]
    [SerializeField] bool isTypeFinish;

    void Start()
    {
        isTypeFinish = false;

        StartCoroutine(TypingAnimation("Unsama","This text is sample. \n use this code."));
    }

    IEnumerator TypingAnimation(string Name, string sayText)
    {
        playerName.text = string.Empty;
        say.text = string.Empty;

        playerName.text = Name;

        for (int i = 0; i < sayText.Length; i++)
        {
            yield return new WaitForSeconds(textDelay);
            say.text += sayText[i];
        }

        isTypeFinish = true;

        yield return 0;
    }
}
