using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class GameMaster {
    public const float width = 8.0f;
    public const float height = 5.0f;

    public static int score = 0;
    public static bool invincible = false;

    public static float speed = 1;

    public static void AddToScore(int points)
    {
        score += points;
    }

    public static void Lose()
    {
        SceneManager.LoadScene(0);
    }

    public static void AddToSpeed(float deltaSpeed)
    {
        speed += deltaSpeed;
    }
}
