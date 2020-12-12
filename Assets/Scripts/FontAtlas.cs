﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class FontChar {
    public Vector2 texPos;
    public Vector2 size;
}

[System.Serializable]
public class BracketChar {
    public string name;
    public int index;
}

[CreateAssetMenu(fileName = "FontAtlas", menuName = "ScriptableObjects/Font Atlas", order = 1)]
public class FontAtlas : ScriptableObject
{
   
    public List<string> keys;
    
      public List<FontChar> fontChars;
      
      public List<FontChar> redSlotsChars,blueSlotsChars;

      public List<BracketChar> bracketChars;

      public Texture tex;

    public FontChar FetchFontChar(string key)
    {
        return fontChars[keys.IndexOf(key)];
    }

}
