using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite;
using System.Data;
using System.IO;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UsersScript : MonoBehaviour
{
    private db_controller _dbctrl = new db_controller();
    private NextSceneScript nextScene = new NextSceneScript();
    private EnableAndDisableScript enableAndDisableScript = new EnableAndDisableScript();
    private SqliteDataReader dataread;
    private SqliteDataReader dataread2;
    private StringScripts stringScripts = new StringScripts();
    private string query;
    private string querycheck;
    private string queryget;
    private string uName;
    private string fName;
    private string mName;
    private string lName;

    public InputField userNameLoginInput;
    public InputField userNameInput;
    public InputField firstNameInput;
    public InputField middleNameInput;
    public InputField lastNameInput;
    public Text text;
    public GameObject gameObject;

    public static string Userid
    {
        get;
        private set;
    }

    //// Use this for initialization
    //private void OldUser()
    //{
    //    fName = stringScripts.StringToLower(firstNameInput.text.ToString());
    //    mName = stringScripts.StringToLower(middleNameInput.text.ToString().ToLower());
    //    lName = stringScripts.StringToLower(lastNameInput.text.ToString().ToLower());

    //    query = "SELECT user_id from Users where firstName = '" + fName + "' AND middleName = '" + mName + "' AND lastName = '" + lName + "'";

    //    dataread = _dbctrl.ExecuteReader(query);
    //    if (dataread != null)
    //    {
    //        while (dataread.Read())
    //        {
    //            Userid = dataread[0].ToString();
    //            //Application.LoadLevel(scene);
    //            nextScene.ChangeToScene("Main Menu Scene");
    //        }
    //        _dbctrl.DisconnectDB(_dbctrl.con_db, _dbctrl.rdr, _dbctrl.cmd_db);
    //    }

    //    else
    //    {
    //        text.text = "Error login, Please Try Again";
    //        _dbctrl.DisconnectDB(_dbctrl.con_db, _dbctrl.rdr, _dbctrl.cmd_db);
    //    }
    //}

    //public void CreateNewUser()
    //{
    //    fName = stringScripts.StringToLower(firstNameInput.text.ToString());
    //    mName = stringScripts.StringToLower(middleNameInput.text.ToString().ToLower());
    //    lName = stringScripts.StringToLower(lastNameInput.text.ToString().ToLower());

    //    query = "INSERT into Users (firstName, middleName, lastName) values ('" + fName + "','" + mName + "', '" + lName + "')";
    //    querycheck = "SELECT user_id from Users where firstName = '" + fName + "' AND middleName = '" + mName + "' AND lastName = '" + lName + "'";
    //    queryget = "SELECT * FROM Users ORDER BY user_id DESC LIMIT 1";

    //    dataread = _dbctrl.ExecuteReader(querycheck);
    //    _dbctrl.DisconnectDB(_dbctrl.con_db, _dbctrl.rdr, _dbctrl.cmd_db);

    //    if (fName != "" && mName != "" && lName != "")
    //    {
    //        if (dataread == null)
    //        {
    //            _dbctrl.UpdateData(query);
    //            _dbctrl.DisconnectDB(_dbctrl.con_db, _dbctrl.rdr, _dbctrl.cmd_db);

    //            dataread2 = _dbctrl.ExecuteReader(queryget);
    //            Userid = dataread2[0].ToString();
    //            _dbctrl.DisconnectDB(_dbctrl.con_db, _dbctrl.rdr, _dbctrl.cmd_db);

    //            nextScene.ChangeToScene("Main Menu Scene");
    //        }
    //        else
    //        {
    //            gameObject.SetActive(true);
    //        }

    //    }

    //    else if (fName == "")
    //    {
    //        text.text = "Please put your First Name.";
    //    }

    //    else if (mName == "")
    //    {
    //        text.text = "Please put your Middle Name.";
    //    }

    //    else
    //    {
    //        text.text = "Please put your Last Name.";
    //    }
    //}

    // Use this for initialization
    public void OldUser()
    {
        uName = stringScripts.StringToLower(userNameLoginInput.text.ToString());

        query = "SELECT user_id from Users where userName = '" + uName + "'";

        dataread = _dbctrl.ExecuteReader(query);
        if (dataread != null)
        {
            while (dataread.Read())
            {
                Userid = dataread[0].ToString();
                //Application.LoadLevel(scene);
                nextScene.ChangeToScene("Main Menu Scene");
            }
            _dbctrl.DisconnectDB(_dbctrl.con_db, _dbctrl.rdr, _dbctrl.cmd_db);
        }

        else
        {
            text.text = "Error login, Please Try Again";
            _dbctrl.DisconnectDB(_dbctrl.con_db, _dbctrl.rdr, _dbctrl.cmd_db);
        }
    }

    public void CreateNewUser()
    {
        uName = stringScripts.StringToLower(userNameInput.text.ToString());
        fName = stringScripts.StringToLower(firstNameInput.text.ToString());
        mName = stringScripts.StringToLower(middleNameInput.text.ToString());
        lName = stringScripts.StringToLower(lastNameInput.text.ToString());

        query = "INSERT into Users (userName, firstName, middleName, lastName) values ('" + uName + "','" + fName + "','" + mName + "', '" + lName + "')";
        querycheck = "SELECT user_id from Users where userName = '" + uName + "' AND firstName = '" + fName + "' AND middleName = '" + mName + "' AND lastName = '" + lName + "'";
        queryget = "SELECT * FROM Users ORDER BY user_id DESC LIMIT 1";

        dataread = _dbctrl.ExecuteReader(querycheck);
        _dbctrl.DisconnectDB(_dbctrl.con_db, _dbctrl.rdr, _dbctrl.cmd_db);

        if (uName != "" && fName != "" && mName != "" && lName != "")
        {
            if (dataread == null)
            {
                _dbctrl.UpdateData(query);
                _dbctrl.DisconnectDB(_dbctrl.con_db, _dbctrl.rdr, _dbctrl.cmd_db);

                dataread2 = _dbctrl.ExecuteReader(queryget);
                Userid = dataread2[0].ToString();
                _dbctrl.DisconnectDB(_dbctrl.con_db, _dbctrl.rdr, _dbctrl.cmd_db);

                nextScene.ChangeToScene("Main Menu Scene");
            }
            else
            {
                gameObject.SetActive(true);
            }

        }

        else if (uName == "")
        {
            text.text = "Please put your User Name.";
        }

        else if (fName == "")
        {
            text.text = "Please put your First Name.";
        }

        else if (mName == "")
        {
            text.text = "Please put your Middle Name.";
        }

        else
        {
            text.text = "Please put your Last Name.";
        }
    }

    //void Start()
    //{

    //}
}