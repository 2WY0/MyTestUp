using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech;

namespace MyTest
{
    //1.编写一个能够读出指定字符串的 Speaker 类，并提供两个方法，可以以不同的方式来读出字符串内容。
    class Speaker
    {
        public static void Speak(string msg)
        {
            System.Speech.Synthesis.SpeechSynthesizer ss = new System.Speech.Synthesis.SpeechSynthesizer();
            ss.Rate = 3;
            ss.Volume = 100;
            ss.Speak(msg);
        }

        public static void Speak(string msg, int rate, int vol)
        {
            System.Speech.Synthesis.SpeechSynthesizer ss = new System.Speech.Synthesis.SpeechSynthesizer();
            ss.Rate = rate;
            ss.Volume = vol;
            ss.Speak(msg);
        }

    }
}
