using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Mono.Data.Sqlite;
using UnityEngine.SceneManagement;

public class PlayerStatsScript : MonoBehaviour
{
    string query;
    public SqliteDataReader dr;
    private db_controller db = new db_controller();
    //public Text user_id;
    public Text fName;
    //public Text mName;
    //public Text lName;
    //public Text stats_id;
    public Text quiz1;
    public Text quiz2;
    public Text quiz3;

    // Use this for initialization
    void Start () {
        query = "SELECT * from Users, Stats where user_id = '" + id.Instance.Uid + "'";
        dr = db.ExecuteReader(query);
        if (dr != null)
        {
            while (dr.Read())
            {
                //user_id.text = dr[0].ToString();
                fName.text = dr[1].ToString();
                //mName.text = dr[2].ToString();
                //lName.text = dr[3].ToString();
                //stats_id.text = dr[4].ToString();
                //quiz1.text = dr[5].ToString();
                //quiz2.text = dr[6].ToString();
                //quiz3.text = dr[7].ToString();
            }
        }
    }
}
