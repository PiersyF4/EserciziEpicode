using System;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;

public class Lab3 : MonoBehaviour
{
    int sum = 0;        // Variabile di somma  
    int mult = 1;       // Variabile di prodotto  
    float med = 0;      // Variabile di media  

    int primo = 1;
    int secondo = 12;
    int terzo = 3;
    int quarto = 8;

    int maxInt = 10;

    // Tempo di inizio
    DateTime startTime;

    // Tempo passato
    TimeSpan timePassed;
    double totalSeconds;

    // Variabile per tracciare l'ultimo log
    double lastLogTime = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created  
    void Start()
    {
        startTime = DateTime.Now; // Inizializza il tempo di inizio

        Debug.Log("Hello World!");
        Debug.Log($"I numeri sono: {primo}{secondo}{terzo}{quarto}");
        Debug.Log($"Somma: {GetSum()}");
        Debug.Log($"Media: {GetMed()}");
        Debug.Log($"Molt: {GetMult()}");
        Debug.Log($"il primo numero {primo} è pari?: {IsOdd(primo)}. è maggiore di {maxInt}? {IsMoreThan(maxInt, primo)}");
        Debug.Log($"I numeri successivi a {primo} sono: {GetSuccessiveNum(primo)}");
        Debug.Log($"I numeri precedenti a {primo} sono: {GetPrecedentNum(primo)}");
        Debug.Log($"Il numero più alto tra {secondo} e {terzo} è: {GetMaxNum(secondo, terzo)}");
        Debug.Log($"Il numero più alto tra {terzo} e {quarto} è: {GetMinNum(terzo, quarto)}");
        Debug.Log($"Calcolo il voto {quarto}: {GetVoteSimplified(quarto)}");
        Debug.Log($"Calcolo il voto {terzo}: {GetVoteAlternative(terzo)}");
    }

    // Calcola la somma dei 4 numeri  
    private int GetSum()
    {
        sum = primo + secondo + terzo + quarto;
        return sum;
    }

    // Calcola la media dei 4 numeri  
    private float GetMed()
    {
        med = (primo + secondo + terzo + quarto) / 4f;
        return med;
    }

    // Calcola il prodotto dei 4 numeri  
    private int GetMult()
    {
        mult = primo * secondo * terzo * quarto;
        return mult;
    }

    // Controlla se il numero è pari o dispari
    private bool IsOdd(int num)
    {
        if (num % 2 == 0)
        {
            // Pari
            return true;
        }
        else
        {
            // Dispari
            return false;
        }
    }

    // Controlla se il numero è maggiore di x
    private bool IsMoreThan(int max, int num)
    {
        if (num >= max)
        {
            // è maggiore
            return true;
        }
        else
        {
            // Non è maggiore
            return false;
        }
    }

    // Calcola i due numeri successivi a quello in input  
    private (int, int) GetSuccessiveNum(int num)
    {
        // Primo numero successivo
        int successiveNumFirst = primo + 1;
        // Secondo numero successivo
        int successiveNumSecond = successiveNumFirst + 1;

        return (successiveNumFirst, successiveNumSecond);
    }

    // Calcola i due numeri precedenti a quello in input
    private (int, int) GetPrecedentNum(int num)
    {
        // Primo numero precedente
        int precedentNumFirst = primo - 1;
        // Secondo numero precedente
        int precedentNumSecond = precedentNumFirst - 1;

        return (precedentNumFirst, precedentNumSecond);
    }

    // Calcola il max tra due numeri
    private int GetMaxNum(int num1, int num2)
    {
        // calcolo del maxNum
        int maxNum = math.max(num1, num2);
        return maxNum;
    }

    // Calcola il min tra due numeri
    private int GetMinNum(int num1, int num2)
    {
        // calcolo del minNum
        int minNum = math.min(num1, num2);
        return minNum;
    }

    
    // Calcola voto americano
    private string GetVoteSimplified(int num)
    {
        // Metodo semplice
        if (num >= 10) return "A+";
        else if (num >= 9) return "A";
        else if (num >= 7) return "B";
        else if (num >= 6) return "C";
        else if (num >= 5) return "E";
        else if (num >= 0) return "F";
        else return "Valore non valido";

    }

    private string GetVoteAlternative(int num)
    {
        // Metodo alternativo con switch expression
        string risultato = num switch
        {
            >= 10 => "A+",
            >= 9 => "A",
            >= 7 => "B",
            >= 6 => "C",
            >= 5 => "E",
            >= 0 => "F",
            _ => "Valore non valido"
        };

        return risultato;
    }


    // Update is called once per frame  
    void Update()
    {
        // Calcola il tempo passato
        timePassed = DateTime.Now - startTime;
        totalSeconds = timePassed.Seconds;

        // Logga il tempo passato una volta al secondo
        if (totalSeconds - lastLogTime >= 1)
        {
            Debug.Log($"{GetTimePassed(totalSeconds)}");
            lastLogTime = totalSeconds;
        }
    }

    // Calcola il tempo passato in secondi
    private string GetTimePassed(double totalSeconds)
    {
        if (totalSeconds < 30)
            return "Sono strascorsi meno di 30 secondi";
        else if (totalSeconds >= 30 && totalSeconds < 45)
            return "Sono strascorsi più di 30 secondi";
        else if (totalSeconds >= 45 && totalSeconds < 60)
            return "Sono strascorsi più di 45 secondi";
        else
            return "È trascorso più di un minuto";
    }
}
