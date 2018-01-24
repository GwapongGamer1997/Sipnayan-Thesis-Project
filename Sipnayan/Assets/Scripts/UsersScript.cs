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
    private string query;
    private string querycheck;
    private string queryget;

    public InputField firstNameInput;
    public InputField middleNameInput;
    public InputField lastNameInput;
    public Text text;
    public GameObject gameObject;

    private string fName;
    private string mName;
    private string lName;

    public static string Userid
    {
        get;
        private set;
    }

    // Use this for initialization
    private void OldUser()
    {
        fName = firstNameInput.text.ToString().ToLower();
        mName = middleNameInput.text.ToString().ToLower();
        lName = lastNameInput.text.ToString().ToLower();

        query = "SELECT user_id from Users where firstName = '" + fName + "' AND middleName = '" + mName + "' AND lastName = '" + lName + "'";

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

    public void UserChecker()
    {
        fName = firstNameInput.text.ToString().ToLower();
        mName = middleNameInput.text.ToString().ToLower();
        lName = lastNameInput.text.ToString().ToLower();

        query = "INSERT into Users (firstName, middleName, lastName) values ('" + fName + "','" + mName + "', '" + lName + "')";
        querycheck = "SELECT user_id from Users where firstName = '" + fName + "' AND middleName = '" + mName + "' AND lastName = '" + lName + "'";
        queryget = "SELECT * FROM Users ORDER BY user_id DESC LIMIT 1";

        if (fName != "" && mName != "" && lName != "")
        {
            dataread = _dbctrl.ExecuteReader(querycheck);
            if (dataread == null)
            {
                _dbctrl.UpdateData(query);
                _dbctrl.DisconnectDB(_dbctrl.con_db, _dbctrl.rdr, _dbctrl.cmd_db);

                dataread = _dbctrl.ExecuteReader(queryget);
                Userid = dataread[0].ToString();
                _dbctrl.DisconnectDB(_dbctrl.con_db, _dbctrl.rdr, _dbctrl.cmd_db);

                nextScene.ChangeToScene("Main Menu Scene");
            }

            else
            {
                OldUser();
            }
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

    void Start()
    {
        query = "SELECT * FROM Users ORDER BY user_id DESC LIMIT 1";
        dataread = _dbctrl.ExecuteReader(query);

        if (dataread.FieldCount > 0)
        {
            gameObject.SetActive(true);

            text.text = dataread[1].ToString();
            Userid = dataread[0].ToString();
            _dbctrl.DisconnectDB(_dbctrl.con_db, _dbctrl.rdr, _dbctrl.cmd_db);
        }
    }
}