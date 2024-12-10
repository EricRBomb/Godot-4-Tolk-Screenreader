using Godot;
using DavyKager;
using System.Speech.Synthesis;


public partial class TTS : Node
{
    static SpeechSynthesizer synthesizer = new SpeechSynthesizer();
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
	{
        Tolk.Load();
    }

	public void Say(string text)
	{
		if (Tolk.DetectScreenReader() != null)
        {
            Tolk.Silence();
			Tolk.Output(text);
        }
		else
		{
            synthesizer.SpeakAsyncCancelAll();
            synthesizer.SpeakAsync(text);
        }
    }
    public void Set_rate(int val)
        {
        if (val >= -10 && val <= 10)
            {
                synthesizer.Rate = val;
            }
        }
    public bool ScreenCheck()
    {
        if (Tolk.DetectScreenReader() != null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
 
