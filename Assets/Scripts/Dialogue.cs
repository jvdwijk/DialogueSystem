using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable] public class Dialogue 
{	
	public string Name;
	public Sprite CharacterSprite;
	[TextArea(3, 5)] public string[] Sentence;
}

