using UnityEngine;
using System.Collections;

public class ExampleScript : MonoBehaviour
{
	void OnGUI()
	{
		int y = 10;
		int stepy = 30;
		int width = 250;
		int height = 20;
		
		if(GUI.Button(new Rect(10, y, width, height), "Play Music 1"))
		{
			MusicManager.play("Dark Descent");
		}
		
		y += stepy;
		if(GUI.Button(new Rect(10, y, width, height), "Play Music 2"))
		{
			MusicManager.play("The Dark Amulet");
		}

		y += stepy;
		if(GUI.Button(new Rect(10, y, width, height), "Play Music 3"))
		{
			MusicManager.play("Dark Descent");
		}

		y += stepy;
		if(GUI.Button(new Rect(10, y, width, height), "Play Music 4"))
		{
			MusicManager.play("The Dark Amulet");
		}

		y += stepy;
		if(GUI.Button(new Rect(10, y, width, height), "Play Music 5"))
		{
			MusicManager.play("Dark Descent");
		}
		
		y += stepy;
		if(GUI.Button(new Rect(10, y, width, height), "Pause"))
		{
			MusicManager.pause();
		}
		
		y += stepy;
		if(GUI.Button(new Rect(10, y, width, height), "Unpause/Play"))
		{
			MusicManager.unpause();
		}
		
		y += stepy;
		if(GUI.Button(new Rect(10, y, width, height), "Stop the music"))
		{
			MusicManager.stop(0.0f);
		}
		
		y += stepy;
		if(GUI.Button(new Rect(10, y, width, height), "Set volume to 25%"))
		{
			MusicManager.setVolume(0.25f, 1.0f);
		}
		
		y += stepy;
		if(GUI.Button(new Rect(10, y, width, height), "Set volume to 50%"))
		{
			MusicManager.setVolume(0.50f, 1.0f);
		}

		y += stepy;
		if(GUI.Button(new Rect(10, y, width, height), "Set volume to 75%"))
		{
			MusicManager.setVolume(0.75f, 1.0f);
		}

		y += stepy;
		if(GUI.Button(new Rect(10, y, width, height), "Set volume to 100%"))
		{
			MusicManager.setVolume(1.0f, 1.0f);
		}
		
		// Debug purposes
		// Also demonstrates how to get the gameObject which hold the music
		GameObject player = MusicManager.getMusicEmitter();
		if(player.GetComponent<AudioSource>().clip != null)
		{
			GUI.Label(new Rect(20+width, 10, 200, 30), "Song playing: "+player.GetComponent<AudioSource>().clip.name);
			GUI.Label(new Rect(20+width, 40, 200, 30), "Volume: "+player.GetComponent<AudioSource>().volume);
			GUI.Label(new Rect(20+width, 70, 200, 30), "Is playing: "+player.GetComponent<AudioSource>().isPlaying);
		}
	}
}