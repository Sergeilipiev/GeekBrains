string[] words = new string[4] {"The", "final", "work", "C#"};
string tempStr = "";

void PrintArray (string[] arr) {
    for (int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

for (int i = 0; i < words.Length; i++)
    if (words[i].Length <= 3) 
        tempStr+=words[i]+",";

string[] wordsRes = new string[tempStr.Split(",").SkipLast(1).ToArray().Length];
wordsRes = tempStr.Split(",").SkipLast(1).ToArray();

PrintArray(words);
PrintArray(wordsRes);