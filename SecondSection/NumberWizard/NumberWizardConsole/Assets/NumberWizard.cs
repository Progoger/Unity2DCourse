using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max;
    int min;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = (max + min) / 2;
        Debug.Log("Добро пожаловать в Волшебные числа, дружище");
        Debug.Log("Что же ты стоишь, давай, выбирай число, да не забудь в секрете его держать...");
        Debug.Log("Только не надумывай ничего большего: " + max);
        Debug.Log("Да и меньше этого не стоит: " + min);
        Debug.Log("А теперь, давай, поиграем.\n Скажи-ка угадал ли я, число: " + guess);
        Debug.Log("Нажми стрелочку вверх, если число больше;\nСтрелочку вниз, если оно меньше;\nА коли я угадал, так нажми Enter");
        max += 1;
    }

    // Update is called once per frame
    void Update()
    {
        //Detect when the up arrow key is pressed down
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }

        //Detect when the down arrow key is pressed down
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }

        //Detect when the Return key is pressed down
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Ооооо, я чую запах победы, сыграем ещё?");
            StartGame();
        }
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Попробуем ещё разок, может быть это: " + guess);
    }
}
