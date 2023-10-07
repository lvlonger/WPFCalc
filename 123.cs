using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFCalc
{
    class _123
    {
        #include <iostream>
using namespace std;


    int main()
    {
        setlocale(0, "");
        int back = 1;
        int choice;
        int quantity = 8;
        int error;
        int color = 4;
        int life = 3;
        int game;
        int gamequantity;
        int answer;
        int point = 0;
        int numberquestions = 1;
        cout << "Введите имя игрока: ";
        string username; cin >> username;
        system("cls");
        cout << "Выберите цвет интерфейса: \n\n";
        cout << "\x1b[91m[1] Красный \n";
        cout << "\x1b[92m[2] Зеленый \n";
        cout << "\x1b[93m[3] Желтый \n";
        cout << "\x1b[94m[4] Синий \n";
        cout << "\x1b[95m[5] Фиолетовый \n";
        cout << "\x1b[96m[6] Лазурный \n\x1b[0m";
        cin >> choice;
        switch (choice)
        {
            case 1:
                color = 1;
                break;
            case 2:
                color = 2;
                break;
            case 3:
                color = 3;
                break;
            case 4:
                color = 4;
                break;
            case 5:
                color = 5;
                break;
            case 6:
                color = 6;
                break;
            default:
                system("cls");
                cout << "\x1b[91m Неккоректно введены данные!\x1b[0m\n Цвет выбран по умолчанию.\n Изменить цвет можно в настройках.\n Для продолжения введите любую цифру.\n";
                cin >> error;
                break;
        }
        system("cls");
        cout << " \t Привет \x1b[9" << color << "m" << username << "\x1b[0m!\n перед тобой замечательная игра \n \t\x1b[9" << color << "m \"ВИКТОРИНА\"\n\n\n\n\n\n\x1b[0m";
        cout << "Введите любую цифру ";
        int a; cin >> a;
        while (true)
        {
            system("cls");
            cout << "\t\t\x1b[9" << color << "m МЕНЮ \x1b[0m\n\n";
            cout << "\t[1] Начать игру\n";
            cout << "\t[2] Настройки\n";
            cout << "\t[3] Правила\n";
            cout << "\t[4] Выйти\n\n\n";
            cout << "\tВыберите функцию.";
            cin >> choice;
            switch (choice)
            {
                case 1:
                    system("cls");
                    game = 1;
                    gamequantity = quantity;
                    numberquestions = 1;
                    cout << "\x1b[9" << color << "m   Викторина начинается!\x1b[0m \nВыбран режим с " << quantity << " вопросами.\n";
                    cout << "[1] Начать игру \n";
                    cout << "[2] Вернуться в главное меню \n";
                    cin >> choice;
                    switch (choice)
                    {
                        case 1:
                            while (game)
                            {
                                switch (gamequantity)
                                {
                                    case 1:
                                        system("cls");
                                        cout << "Пользователь \x1b[9" << color << "m " << username << " \x1b[0m | оставшиеся жизни: \x1b[9" << color << "m " << life << "\x1b[0m | количество очков: \x1b[9" << color << "m " << point << "\x1b[0m\n\n";
                                        cout << "[\x1b[9" << color << "m" << numberquestions << "\x1b[0m] Тут будет вопрос..." << endl;
                                        cout << "[\x1b[9" << color << "m1\x1b[0m] тут вариант A\n";
                                        cout << "[\x1b[9" << color << "m2\x1b[0m] тут вариант B\n";
                                        cout << "[\x1b[9" << color << "m3\x1b[0m] тут вариант C\n";
                                        cout << "[\x1b[9" << color << "m4\x1b[0m] тут вариант D\n";
                                        cout << "Введите вариант ответа: ";
                                        cin >> answer;
                                        gamequantity--;
                                        numberquestions++;
                                        game = 0;
                                        break;
                                    case 2:
                                        system("cls");
                                        cout << "Пользователь \x1b[9" << color << "m " << username << " \x1b[0m | оставшиеся жизни: \x1b[9" << color << "m " << life << "\x1b[0m | количество очков: \x1b[9" << color << "m " << point << "\x1b[0m\n\n";
                                        cout << "[\x1b[9" << color << "m" << numberquestions << "\x1b[0m]  Тут будет вопрос..." << endl;
                                        cout << "[\x1b[9" << color << "m1\x1b[0m] тут вариант A\n";
                                        cout << "[\x1b[9" << color << "m2\x1b[0m] тут вариант B\n";
                                        cout << "[\x1b[9" << color << "m3\x1b[0m] тут вариант C\n";
                                        cout << "[\x1b[9" << color << "m4\x1b[0m] тут вариант D\n";
                                        cout << "Введите вариант ответа: ";
                                        cin >> answer;
                                        gamequantity--;
                                        numberquestions++;
                                        break;
                                    case 3:
                                        system("cls");
                                        cout << "Пользователь \x1b[9" << color << "m " << username << " \x1b[0m | оставшиеся жизни: \x1b[9" << color << "m " << life << "\x1b[0m | количество очков: \x1b[9" << color << "m " << point << "\x1b[0m\n\n";
                                        cout << "[\x1b[9" << color << "m" << numberquestions << "\x1b[0m]  Тут будет вопрос..." << endl;
                                        cout << "[\x1b[9" << color << "m1\x1b[0m] тут вариант A\n";
                                        cout << "[\x1b[9" << color << "m2\x1b[0m] тут вариант B\n";
                                        cout << "[\x1b[9" << color << "m3\x1b[0m] тут вариант C\n";
                                        cout << "[\x1b[9" << color << "m4\x1b[0m] тут вариант D\n";
                                        cout << "Введите вариант ответа: ";
                                        cin >> answer;
                                        gamequantity--;
                                        numberquestions++;
                                        break;
                                    case 4:
                                        system("cls");
                                        cout << "Пользователь \x1b[9" << color << "m " << username << " \x1b[0m | оставшиеся жизни: \x1b[9" << color << "m " << life << "\x1b[0m | количество очков: \x1b[9" << color << "m " << point << "\x1b[0m\n\n";
                                        cout << "[\x1b[9" << color << "m" << numberquestions << "\x1b[0m]  Тут будет вопрос..." << endl;
                                        cout << "[\x1b[9" << color << "m1\x1b[0m] тут вариант A\n";
                                        cout << "[\x1b[9" << color << "m2\x1b[0m] тут вариант B\n";
                                        cout << "[\x1b[9" << color << "m3\x1b[0m] тут вариант C\n";
                                        cout << "[\x1b[9" << color << "m4\x1b[0m] тут вариант D\n";
                                        cout << "Введите вариант ответа: ";
                                        cin >> answer;
                                        gamequantity--;
                                        numberquestions++;
                                        break;
                                    case 5:
                                        system("cls");
                                        cout << "Пользователь \x1b[9" << color << "m " << username << " \x1b[0m | оставшиеся жизни: \x1b[9" << color << "m " << life << "\x1b[0m | количество очков: \x1b[9" << color << "m " << point << "\x1b[0m\n\n";
                                        cout << "[\x1b[9" << color << "m" << numberquestions << "\x1b[0m]  Тут будет вопрос..." << endl;
                                        cout << "[\x1b[9" << color << "m1\x1b[0m] тут вариант A\n";
                                        cout << "[\x1b[9" << color << "m2\x1b[0m] тут вариант B\n";
                                        cout << "[\x1b[9" << color << "m3\x1b[0m] тут вариант C\n";
                                        cout << "[\x1b[9" << color << "m4\x1b[0m] тут вариант D\n";
                                        cout << "Введите вариант ответа: ";
                                        cin >> answer;
                                        gamequantity--;
                                        numberquestions++;
                                        break;
                                    case 6:
                                        system("cls");
                                        cout << "Пользователь \x1b[9" << color << "m " << username << " \x1b[0m | оставшиеся жизни: \x1b[9" << color << "m " << life << "\x1b[0m | количество очков: \x1b[9" << color << "m " << point << "\x1b[0m\n\n";
                                        cout << "[\x1b[9" << color << "m" << numberquestions << "\x1b[0m]  Тут будет вопрос..." << endl;
                                        cout << "[\x1b[9" << color << "m1\x1b[0m] тут вариант A\n";
                                        cout << "[\x1b[9" << color << "m2\x1b[0m] тут вариант B\n";
                                        cout << "[\x1b[9" << color << "m3\x1b[0m] тут вариант C\n";
                                        cout << "[\x1b[9" << color << "m4\x1b[0m] тут вариант D\n";
                                        cout << "Введите вариант ответа: ";
                                        cin >> answer;
                                        gamequantity--;
                                        numberquestions++;
                                        break;
                                    case 7:
                                        system("cls");
                                        cout << "Пользователь \x1b[9" << color << "m " << username << " \x1b[0m | оставшиеся жизни: \x1b[9" << color << "m " << life << "\x1b[0m | количество очков: \x1b[9" << color << "m " << point << "\x1b[0m\n\n";
                                        cout << "[\x1b[9" << color << "m" << numberquestions << "\x1b[0m]  Тут будет вопрос..." << endl;
                                        cout << "[\x1b[9" << color << "m1\x1b[0m] тут вариант A\n";
                                        cout << "[\x1b[9" << color << "m2\x1b[0m] тут вариант B\n";
                                        cout << "[\x1b[9" << color << "m3\x1b[0m] тут вариант C\n";
                                        cout << "[\x1b[9" << color << "m4\x1b[0m] тут вариант D\n";
                                        cout << "Введите вариант ответа: ";
                                        cin >> answer;
                                        gamequantity--;
                                        numberquestions++;
                                        break;
                                    case 8:
                                        system("cls");
                                        cout << "Пользователь \x1b[9" << color << "m " << username << " \x1b[0m | оставшиеся жизни: \x1b[9" << color << "m " << life << "\x1b[0m | количество очков: \x1b[9" << color << "m " << point << "\x1b[0m\n\n";
                                        cout << "[\x1b[9" << color << "m" << numberquestions << "\x1b[0m]  Тут будет вопрос..." << endl;
                                        cout << "[\x1b[9" << color << "m1\x1b[0m] тут вариант A\n";
                                        cout << "[\x1b[9" << color << "m2\x1b[0m] тут вариант B\n";
                                        cout << "[\x1b[9" << color << "m3\x1b[0m] тут вариант C\n";
                                        cout << "[\x1b[9" << color << "m4\x1b[0m] тут вариант D\n";
                                        cout << "Введите вариант ответа: ";
                                        cin >> answer;
                                        gamequantity--;
                                        numberquestions++;
                                        break;
                                    case 9:
                                        system("cls");
                                        cout << "Пользователь \x1b[9" << color << "m " << username << " \x1b[0m | оставшиеся жизни: \x1b[9" << color << "m " << life << "\x1b[0m | количество очков: \x1b[9" << color << "m " << point << "\x1b[0m\n\n";
                                        cout << "[\x1b[9" << color << "m" << numberquestions << "\x1b[0m]  Тут будет вопрос..." << endl;
                                        cout << "[\x1b[9" << color << "m1\x1b[0m] тут вариант A\n";
                                        cout << "[\x1b[9" << color << "m2\x1b[0m] тут вариант B\n";
                                        cout << "[\x1b[9" << color << "m3\x1b[0m] тут вариант C\n";
                                        cout << "[\x1b[9" << color << "m4\x1b[0m] тут вариант D\n";
                                        cout << "Введите вариант ответа: ";
                                        cin >> answer;
                                        gamequantity--;
                                        numberquestions++;
                                        break;
                                    case 10:
                                        system("cls");
                                        cout << "Пользователь \x1b[9" << color << "m " << username << " \x1b[0m | оставшиеся жизни: \x1b[9" << color << "m " << life << "\x1b[0m | количество очков: \x1b[9" << color << "m " << point << "\x1b[0m\n\n";
                                        cout << "[\x1b[9" << color << "m" << numberquestions << "\x1b[0m]  Тут будет вопрос..." << endl;
                                        cout << "[\x1b[9" << color << "m1\x1b[0m] тут вариант A\n";
                                        cout << "[\x1b[9" << color << "m2\x1b[0m] тут вариант B\n";
                                        cout << "[\x1b[9" << color << "m3\x1b[0m] тут вариант C\n";
                                        cout << "[\x1b[9" << color << "m4\x1b[0m] тут вариант D\n";
                                        cout << "Введите вариант ответа: ";
                                        cin >> answer;
                                        gamequantity--;
                                        numberquestions++;
                                        break;
                                    case 11:
                                        system("cls");
                                        cout << "Пользователь \x1b[9" << color << "m " << username << " \x1b[0m | оставшиеся жизни: \x1b[9" << color << "m " << life << "\x1b[0m | количество очков: \x1b[9" << color << "m " << point << "\x1b[0m\n\n";
                                        cout << "[\x1b[9" << color << "m" << numberquestions << "\x1b[0m]  Тут будет вопрос..." << endl;
                                        cout << "[\x1b[9" << color << "m1\x1b[0m] тут вариант A\n";
                                        cout << "[\x1b[9" << color << "m2\x1b[0m] тут вариант B\n";
                                        cout << "[\x1b[9" << color << "m3\x1b[0m] тут вариант C\n";
                                        cout << "[\x1b[9" << color << "m4\x1b[0m] тут вариант D\n";
                                        cout << "Введите вариант ответа: ";
                                        cin >> answer;
                                        gamequantity--;
                                        numberquestions++;
                                        break;
                                    case 12:
                                        system("cls");
                                        cout << "Пользователь \x1b[9" << color << "m " << username << " \x1b[0m | оставшиеся жизни: \x1b[9" << color << "m " << life << "\x1b[0m | количество очков: \x1b[9" << color << "m " << point << "\x1b[0m\n\n";
                                        cout << "[\x1b[9" << color << "m" << numberquestions << "\x1b[0m]  Тут будет вопрос..." << endl;
                                        cout << "[\x1b[9" << color << "m1\x1b[0m] тут вариант A\n";
                                        cout << "[\x1b[9" << color << "m2\x1b[0m] тут вариант B\n";
                                        cout << "[\x1b[9" << color << "m3\x1b[0m] тут вариант C\n";
                                        cout << "[\x1b[9" << color << "m4\x1b[0m] тут вариант D\n";
                                        cout << "Введите вариант ответа: ";
                                        cin >> answer;
                                        gamequantity--;
                                        numberquestions++;
                                        break;
                                }
                            }
                            break;
                        default:
                            break;
                    }
                    break;
                case 2:
                    while (back)
                    {
                        system("cls");
                        cout << "\t\t\x1b[9" << color << "mНАСТРОЙКИ\x1b[0m\n\n";
                        cout << "[1] Изменить имя игрока.\n";
                        cout << "[2] Количество вопросов в игре. \n";
                        cout << "[3] Изменить цвет интерфейса. \n";
                        cout << "[4] Выход в главное меню. \n";
                        cout << "Выберите желаемые настройки. \n";
                        cin >> choice;
                        switch (choice)
                        {
                            case 1:
                                system("cls");
                                cout << "Введите новое имя игрока: ";
                                cin >> username;
                                break;
                            case 2:
                                system("cls");
                                cout << "Выберите количество вопросов в игре: \n\n";
                                cout << "[8]\n";
                                cout << "[10]\n";
                                cout << "[12]\n";
                                cin >> choice;
                                switch (choice)
                                {
                                    case 8:
                                        quantity = 8;
                                        break;
                                    case 10:
                                        quantity = 10;
                                        break;
                                    case 12:
                                        quantity = 12;
                                        break;
                                    default:
                                        system("cls");
                                        cout << "\x1b[91m Ошибка ввода! Попробуйте снова!\x1b[0m";
                                        cout << "Введите любую цифру ";
                                        cin >> error;
                                        break;
                                }
                            case 3:
                                system("cls");
                                cout << "Выберите цвет интерфейса: \n\n";
                                cout << "\x1b[91m[1] Красный \n";
                                cout << "\x1b[92m[2] Зеленый \n";
                                cout << "\x1b[93m[3] Желтый \n";
                                cout << "\x1b[94m[4] Синий \n";
                                cout << "\x1b[95m[5] Фиолетовый \n";
                                cout << "\x1b[96m[6] Лазурный \n\x1b[0m";
                                cin >> choice;
                                switch (choice)
                                {
                                    case 1:
                                        color = 1;
                                        break;
                                    case 2:
                                        color = 2;
                                        break;
                                    case 3:
                                        color = 3;
                                        break;
                                    case 4:
                                        color = 4;
                                        break;
                                    case 5:
                                        color = 5;
                                        break;
                                    case 6:
                                        color = 6;
                                        break;
                                    default:
                                        system("cls");
                                        cout << "\x1b[91m Неккоректно введены данные!\x1b[0m\n Цвет остался без изменений\n Для продолжения введите любую цифру.\n";
                                        cin >> error;
                                        break;
                                }
                                break;
                            case 4:
                                back = 0;
                                break;
                            default:
                                system("cls");
                                cout << "\x1b[91m Ошибка ввода! Попробуйте снова!\x1b[0m";
                                cout << "Введите любую цифру ";
                                cin >> error;
                                break;
                        }
                    }
                    break;
                case 3:
                    system("cls");
                    cout << "\t\t\x1b[9" << color << "mПРАВИЛА\x1b[0m\n\n";
                    cout << " - Игрок получает очки за правильный ответ на вопрос;\n";
                    cout << " - Игрок проходит дальше за правильный ответ;\n";
                    cout << " - Игрок теряет жизнь при неправильном ответе.\n";
                    cout << "Для возврата введите любое число ";
                    cin >> back;
                    break;
                case 4:
                    return 0;
                    break;
                default:
                    system("cls");
                    cout << "\x1b[91m Ошибка ввода! Попробуйте снова!\x1b[0m";
                    cout << "Введите любую цифру ";
                    cin >> error;
                    break;
            }
        }


        int _; cin >> _;
        return 0;
    }#include <iostream>
using namespace std;


    int main()
    {
        setlocale(0, "");
        int back = 1;
        int choice;
        int quantity = 8;
        int error;
        int color = 4;
        int life = 3;
        int game;
        int gamequantity;
        int answer;
        int point = 0;
        int numberquestions = 1;
        cout << "Введите имя игрока: ";
        string username; cin >> username;
        system("cls");
        cout << "Выберите цвет интерфейса: \n\n";
        cout << "\x1b[91m[1] Красный \n";
        cout << "\x1b[92m[2] Зеленый \n";
        cout << "\x1b[93m[3] Желтый \n";
        cout << "\x1b[94m[4] Синий \n";
        cout << "\x1b[95m[5] Фиолетовый \n";
        cout << "\x1b[96m[6] Лазурный \n\x1b[0m";
        cin >> choice;
        switch (choice)
        {
            case 1:
                color = 1;
                break;
            case 2:
                color = 2;
                break;
            case 3:
                color = 3;
                break;
            case 4:
                color = 4;
                break;
            case 5:
                color = 5;
                break;
            case 6:
                color = 6;
                break;
            default:
                system("cls");
                cout << "\x1b[91m Неккоректно введены данные!\x1b[0m\n Цвет выбран по умолчанию.\n Изменить цвет можно в настройках.\n Для продолжения введите любую цифру.\n";
                cin >> error;
                break;
        }
        system("cls");
        cout << " \t Привет \x1b[9" << color << "m" << username << "\x1b[0m!\n перед тобой замечательная игра \n \t\x1b[9" << color << "m \"ВИКТОРИНА\"\n\n\n\n\n\n\x1b[0m";
        cout << "Введите любую цифру ";
        int a; cin >> a;
        while (true)
        {
            system("cls");
            cout << "\t\t\x1b[9" << color << "m МЕНЮ \x1b[0m\n\n";
            cout << "\t[1] Начать игру\n";
            cout << "\t[2] Настройки\n";
            cout << "\t[3] Правила\n";
            cout << "\t[4] Выйти\n\n\n";
            cout << "\tВыберите функцию.";
            cin >> choice;
            switch (choice)
            {
                case 1:
                    system("cls");
                    game = 1;
                    gamequantity = quantity;
                    numberquestions = 1;
                    cout << "\x1b[9" << color << "m   Викторина начинается!\x1b[0m \nВыбран режим с " << quantity << " вопросами.\n";
                    cout << "[1] Начать игру \n";
                    cout << "[2] Вернуться в главное меню \n";
                    cin >> choice;
                    switch (choice)
                    {
                        case 1:
                            while (game)
                            {
                                switch (gamequantity)
                                {
                                    case 1:
                                        system("cls");
                                        cout << "Пользователь \x1b[9" << color << "m " << username << " \x1b[0m | оставшиеся жизни: \x1b[9" << color << "m " << life << "\x1b[0m | количество очков: \x1b[9" << color << "m " << point << "\x1b[0m\n\n";
                                        cout << "[\x1b[9" << color << "m" << numberquestions << "\x1b[0m]" << endl;
                                        cout << "Введите вариант ответа: ";
                                        cin >> answer;
                                        gamequantity--;
                                        numberquestions++;
                                        game = 0;
                                        break;
                                    case 2:
                                        system("cls");
                                        cout << "Пользователь \x1b[9" << color << "m " << username << " \x1b[0m | оставшиеся жизни: \x1b[9" << color << "m " << life << "\x1b[0m | количество очков: \x1b[9" << color << "m " << point << "\x1b[0m\n\n";
                                        cout << "[\x1b[9" << color << "m" << numberquestions << "\x1b[0m]" << endl;
                                        cout << "Введите вариант ответа: ";
                                        cin >> answer;
                                        gamequantity--;
                                        numberquestions++;
                                        break;
                                    case 3:
                                        system("cls");
                                        cout << "Пользователь \x1b[9" << color << "m " << username << " \x1b[0m | оставшиеся жизни: \x1b[9" << color << "m " << life << "\x1b[0m | количество очков: \x1b[9" << color << "m " << point << "\x1b[0m\n\n";
                                        cout << "[\x1b[9" << color << "m" << numberquestions << "\x1b[0m]" << endl;
                                        cout << "Введите вариант ответа: ";
                                        cin >> answer;
                                        gamequantity--;
                                        numberquestions++;
                                        break;
                                    case 4:
                                        system("cls");
                                        cout << "Пользователь \x1b[9" << color << "m " << username << " \x1b[0m | оставшиеся жизни: \x1b[9" << color << "m " << life << "\x1b[0m | количество очков: \x1b[9" << color << "m " << point << "\x1b[0m\n\n";
                                        cout << "[\x1b[9" << color << "m" << numberquestions << "\x1b[0m]" << endl;
                                        cout << "Введите вариант ответа: ";
                                        cin >> answer;
                                        gamequantity--;
                                        numberquestions++;
                                        break;
                                    case 5:
                                        system("cls");
                                        cout << "Пользователь \x1b[9" << color << "m " << username << " \x1b[0m | оставшиеся жизни: \x1b[9" << color << "m " << life << "\x1b[0m | количество очков: \x1b[9" << color << "m " << point << "\x1b[0m\n\n";
                                        cout << "[\x1b[9" << color << "m" << numberquestions << "\x1b[0m]" << endl;
                                        cout << "Введите вариант ответа: ";
                                        cin >> answer;
                                        gamequantity--;
                                        numberquestions++;
                                        break;
                                    case 6:
                                        system("cls");
                                        cout << "Пользователь \x1b[9" << color << "m " << username << " \x1b[0m | оставшиеся жизни: \x1b[9" << color << "m " << life << "\x1b[0m | количество очков: \x1b[9" << color << "m " << point << "\x1b[0m\n\n";
                                        cout << "[\x1b[9" << color << "m" << numberquestions << "\x1b[0m]" << endl;
                                        cout << "Введите вариант ответа: ";
                                        cin >> answer;
                                        gamequantity--;
                                        numberquestions++;
                                        break;
                                    case 7:
                                        system("cls");
                                        cout << "Пользователь \x1b[9" << color << "m " << username << " \x1b[0m | оставшиеся жизни: \x1b[9" << color << "m " << life << "\x1b[0m | количество очков: \x1b[9" << color << "m " << point << "\x1b[0m\n\n";
                                        cout << "[\x1b[9" << color << "m" << numberquestions << "\x1b[0m]" << endl;
                                        cout << "Введите вариант ответа: ";
                                        cin >> answer;
                                        gamequantity--;
                                        numberquestions++;
                                        break;
                                    case 8:
                                        system("cls");
                                        cout << "Пользователь \x1b[9" << color << "m " << username << " \x1b[0m | оставшиеся жизни: \x1b[9" << color << "m " << life << "\x1b[0m | количество очков: \x1b[9" << color << "m " << point << "\x1b[0m\n\n";
                                        cout << "[\x1b[9" << color << "m" << numberquestions << "\x1b[0m]" << endl;
                                        cout << "Введите вариант ответа: ";
                                        cin >> answer;
                                        gamequantity--;
                                        numberquestions++;
                                        break;
                                    case 9:
                                        system("cls");
                                        cout << "Пользователь \x1b[9" << color << "m " << username << " \x1b[0m | оставшиеся жизни: \x1b[9" << color << "m " << life << "\x1b[0m | количество очков: \x1b[9" << color << "m " << point << "\x1b[0m\n\n";
                                        cout << "[\x1b[9" << color << "m" << numberquestions << "\x1b[0m]" << endl;
                                        cout << "Введите вариант ответа: ";
                                        cin >> answer;
                                        gamequantity--;
                                        numberquestions++;
                                        break;
                                    case 10:
                                        system("cls");
                                        cout << "Пользователь \x1b[9" << color << "m " << username << " \x1b[0m | оставшиеся жизни: \x1b[9" << color << "m " << life << "\x1b[0m | количество очков: \x1b[9" << color << "m " << point << "\x1b[0m\n\n";
                                        cout << "[\x1b[9" << color << "m" << numberquestions << "\x1b[0m]" << endl;
                                        cout << "Введите вариант ответа: ";
                                        cin >> answer;
                                        gamequantity--;
                                        numberquestions++;
                                        break;
                                    case 11:
                                        system("cls");
                                        cout << "Пользователь \x1b[9" << color << "m " << username << " \x1b[0m | оставшиеся жизни: \x1b[9" << color << "m " << life << "\x1b[0m | количество очков: \x1b[9" << color << "m " << point << "\x1b[0m\n\n";
                                        cout << "[\x1b[9" << color << "m" << numberquestions << "\x1b[0m]" << endl;
                                        cout << "Введите вариант ответа: ";
                                        cin >> answer;
                                        gamequantity--;
                                        numberquestions++;
                                        break;
                                    case 12:
                                        system("cls");
                                        cout << "Пользователь \x1b[9" << color << "m " << username << " \x1b[0m | оставшиеся жизни: \x1b[9" << color << "m " << life << "\x1b[0m | количество очков: \x1b[9" << color << "m " << point << "\x1b[0m\n\n";
                                        cout << "[\x1b[9" << color << "m" << numberquestions << "\x1b[0m]" << endl;
                                        cout << "Введите вариант ответа: ";
                                        cin >> answer;
                                        gamequantity--;
                                        numberquestions++;
                                        break;
                                }
                            }
                            break;
                        default:
                            break;
                    }
                    break;
                case 2:
                    while (back)
                    {
                        system("cls");
                        cout << "\t\t\x1b[9" << color << "mНАСТРОЙКИ\x1b[0m\n\n";
                        cout << "[1] Изменить имя игрока.\n";
                        cout << "[2] Количество вопросов в игре. \n";
                        cout << "[3] Изменить цвет интерфейса. \n";
                        cout << "[4] Выход в главное меню. \n";
                        cout << "Выберите желаемые настройки. \n";
                        cin >> choice;
                        switch (choice)
                        {
                            case 1:
                                system("cls");
                                cout << "Введите новое имя игрока: ";
                                cin >> username;
                                break;
                            case 2:
                                system("cls");
                                cout << "Выберите количество вопросов в игре: \n\n";
                                cout << "[8]\n";
                                cout << "[10]\n";
                                cout << "[12]\n";
                                cin >> choice;
                                switch (choice)
                                {
                                    case 8:
                                        quantity = 8;
                                        break;
                                    case 10:
                                        quantity = 10;
                                        break;
                                    case 12:
                                        quantity = 12;
                                        break;
                                    default:
                                        system("cls");
                                        cout << "\x1b[91m Ошибка ввода! Попробуйте снова!\x1b[0m";
                                        cout << "Введите любую цифру ";
                                        cin >> error;
                                        break;
                                }
                            case 3:
                                system("cls");
                                cout << "Выберите цвет интерфейса: \n\n";
                                cout << "\x1b[91m[1] Красный \n";
                                cout << "\x1b[92m[2] Зеленый \n";
                                cout << "\x1b[93m[3] Желтый \n";
                                cout << "\x1b[94m[4] Синий \n";
                                cout << "\x1b[95m[5] Фиолетовый \n";
                                cout << "\x1b[96m[6] Лазурный \n\x1b[0m";
                                cin >> choice;
                                switch (choice)
                                {
                                    case 1:
                                        color = 1;
                                        break;
                                    case 2:
                                        color = 2;
                                        break;
                                    case 3:
                                        color = 3;
                                        break;
                                    case 4:
                                        color = 4;
                                        break;
                                    case 5:
                                        color = 5;
                                        break;
                                    case 6:
                                        color = 6;
                                        break;
                                    default:
                                        system("cls");
                                        cout << "\x1b[91m Неккоректно введены данные!\x1b[0m\n Цвет остался без изменений\n Для продолжения введите любую цифру.\n";
                                        cin >> error;
                                        break;
                                }
                                break;
                            case 4:
                                back = 0;
                                break;
                            default:
                                system("cls");
                                cout << "\x1b[91m Ошибка ввода! Попробуйте снова!\x1b[0m";
                                cout << "Введите любую цифру ";
                                cin >> error;
                                break;
                        }
                    }
                    break;
                case 3:
                    system("cls");
                    cout << "\t\t\x1b[9" << color << "mПРАВИЛА\x1b[0m\n\n";
                    cout << " - Игрок получает очки за правильный ответ на вопрос;\n";
                    cout << " - Игрок проходит дальше за правильный ответ;\n";
                    cout << " - Игрок теряет жизнь при неправильном ответе.\n";
                    cout << "Для возврата введите любое число ";
                    cin >> back;
                    break;
                case 4:
                    return 0;
                    break;
                default:
                    system("cls");
                    cout << "\x1b[91m Ошибка ввода! Попробуйте снова!\x1b[0m";
                    cout << "Введите любую цифру ";
                    cin >> error;
                    break;
            }
        }


        int _; cin >> _;
        return 0;
    }
}
}
