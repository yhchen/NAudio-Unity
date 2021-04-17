using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mp3ToWavView : MonoBehaviour
{
	public Button _btnConvert;

	public InputField _mp3File;

	public InputField _wavFile;

	void Start()
	{
		_btnConvert.onClick.AddListener(() => { ConvertMp3ToWav(_mp3File.text, _wavFile.text); });
	}

	private static void ConvertMp3ToWav(string sourceFile, string desFile)
	{
		using var reader =
			new NAudio.Wave.Mp3FileReader(sourceFile);
		NAudio.Wave.WaveFileWriter.CreateWaveFile(desFile, reader);
		Debug.Log($"{sourceFile} => {desFile}");
	}
}