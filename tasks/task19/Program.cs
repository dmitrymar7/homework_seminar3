// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

bool IsPalindrome(String word){
    
    if(word.Length == 0){
        return false;
    }

    for (int i = 0; i < word.Length / 2; i++){
        if (word[i] != word[word.Length - 1 - i]){
            return false;
        }
    }   
    return true; 
}

Console.Write("Введите число: ");
string num = Console.ReadLine();
if (IsPalindrome(num)){
    Console.WriteLine("Да");
}
else{
   Console.WriteLine("Нет"); 
}

