﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvailablePortals : SingletonBehavior<AvailablePortals>
{
    // The complete list of portals that the player can be rewarded
    [SerializeField]
    List<LevelObject> allPortals;

    // The list of portals that the player has been rewarded
    List<LevelObject> availablePortals = new List<LevelObject>();

    private void Start()
    {
        // If there are no available portals for the player, then let's give him the first one off the list
        if (availablePortals.Count < 1)
        {
            availablePortals.Add(allPortals[0]);
        }
    }

    public void AddPortal(LevelObject portal)
    {
        availablePortals.Add(portal);
    }

    public List<LevelObject> GetPortals()
    {
        return availablePortals;
    }
}
