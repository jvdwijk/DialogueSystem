using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
	//Vars
	private Queue<string> _conversation;
	//UI
	[SerializeField] private Text _nameUi;
	[SerializeField] private Text _sentenceUi;
	[SerializeField] private Image _characterImage;
	
	private void Start () 
	{
		_conversation = new Queue<string>();
	}

	public void ChangeUi()
	{
		if (_conversation.Count == 0) return;

		_sentenceUi.text = _conversation.Dequeue();
	}
	
	public void StartDialogue(Dialogue sentences)
	{
		_nameUi.text = sentences.Name;
		_characterImage.sprite = sentences.CharacterSprite;
		_conversation.Clear();
		foreach (var line in sentences.Sentence) //Do this for every var in sentences.sentence
		{
			_conversation.Enqueue(line); //add line to queue
		}
		ChangeUi();
	}
	
	//TODO: Connect scripts x
	//TODO: Change UI x
	//TODO: Animate
	//TODO: UI Functions x
	//TODO: Comment
}
