using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarbarianCustomization : MonoBehaviour
{
    public GameObject barbarianCharacter;
    public PlayerCharcter playerCharacterData;
    public Material[] barbarianSkins;

    //barabarian character clothers
    public GameObject cloth_01;
    public GameObject cloth_01_skin;
    public GameObject cloth_02;
    public GameObject cloth_02_skin;

    //barabarian character weapons
    public GameObject shield_01;
    public GameObject shield_02;

    //barabarian character shoulders
    public GameObject shoulder_01;
    public GameObject shoulder_02;

    //barabarian kneepad and legplate
    public GameObject kneePad_rightLeg;
    public GameObject kneepad_leftLeg;
    public GameObject legPlate_rightLeg;
    public GameObject legPlate_leftLeg;

    //barbarian boots
    public GameObject boot_01;
    public GameObject boot_02;

    public bool rotateModel = false;
    // Start is called before the first frame update
    void Start()
    {
        //need to update playerCharacterData
        DisableGameObjects();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            rotateModel = !rotateModel;
        }
        if(rotateModel)
        {
            barbarianCharacter.transform.Rotate(new Vector3(0, 1, 0), 30f * Time.deltaTime);
        }
        if(Input.GetKeyDown(KeyCode.L))
        {
            Debug.Log("Name");//using player prefs
        }
    }

    void DisableGameObjects()
    {
        cloth_01.SetActive(false);
        cloth_02.SetActive(false);
        cloth_01_skin.SetActive(false);
        cloth_02_skin.SetActive(false);
        shield_01.SetActive(false);
        shield_02.SetActive(false);
        shoulder_01.SetActive(false);
        shoulder_02.SetActive(false);
        kneepad_leftLeg.SetActive(false);
        kneePad_rightLeg.SetActive(false);
        legPlate_leftLeg.SetActive(false);
        legPlate_rightLeg.SetActive(false);
        boot_01.SetActive(false);
        boot_02.SetActive(false);
    }
}
