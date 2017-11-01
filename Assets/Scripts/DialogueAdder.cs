using UnityEngine;
using UnityEngine.UI;

public class DialogueAdder : MonoBehaviour
{
	[SerializeField] private Dialogue[] _dialogue;
	
	public void ChooseCharacter (Dropdown person) {
		GetComponent<DialogueManager>().StartDialogue(_dialogue[person.value]);
	}	
}
