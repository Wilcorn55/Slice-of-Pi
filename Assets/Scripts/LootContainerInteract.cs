using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootContainerInteract : Interactable
{
    //Variables
    [SerializeField] GameObject closedChest;
    [SerializeField] GameObject openedChest;
    [SerializeField] GameObject PaperPuzzle;
    [SerializeField] bool opened;
    [SerializeField] bool HasPuzzle;
    public static bool GameIsPaused = false;

    //Interact will open a chest or loot container
    public override void Interact(Character character)
    {
        if (opened == false) 
        {
            opened = true;
            closedChest.SetActive(false);
            openedChest.SetActive(true);
        }

        if (HasPuzzle == true)
        {
            if (GameIsPaused)
            {
                PaperPuzzle.SetActive(false);
                Time.timeScale = 1f;
                GameIsPaused = false;
            }
            else
            {
                PaperPuzzle.SetActive(true);
                Time.timeScale = 1f;
                GameIsPaused = true;
            }
        }
    }
}
