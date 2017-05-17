﻿using System.Collections.Generic;

using UnityEngine;
using Verse;

namespace Quarry {

  public class QuarryResourceDef : Def {

    private int pctJunk = 60;
    public int JunkChance {
      get {
        // This prevents a player from setting a value too high or too low, 
        // which would cause errors when trying to spawn resources
        return Mathf.Clamp(pctJunk, 0, 100);
      }
    }

    private int pctChunks = 50;
    public int ChunkChance {
      get {
        // This prevents a player from setting a value too high or too low, 
        // which would cause errors when trying to spawn resources
        return Mathf.Clamp(pctChunks, 0, 100);
      }
    }

    public List<SimpleQuarryResource> resources;


    public IEnumerator<SimpleQuarryResource> GetEnumerator() {
      return resources.GetEnumerator();
    }
  }
}