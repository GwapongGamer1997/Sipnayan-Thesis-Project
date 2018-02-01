using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite;
using System.Data;
using System.IO;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class db_controller : MonoBehaviour
{
    public SqliteConnection con_db;
    public SqliteCommand cmd_db;
    public SqliteDataReader rdr;

    private string path;

    public void ConnectDB()
    {
        if (Application.platform != RuntimePlatform.Android)
        {
            path = Application.dataPath + "/StreamingAssets/DatasDB.sqlite";
        }

        else
        {
            path = Application.persistentDataPath + "/youtube.db";

            if (!File.Exists(path))
            {
                WWW load = new WWW("jar:file://" + Application.dataPath + "!/assets/" + "DatasDB.sqlite");
                while (!load.isDone) { }
                File.WriteAllBytes(path, load.bytes);
            }
        }

        con_db = new SqliteConnection("URI = file:" + path);
        con_db.Open();
    }

    public void DisconnectDB(SqliteConnection con, SqliteDataReader r, SqliteCommand c)
    {
        con_db.Close();
        r.Close();
        r = null;
        cmd_db.Dispose();
        print("disconnectd");
    }

    public SqliteDataReader ExecuteReader(string query)
    {
        ConnectDB();

        cmd_db = new SqliteCommand(query, con_db);
        rdr = cmd_db.ExecuteReader();

        if (rdr.HasRows)
        {
            return rdr;
        }
        else
        {
            return null;
        }
}

    public void UpdateData(string query)
    {
        ConnectDB();

        try
        {
            cmd_db = new SqliteCommand(query, con_db);
            cmd_db.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            print(ex);
        }
    }
}
