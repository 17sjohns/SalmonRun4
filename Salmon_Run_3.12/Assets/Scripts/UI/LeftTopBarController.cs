using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LeftTopBarController : MonoBehaviour
{
    // turn counter text
    public TextMeshProUGUI turnCounterText;

    // coin text
    public TextMeshProUGUI coinText;

    /**
     * Initialization function
     */
    private void Awake()
    {
        GameEvents.onTurnUpdated.AddListener(UpdateTopBarUI);
    }

    /**
     * Update the UI for the top bar
     * 
     * Implementation of function from IUpdatableUI interface
     */
    private void UpdateTopBarUI()
    {
        turnCounterText.text = "Turn: " + GameManager.Instance.Turn;
    }
}
