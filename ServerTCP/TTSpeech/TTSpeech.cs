using System;
using System.Speech.Synthesis;
namespace TTSpeech
{
    public class TTSpeech:MarshalByRefObject
    {
        public bool TTS(String text)
        {
            try
            {
                SpeechSynthesizer synth = new SpeechSynthesizer();
                synth.Rate = -1;
                synth.Volume = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["Volume"].ToString());
                // Configure the audio output. 
                synth.SelectVoice(System.Configuration.ConfigurationManager.AppSettings["Vocal"].ToString());
                // Speak a string.
                synth.Speak(text);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
