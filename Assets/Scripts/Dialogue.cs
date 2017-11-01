using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable] public class Dialogue 
{	
	public string name;
	public Sprite characterSprite;
	[TextArea(3, 5)] public string[] sentence;
}

