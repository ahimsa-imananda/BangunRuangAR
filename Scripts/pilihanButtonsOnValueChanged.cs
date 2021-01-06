using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pilihanButtonsOnValueChanged : MonoBehaviour
{
    public Text soalFlagStr;
    public Text textJawabanA, textJawabanB, textJawabanC, textJawabanD;
    public Text jawabanUserFlag, jawabanUserFlagInt, jawabanUserNo1Flag, jawabanUserNo2Flag, jawabanUserNo3Flag, jawabanUserNo4Flag, jawabanUserNo5Flag;
    public Text jawabanUserNo1FlagInt, jawabanUserNo2FlagInt, jawabanUserNo3FlagInt, jawabanUserNo4FlagInt, jawabanUserNo5FlagInt;

    void updateAnswerIntFlag(string answer)
    {
        
    }
    void checkFlagAnswer(int soalFlag, string answer)
    {
        if (soalFlag == 1)
        {
            jawabanUserNo1Flag.text = answer;
            if (answer.Equals("A"))
            {
                jawabanUserNo1FlagInt.text = textJawabanA.text;
            }
            else if (answer.Equals("B"))
            {
                jawabanUserNo1FlagInt.text = textJawabanB.text;
            }
            else if (answer.Equals("C"))
            {
                jawabanUserNo1FlagInt.text = textJawabanC.text;
            }
            else if (answer.Equals("D"))
            {
                jawabanUserNo1FlagInt.text = textJawabanD.text;
            }
        }
        else if (soalFlag == 2)
        {
            jawabanUserNo2Flag.text = answer;
            if (answer.Equals("A"))
            {
                jawabanUserNo2FlagInt.text = textJawabanA.text;
            }
            else if (answer.Equals("B"))
            {
                jawabanUserNo2FlagInt.text = textJawabanB.text;
            }
            else if (answer.Equals("C"))
            {
                jawabanUserNo2FlagInt.text = textJawabanC.text;
            }
            else if (answer.Equals("D"))
            {
                jawabanUserNo2FlagInt.text = textJawabanD.text;
            }
        }
        else if (soalFlag == 3)
        {
            jawabanUserNo3Flag.text = answer;
            if (answer.Equals("A"))
            {
                jawabanUserNo3FlagInt.text = textJawabanA.text;
            }
            else if (answer.Equals("B"))
            {
                jawabanUserNo3FlagInt.text = textJawabanB.text;
            }
            else if (answer.Equals("C"))
            {
                jawabanUserNo3FlagInt.text = textJawabanC.text;
            }
            else if (answer.Equals("D"))
            {
                jawabanUserNo3FlagInt.text = textJawabanD.text;
            }
        }
        else if (soalFlag == 4)
        {
            jawabanUserNo4Flag.text = answer;
            if (answer.Equals("A"))
            {
                jawabanUserNo4FlagInt.text = textJawabanA.text;
            }
            else if (answer.Equals("B"))
            {
                jawabanUserNo4FlagInt.text = textJawabanB.text;
            }
            else if (answer.Equals("C"))
            {
                jawabanUserNo4FlagInt.text = textJawabanC.text;
            }
            else if (answer.Equals("D"))
            {
                jawabanUserNo4FlagInt.text = textJawabanD.text;
            }
        }
        else if (soalFlag == 5)
        {
            jawabanUserNo5Flag.text = answer;
            if (answer.Equals("A"))
            {
                jawabanUserNo5FlagInt.text = textJawabanA.text;
            }
            else if (answer.Equals("B"))
            {
                jawabanUserNo5FlagInt.text = textJawabanB.text;
            }
            else if (answer.Equals("C"))
            {
                jawabanUserNo5FlagInt.text = textJawabanC.text;
            }
            else if (answer.Equals("D"))
            {
                jawabanUserNo5FlagInt.text = textJawabanD.text;
            }
        }
    }

    public void pilihanAToggled()
    {
        int soalFlag = int.Parse(soalFlagStr.text);
        jawabanUserFlag.text = "A";
        jawabanUserFlagInt.text = textJawabanA.text;
        checkFlagAnswer(soalFlag, "A");
    }

   public void pilihanBToggled()
    {
        int soalFlag = int.Parse(soalFlagStr.text);
        jawabanUserFlag.text = "B";
        jawabanUserFlagInt.text = textJawabanB.text;
        checkFlagAnswer(soalFlag, "B");
    }

    public void pilihanCToggled()
    {
        int soalFlag = int.Parse(soalFlagStr.text);
        jawabanUserFlag.text = "C";
        jawabanUserFlagInt.text = textJawabanC.text;
        checkFlagAnswer(soalFlag, "C");
    }

    public void pilihanDToggled()
    {
        int soalFlag = int.Parse(soalFlagStr.text);
        jawabanUserFlag.text = "D";
        jawabanUserFlagInt.text = textJawabanD.text;
        checkFlagAnswer(soalFlag, "D");
    }
}
