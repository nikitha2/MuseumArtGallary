using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonclick : MonoBehaviour
{
    public GameObject startUI, restartUI;

    public void StartPuzzle()
    {
        // Disable the start UI.
        startUI.SetActive(false);
    }

    // Reset the puzzle sequence.
    public void ResetPuzzle()
    {
        // Enable the start UI.
        startUI.SetActive(true);

        // Disable the restart UI.
        restartUI.SetActive(false);
    }
}

