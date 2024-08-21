using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class puzzle_tic : MonoBehaviour
{
    public char[] letras;
    int i = 0;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {

        if (i >= 0 && i < letras.Length)
        {
            char letraactual = letras[i];
            KeyCode letraenpantalla = CharToKeyCode(letraactual);

            if (Input.GetKeyDown(letraactual))
            {



            }

        }
    }

    void GenerarLetra()
    {
        int i = Random.Range(0, 26);
    }
    void PuzzleOn()
    {

    }
    KeyCode CharToKeyCode (char c)
    {
        // Convertir el carácter a KeyCode
        switch (c)
        {
            case 'A': return KeyCode.A;
            case 'B': return KeyCode.B;
            case 'C': return KeyCode.C;
            case 'D': return KeyCode.D;
            case 'E': return KeyCode.E;
            case 'F': return KeyCode.F;
            case 'G': return KeyCode.G;
            case 'H': return KeyCode.H;
            case 'I': return KeyCode.I;
            case 'J': return KeyCode.J;
            case 'K': return KeyCode.K;
            case 'L': return KeyCode.L;
            case 'M': return KeyCode.M;
            case 'N': return KeyCode.N;
            case 'O': return KeyCode.O;
            case 'P': return KeyCode.P;
            case 'Q': return KeyCode.Q;
            case 'R': return KeyCode.R;
            case 'S': return KeyCode.S;
            case 'T': return KeyCode.T;
            case 'U': return KeyCode.U;
            case 'V': return KeyCode.V;
            case 'W': return KeyCode.W;
            case 'X': return KeyCode.X;
            case 'Y': return KeyCode.Y;
            case 'Z': return KeyCode.Z;



        }
    }
}
