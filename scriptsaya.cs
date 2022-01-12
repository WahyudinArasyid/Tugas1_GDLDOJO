using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptsaya : MonoBehaviour
{

    const string alf = "Halo Alfin";
    const string bon = "Halo Boni";
    const string Can = "Halo Candy";
    int a = 1;
    int b = 2;
   
    int d;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Pilih Karakter Yang Kamu Inginkan [1 = Alfin],[2 = Boni],[3 = Candy]");
      



    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log( alf +  " Selamat memainkan minigamesnya semoga kamu terhibur");
            minigames();
        }

       else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Debug.Log(bon + " Selamat memainkan minigamesnya semoga kamu terhibur");
            minigames();
        }
       else  if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Debug.Log(Can + "Selamat memainkan minigamesnya semoga kamu terhibur");
            minigames();
        }
       else if (Input.GetKeyDown(KeyCode.A))
        {
            d = a + b;
            Debug.Log(d + " adalah jawaban salah");
            Debug.Log("kembali ke menu awal ? y/n ");

        }

        else if (Input.GetKeyDown(KeyCode.B))
        {
            d = a + a;
            Debug.Log(d + " adalah jawaban benar");
            Debug.Log("Selamat kamu telah menamatkan gamenya ^_^ ");

        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            d = b + b;
            Debug.Log(d + "adalah jawaban salah");
            Debug.Log("kembali ke menu awal ? Y / N ");
        }
        else if (Input.GetKeyDown(KeyCode.Y))
        {
            Start();
        }
        else if (Input.GetKeyDown(KeyCode.N))
        {
            Debug.Log("Quit Game");


        }
    }

     void minigames()
    {
        Debug.Log("soal pilihan ganda input jawaban yang menurut anda benar");
        Debug.Log("1+1 = ?  [A].3  [B].2 [C].4");
    }

}
