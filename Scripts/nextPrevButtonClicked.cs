using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class nextPrevButtonClicked : MonoBehaviour
{
    public Text soalFlag;
    public Text answerFlag;
    public ToggleGroup toggleGroup;
    public Toggle buttonChoiceA, buttonChoiceB,buttonChoiceC, buttonChoiceD;
    public string[] ju;
    public void updateSoalFlagNext()
    {
        int currentFlag = int.Parse(soalFlag.text);
        int resultFlag = currentFlag + 1;
        soalFlag.text = resultFlag.ToString();
        toggleGroup.SetAllTogglesOff();
        answerFlag.text = "F";
        updateRadioButtonChoices(resultFlag-1);
        
    }

    public void updateSoalFlagPrev()
    {
        int currentFlag = int.Parse(soalFlag.text);
        int resultFlag = currentFlag - 1;
        soalFlag.text = resultFlag.ToString();
        toggleGroup.SetAllTogglesOff();
        answerFlag.text = "F";
        updateRadioButtonChoices(resultFlag-1);
    }

    public void fillJawabanKubus() {
        ju = KuisKubusScript.jawabanUser;
    }

    public void fillJawabanBalok() {
        ju = KuisBalokScript.jawabanUser;
    }

    public void fillJawabanKerucut()
    {
        ju = KuisKerucutScript.jawabanUser;
    }

    public void fillJawabanTabung()
    {
        ju = KuisTabungScript.jawabanUser;
    }

    public void fillJawabanBola()
    {
        ju = KuisBolaScript.jawabanUser;
    }
    /**
    This method will update the radio button of user's choice
    **/
    void updateRadioButtonChoices(int soalFlag){
        if (ju[soalFlag].Equals("A")){
            answerFlag.text = "A";
            buttonChoiceA.isOn = true;
        } else if (ju[soalFlag].Equals("B")){
            answerFlag.text = "B";
            buttonChoiceB.isOn = true;
        } else if (ju[soalFlag].Equals("C")){
            answerFlag.text = "C";
            buttonChoiceC.isOn = true;
        } else if (ju[soalFlag].Equals("D")){
            answerFlag.text = "D";
            buttonChoiceD.isOn = true;
        }
    }    
}
