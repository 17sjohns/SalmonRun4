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

    //to trigger the sealion spawning
    public SealionSpawner triggerSpawn;

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

        CheckForDam();
    }

    public void CheckForDam()
    {
        triggerSpawn.SpawnSealion();
    }
}
