// Save this as Game.cs
using System;
using System.Collections.Generic;

class SnakeGame
{
    static bool gameOver;
    static int width = 20;
    static int height = 20;
    static int x, y, fruitX, fruitY, score;
    static List<(int, int)> snake = new List<(int, int)>();
    enum Direction { STOP, LEFT, RIGHT, UP, DOWN }
    static Direction dir;

    static void Setup()
    {
        gameOver = false;
        dir = Direction.STOP;
        x = width / 2;
        y = height / 2;
        snake.Clear();
        snake.Add((x, y));
        fruitX = new Random().Next(width);
        fruitY = new Random().Next(height);
        score = 0;
    }

    static void Draw()
    {
        Console.Clear();
        
        // Draw top border
        Console.WriteLine(new string('#', width + 2));
        
        for (int i = 0; i < height; i++)
        {
            Console.Write("#");
            for (int j = 0; j < width; j++)
            {
                bool isSnake = false;
                for (int k = 0; k < snake.Count; k++)
                {
                    if (snake[k].Item1 == j && snake[k].Item2 == i)
                    {
                        Console.Write(k == 0 ? "O" : "o");
                        isSnake = true;
                        break;
                    }
                }
                
                if (!isSnake)
                {
                    if (j == fruitX && i == fruitY)
                        Console.Write("F");
                    else
                        Console.Write(" ");
                }
            }
            Console.WriteLine("#");
        }
        
        // Draw bottom border
        Console.WriteLine(new string('#', width + 2));
        Console.WriteLine($"Score: {score}");
    }

    static void Input()
    {
        if (Console.KeyAvailable)
        {
            var key = Console.ReadKey(true).Key;
            switch (key)
            {
                case ConsoleKey.A when dir != Direction.RIGHT:
                    dir = Direction.LEFT;
                    break;
                case ConsoleKey.D when dir != Direction.LEFT:
                    dir = Direction.RIGHT;
                    break;
                case ConsoleKey.W when dir != Direction.DOWN:
                    dir = Direction.UP;
                    break;
                case ConsoleKey.S when dir != Direction.UP:
                    dir = Direction.DOWN;
                    break;
                case ConsoleKey.X:
                case ConsoleKey.Escape:
                    gameOver = true;
                    break;
            }
        }
    }

    static void Logic()
    {
        var head = snake[0];
        
        switch (dir)
        {
            case Direction.LEFT:
                head.Item1--;
                break;
            case Direction.RIGHT:
                head.Item1++;
                break;
            case Direction.UP:
                head.Item2--;
                break;
            case Direction.DOWN:
                head.Item2++;
                break;
        }
        
        snake.Insert(0, head);
        
        // Wall collision
        if (head.Item1 < 0 || head.Item1 >= width || head.Item2 < 0 || head.Item2 >= height)
            gameOver = true;
        
        // Self collision
        for (int i = 1; i < snake.Count; i++)
            if (head == snake[i])
                gameOver = true;
        
        // Fruit eaten
        if (head.Item1 == fruitX && head.Item2 == fruitY)
        {
            score += 10;
            PlaceFruit();
        }
        else
        {
            snake.RemoveAt(snake.Count - 1);
        }
    }

    static void PlaceFruit()
    {
        var random = new Random();
        bool onSnake;
        do
        {
            onSnake = false;
            fruitX = random.Next(width);
            fruitY = random.Next(height);
            
            foreach (var segment in snake)
                if (segment.Item1 == fruitX && segment.Item2 == fruitY)
                    onSnake = true;
        } while (onSnake);
    }

    static void Main()
    {
        Setup();
        while (!gameOver)
        {
            Draw();
            Input();
            Logic();
            System.Threading.Thread.Sleep(100);
        }
        Console.WriteLine($"Game Over! Final Score: {score}");
    }
}