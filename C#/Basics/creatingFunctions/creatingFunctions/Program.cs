// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
 * 1. Bir kelime koleksiyonu içinden rastgele bir kelime SEÇ.
 * 2. Seçilen kelimeyi, "* * * *" biçiminde bulmacaya ÇEVİR.
 * 3. Kullanıcıdan harf İSTE.
 * 4. girilen Harfi Kelimede ARA
 * 5. Varsa; o yıldızı harfe ÇEVİR
 * 6. Tüm *'lar açılana kadar bu adımlar devam etsin.
 * 
 * 
 */
List<string> words = new List<string>() { "ayna" };
var choosingWord = getRandomWord(words);
var puzzledWord = convertToPuzzle(choosingWord);
showOnScreen(puzzledWord);
string suggestedLetter = getLetterFromUser();
if (isLetterFindInWord(choosingWord, suggestedLetter))
{
    puzzledWord = replaceStarWithLetter(choosingWord, puzzledWord, suggestedLetter);
    showOnScreen(puzzledWord);
}
else
{
    showOnScreen("Bir hakkınız yandı...");
}




string getRandomWord(List<string> words)
{
    var index = new Random().Next(words.Count);
    return words[index];
}

string convertToPuzzle(string word)
{
    string puzzle = string.Empty;
    for (int i = 0; i < word.Length; i++)
    {
        puzzle += "*";
    }
    return puzzle;

}



void showOnScreen(string word)
{
    Console.WriteLine(word);
}

string getLetterFromUser()
{
    Console.WriteLine("Bir harf giriniz....");
    return Console.ReadLine();
}

bool isLetterFindInWord(string word, string letter)
{
    return word.ToLower().Contains(letter.ToLower());
}

string replaceStarWithLetter(string word, string puzzle, string harf)
{
    return "a**a";
}

//Clean Code kitabında en iyi kod; tek satırdan oluşur der ve bu örneği verir:

//bool isEven(int number)
//{
//    return number % 2 == 0;
//}
//Elbette, her fonksiyon bu biçimde YAZILAMAZ.