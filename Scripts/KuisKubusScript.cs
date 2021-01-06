using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KuisKubusScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Text soalText;
    public Text textNomerSoal;
    public Button buttonNext;
    public Button buttonPrevious;
    public Button buttonSubmit;
    public Text soalFlagStr;
    public Text jawabanUserFlag, jawabanUserFlagInt, jawabanUserNo1Flag, jawabanUserNo2Flag, jawabanUserNo3Flag, jawabanUserNo4Flag, jawabanUserNo5Flag;
    public Text scoreFlag;
    public Text nilaiKuis;
    public Text jawabanUserText1, jawabanUserText2, jawabanUserText3, jawabanUserText4, jawabanUserText5;
    public Text jawabanBenarText1, jawabanBenarText2, jawabanBenarText3, jawabanBenarText4, jawabanBenarText5;
    public Text nilaiUserText1, nilaiUserText2, nilaiUserText3, nilaiUserText4, nilaiUserText5;
    private string[] soalKubus = { "Soal Kubus 1", "Soal Kubus 2", "Soal Kubus 3", "Soal Kubus 4", "Soal Kubus 5", "Soal Kubus 6", "Soal Kubus 7", "Soal Kubus 8", "Soal Kubus 9", "Soal Kubus 10" };
    public Button buttonNavSoal1, buttonNavSoal2, buttonNavSoal3, buttonNavSoal4, buttonNavSoal5;
    public Toggle buttonChoiceA, buttonChoiceB,buttonChoiceC, buttonChoiceD;
    public ToggleGroup toggleGroup; 
    public Text textJawabanA, textJawabanB, textJawabanC, textJawabanD;
    public Text jawabanUserNo1FlagInt, jawabanUserNo2FlagInt, jawabanUserNo3FlagInt, jawabanUserNo4FlagInt, jawabanUserNo5FlagInt;
    private string[] soalKuis;
    private string[] jawabanSoal1;
    private string[] jawabanSoal2;
    private string[] jawabanSoal3;
    private string[] jawabanSoal4;
    private string[] jawabanSoal5;
    private string[] kunciJawabanSoal;
    private string[] kunciJawabanSoalInt;
    private int[] nilaiUser;
    private string[] jawabanUserRecap;
    public static string[] jawabanUser;
    void Start()
    {
        nilaiUser = new int[5];
        jawabanUserRecap = new string[5];
        buttonSubmit.enabled = false;
        soalFlagStr.text = "1";
        jawabanUser = new string[5];
        jawabanUser[0] = "F";
        jawabanUser[1] = "F";
        jawabanUser[2] = "F";
        jawabanUser[3] = "F";
        jawabanUser[4] = "F";
        //createRandomSoal();
        createRandomSoalKubus();

    }

    // Update is called once per frame
    void Update()
    {
        stateKuisPlaying();
        checkUsersChoice();
        saveUsersChoice();
        verifyUserAnswer(jawabanUser, kunciJawabanSoal);
        fillRecapPanel();
    }

    void createRandomSoalKubus()
    {
        soalKuis = new string[5];
        System.Random rnd = new System.Random();

        int rand1Soal1 = rnd.Next(1, 30);

        string soal1 = "Hitung volume kubus yang memiliki panjang rusuk sebesar " + rand1Soal1 + " cm" + " !";
        double jawabanSoal1DB = calculateJawabanVolumeKubus(rand1Soal1);

        int rand1Soal2 = rnd.Next(1, 30);

        string soal2 = "Berapa luas permukaan sebuah kubus yang memiliki panjang rusuk sebesar " + rand1Soal2 + "cm ?";
        double jawabanSoal2DB = calculateJawabanLuasPermukaanKubus(rand1Soal2);

        int rand1Soal3 = generateRandomVolumeKubus();

        string soal3 = "Berapa panjang rusuk sebuah kubus yang memiliki volume sebesar " + rand1Soal3 + " ?";
        double jawabanSoal3DB = calculateJawabanRusuk(rand1Soal3);

        int rand1Soal4 = rnd.Next(2, 30);

        string soal4 = "Hitunglah hasil penjumlahan dari volume dan luas permukaan sebuah kubus yang memiliki panjang rusuk sebesar " + rand1Soal4 + "cm !";
        double jawabanSoal4DB = calculateJawabanVolumePlusLP(rand1Soal4);

        string soal5 = "Berapa jumlah titik sudut yang dimiliki bangun ruang kubus?";
        double jawabanSoal5DB = 8;

        soalKuis[0] = soal1;
        soalKuis[1] = soal2;
        soalKuis[2] = soal3;
        soalKuis[3] = soal4;
        soalKuis[4] = soal5;
        createRandomJawabanKubus(rand1Soal1, rand1Soal2, rand1Soal4, jawabanSoal1DB, jawabanSoal2DB, jawabanSoal3DB, jawabanSoal4DB, jawabanSoal5DB);
    }

    /**
    *This method will calculate the answer for cube's volume
    *
    */
    double calculateJawabanVolumeKubus(int rusuk) {
        int result = rusuk * rusuk * rusuk;
        return result;
    }

    /**
    *This method will calculate the answer for cube's volume + Luas permukaan
    *
    */
    double calculateJawabanVolumePlusLP(int rusuk)
    {
        double result = calculateJawabanVolumeKubus(rusuk) + calculateJawabanLuasPermukaanKubus(rusuk);
        return result;
    }


    /**
    *This method will calculate the answer for cube's Luas permukaan
    *
    */
    double calculateJawabanLuasPermukaanKubus(int rusuk)
    {
        int result = 6 * rusuk * rusuk;
        return result;
    }

    /**
    *This method will calculate the answer for cube's Luas permukaan
    *
    */
    double calculateJawabanRusuk(int volume)
    {
        double result = System.Math.Pow(volume, 1.0 / 3.0);
        return result;
    }

    /**
     * This method will generate random cube's volume
     */ 
    int generateRandomVolumeKubus()
    {
        System.Random rnd = new System.Random();
        int number = rnd.Next(1, 10);
        int result = 2700;
        switch (number)
        {
            case 1:
                result = 1000;
                break;
            case 2:
                result = 125;
                break;
            case 3:
                result = 27;
                break;
            case 4:
                result = 2197;
                break;
            case 5:
                result = 216;
                break;
            case 6:
                result = 15625;
                break;
            case 7:
                result = 8000;
                break;
            case 8:
                result = 19683;
                break;
            case 9:
                result = 6859;
                break;
            case 10:
                result = 729;
                break;

        }
        return result;
    }

    /**
     * This method will create random extra multiple choices for Cube's Quiz
     */
    void createRandomJawabanKubus(int rusuk1, int rusuk2, int rusuk3, double jawabanSoal1DB, double jawabanSoal2DB, double jawabanSoal3DB, double jawabanSoal4DB, double jawabanSoal5DB) {
        kunciJawabanSoal = new string[5];
        kunciJawabanSoalInt = new string[5];

        kunciJawabanSoalInt[0] = jawabanSoal1DB.ToString("0.##");
        kunciJawabanSoalInt[1] = jawabanSoal2DB.ToString("0.##");
        kunciJawabanSoalInt[2] = jawabanSoal3DB.ToString("0.##");
        kunciJawabanSoalInt[3] = jawabanSoal4DB.ToString("0.##");
        kunciJawabanSoalInt[4] = jawabanSoal5DB.ToString("0.##");

        jawabanSoal1 = new string[4];
        jawabanSoal2 = new string[4];
        jawabanSoal3 = new string[4];
        jawabanSoal4 = new string[4];
        jawabanSoal5 = new string[4];

        jawabanSoal1[0] = jawabanSoal1DB.ToString("0.##");
        jawabanSoal1[1] = (jawabanSoal1DB + 2).ToString("0.##");
        jawabanSoal1[2] = (jawabanSoal1DB - 1).ToString("0.##");
        jawabanSoal1[3] = (jawabanSoal1DB + 1).ToString("0.##");

        jawabanSoal2[0] = jawabanSoal2DB.ToString("0.##");
        jawabanSoal2[1] = (jawabanSoal2DB + 3).ToString("0.##");
        jawabanSoal2[2] = (jawabanSoal2DB + 1).ToString("0.##");
        jawabanSoal2[3] = (jawabanSoal2DB - 3).ToString("0.##");

        jawabanSoal3[0] = jawabanSoal3DB.ToString("0.##");
        jawabanSoal3[1] = (jawabanSoal3DB - 2).ToString("0.##");
        jawabanSoal3[2] = (jawabanSoal3DB + 5).ToString("0.##");
        jawabanSoal3[3] = (jawabanSoal3DB + 2).ToString("0.##");

        jawabanSoal4[0] = jawabanSoal4DB.ToString("0.##");
        jawabanSoal4[1] = (jawabanSoal4DB + rusuk3).ToString("0.##");
        jawabanSoal4[2] = (jawabanSoal4DB - rusuk3).ToString("0.##");
        jawabanSoal4[3] = (jawabanSoal4DB / rusuk3).ToString("0.##");

        jawabanSoal5[0] = jawabanSoal5DB.ToString("0.##");
        jawabanSoal5[1] = (jawabanSoal5DB - 4).ToString("0.##");
        jawabanSoal5[2] = (jawabanSoal5DB + 4).ToString("0.##");
        jawabanSoal5[3] = (jawabanSoal5DB + 1).ToString("0.##");

        Randomize(jawabanSoal1);

        Randomize(jawabanSoal2);
        Randomize(jawabanSoal2);

        Randomize(jawabanSoal3);
        Randomize(jawabanSoal3);
        Randomize(jawabanSoal3);

        Randomize(jawabanSoal4);
        Randomize(jawabanSoal4);
        Randomize(jawabanSoal4);
        Randomize(jawabanSoal4);

        Randomize(jawabanSoal5);
        Randomize(jawabanSoal5);
        Randomize(jawabanSoal5);
        Randomize(jawabanSoal5);
        Randomize(jawabanSoal5);

        kunciJawabanSoal[0] = createKunciJawaban(jawabanSoal1, jawabanSoal1DB);
        kunciJawabanSoal[1] = createKunciJawaban(jawabanSoal2, jawabanSoal2DB);
        kunciJawabanSoal[2] = createKunciJawaban(jawabanSoal3, jawabanSoal3DB);
        kunciJawabanSoal[3] = createKunciJawaban(jawabanSoal4, jawabanSoal4DB);
        kunciJawabanSoal[4] = createKunciJawaban(jawabanSoal5, jawabanSoal5DB);
    }

    /**
    This method will check where is the actual answer from the question
    on each multiple choices
    **/
    string createKunciJawaban(string[] jawabanArr, double actualJawaban){
        string result = "";
        string strActualJawaban = actualJawaban.ToString("0.##");
        if(jawabanArr[0].Equals(strActualJawaban)){
            result = "A";
        } else if (jawabanArr[1].Equals(strActualJawaban)){
            result = "B";
        } else if (jawabanArr[2].Equals(strActualJawaban)){
            result = "C";
        } else if (jawabanArr[3].Equals(strActualJawaban)){
            result = "D";
        }
        return result;
    }

    void fillJawabanButtonText(string[] jawabanArr){
        textJawabanA.text = "A. " + jawabanArr[0];
        textJawabanB.text = "B. " + jawabanArr[1];
        textJawabanC.text = "C. " + jawabanArr[2];
        textJawabanD.text = "D. " + jawabanArr[3];

    }

    void Randomize<T>(T[] array)
    {
        System.Random rng = new System.Random();
        int n = array.Length;
        while (n > 1) 
        {
            int k = rng.Next(n--);
            T temp = array[n];
            array[n] = array[k];
            array[k] = temp;
        }
    }

    /**
     * This method will fill the recap panel accordingly
     */
    void fillRecapPanel() {
        jawabanUserText1.text = jawabanUserRecap[0];
        jawabanUserText2.text = jawabanUserRecap[1];
        jawabanUserText3.text = jawabanUserRecap[2];
        jawabanUserText4.text = jawabanUserRecap[3];
        jawabanUserText5.text = jawabanUserRecap[4];

        jawabanBenarText1.text = kunciJawabanSoalInt[0];
        jawabanBenarText2.text = kunciJawabanSoalInt[1];
        jawabanBenarText3.text = kunciJawabanSoalInt[2];
        jawabanBenarText4.text = kunciJawabanSoalInt[3];
        jawabanBenarText5.text = kunciJawabanSoalInt[4];

        nilaiUserText1.text = nilaiUser[0].ToString();
        nilaiUserText2.text = nilaiUser[1].ToString();
        nilaiUserText3.text = nilaiUser[2].ToString();
        nilaiUserText4.text = nilaiUser[3].ToString();
        nilaiUserText5.text = nilaiUser[4].ToString();

        int nilaiFinal = nilaiUser[0] + nilaiUser[1] + nilaiUser[2] + nilaiUser[3] + nilaiUser[4];
        nilaiKuis.text = nilaiFinal.ToString();
    }

    /**
    This method will check which multiple choice the user chose
    **/
    void checkUsersChoice(){
        int soalFlag = int.Parse(soalFlagStr.text);
        if (buttonChoiceA.isOn)
        {
            jawabanUserFlag.text = "A";
            jawabanUserFlagInt.text = textJawabanA.text;
            checkFlagAnswer(soalFlag, "A");
        } else if (buttonChoiceB.isOn)
        {
            jawabanUserFlag.text = "B";
            jawabanUserFlagInt.text = textJawabanB.text;
            checkFlagAnswer(soalFlag, "B");
        } else if (buttonChoiceC.isOn)
        {
            jawabanUserFlag.text = "C";
            jawabanUserFlagInt.text = textJawabanC.text;
            checkFlagAnswer(soalFlag, "C");
        } else if (buttonChoiceD.isOn)
        {
            jawabanUserFlag.text = "D";
            jawabanUserFlagInt.text = textJawabanD.text;
            checkFlagAnswer(soalFlag, "D");
        }
        /**buttonChoiceA.onValueChanged.AddListener(delegate{
            jawabanUserFlag.text = "A";
            jawabanUserFlagInt.text = textJawabanA.text;
            checkFlagAnswer(soalFlag, "A");
        });
        buttonChoiceB.onValueChanged.AddListener(delegate{
            jawabanUserFlag.text = "B";
            jawabanUserFlagInt.text = textJawabanB.text;
            checkFlagAnswer(soalFlag, "B");
        });
        buttonChoiceC.onValueChanged.AddListener(delegate{
            jawabanUserFlag.text = "C";
            jawabanUserFlagInt.text = textJawabanC.text;
            checkFlagAnswer(soalFlag, "C");
        });
        buttonChoiceD.onValueChanged.AddListener(delegate{
            jawabanUserFlag.text = "D";
            jawabanUserFlagInt.text = textJawabanD.text;
            checkFlagAnswer(soalFlag, "D");
        }); */
        
        
    }

    void checkFlagAnswer(int soalFlag, string answer) {
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
        else if (soalFlag == 2) {
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
        } else if (soalFlag == 3)
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
        } else if (soalFlag == 4)
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
        } else if (soalFlag == 5)
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

    /**
    This method will save user's choice of answer
    and update the radio button accordingly
    **/
    void saveUsersChoice(){
        jawabanUser[0] = jawabanUserNo1Flag.text;
        jawabanUserRecap[0] = jawabanUserNo1FlagInt.text;

        jawabanUser[1] = jawabanUserNo2Flag.text;
        jawabanUserRecap[1] = jawabanUserNo2FlagInt.text;

        jawabanUser[2] = jawabanUserNo3Flag.text;
        jawabanUserRecap[2] = jawabanUserNo3FlagInt.text;

        jawabanUser[3] = jawabanUserNo4Flag.text;
        jawabanUserRecap[3] = jawabanUserNo4FlagInt.text;

        jawabanUser[4] = jawabanUserNo5Flag.text;
        jawabanUserRecap[4] = jawabanUserNo5FlagInt.text;

    }

    /**
    This method will verify user's choice with the correct answer
    Score will be added if corret answer is chosen.
    **/
    void verifyUserAnswer(string[] jawabanAsli, string[] jawabanPengguna){
        for (int i =0; i < 5; i++) {
            if (jawabanPengguna[i].Equals(jawabanAsli[i]))
            {
                nilaiUser[i] = 20;
            }
            else {
                nilaiUser[i] = 0;
            }
        }
    }

    /**
    This method will update the radio button of user's choice
    **/
    void updateRadioButtonChoices(int soalFlag){
        if (jawabanUser[soalFlag].Equals("A")){
            jawabanUserFlag.text = "A";
            buttonChoiceA.isOn = true;
        } else if (jawabanUser[soalFlag].Equals("B")){
            jawabanUserFlag.text = "B";
            buttonChoiceB.isOn = true;
        } else if (jawabanUser[soalFlag].Equals("C")){
            jawabanUserFlag.text = "C";
            buttonChoiceC.isOn = true;
        } else if (jawabanUser[soalFlag].Equals("D")){
            jawabanUserFlag.text = "D";
            buttonChoiceD.isOn = true;
        }
    }

    void stateKuisPlaying() {
        // Condition untuk flag button
        int soalFlag = int.Parse(soalFlagStr.text) - 1;
        Debug.Log("Soal 1:" + jawabanUser[0]);
        Debug.Log("Soal 2: " + jawabanUser[1]);
        Debug.Log("Soal 3: " + jawabanUser[2]);
        Debug.Log("Soal 4: " + jawabanUser[3]);
        Debug.Log("Soal 5: " + jawabanUser[4]);
        //saveUsersChoice(soalFlag);
        if (soalFlag == 0)
        {

            buttonPrevious.enabled = false;
        }
        else
        {
            buttonPrevious.enabled = true;
        }

        if (soalFlag == 4)
        {
            buttonNext.enabled = false;
            buttonSubmit.enabled = true;
        }
        else
        {
            buttonSubmit.enabled = false;
            buttonNext.enabled = true;
        }

        //Condition untuk mengganti Soal dan pilihan jawaban
        if (soalFlag == 0)
        {
            
            soalText.text = soalKuis[0];
            fillJawabanButtonText(jawabanSoal1);
        }
        else if (soalFlag == 1)
        {   
            soalText.text = soalKuis[1];
            fillJawabanButtonText(jawabanSoal2);
        }
        else if (soalFlag == 2)
        {
            soalText.text = soalKuis[2];
            fillJawabanButtonText(jawabanSoal3);
        }
        else if (soalFlag == 3)
        {
            soalText.text = soalKuis[3];
            fillJawabanButtonText(jawabanSoal4);
        }
        else if (soalFlag == 4)
        {
            soalText.text = soalKuis[4];
            fillJawabanButtonText(jawabanSoal5);
        }
        

        //Condition untuk menghandle navigasi pengguna
        buttonNavSoal1.onClick.AddListener(delegate {
            //toggleGroup.SetAllTogglesOff();
            soalFlagStr.text = "1";
            jawabanUserFlag.text = "F";
            updateRadioButtonChoices(0);
        });

        buttonNavSoal2.onClick.AddListener(delegate {
            //toggleGroup.SetAllTogglesOff();
            soalFlagStr.text = "2";
            jawabanUserFlag.text = "F";
            updateRadioButtonChoices(1);
        });

        buttonNavSoal3.onClick.AddListener(delegate {
            //toggleGroup.SetAllTogglesOff();
            soalFlagStr.text = "3";
            jawabanUserFlag.text = "F";
            updateRadioButtonChoices(2);
        });

        buttonNavSoal4.onClick.AddListener(delegate {
            //toggleGroup.SetAllTogglesOff();
            soalFlagStr.text = "4";
            jawabanUserFlag.text = "F";
            updateRadioButtonChoices(3);
        });

        buttonNavSoal5.onClick.AddListener(delegate {
            //toggleGroup.SetAllTogglesOff();
            soalFlagStr.text = "5";
            jawabanUserFlag.text = "F";
            updateRadioButtonChoices(4);
        });
    }


}
