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
	[SerializeField] private Sprite _characterImage;
	
	private void Start () 
	{
		_conversation = new Queue<string>();
	}

	public void StartDialogue(Dialogue sentences)
	{
		print(_nameUi);
		_nameUi.text = sentences.name;
		_characterImage = sentences.characterSprite;
		_conversation.Clear();
		foreach (var line in sentences.sentence) //Do this for every var in sentences.sentence
		{
			_conversation.Enqueue(line); //add line to queue
		}
		ChangeUi();
	}

	public void ChangeUi()
	{
		if (_conversation.Count == 0) return;

		var sentence = _conversation.Dequeue();
		_sentenceUi.text = sentence;
	}
	
	//TODO: Connect scripts x
	//TODO: Change UI x
	//TODO: Animate
	//TODO: UI Functions x
	//TODO: Comment
}
