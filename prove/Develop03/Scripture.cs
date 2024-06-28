using System;
//Os principais comportamentos da Scriptureclasse são ocultar palavras aleatórias 
//e também obter o texto exibido como uma string. 
//Mantém o controle tanto da referência quanto 
//do texto da escritura. Pode ocultar palavras e obter a exibição renderizada do texto.
public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(" ").Select(word => new Word(word)).ToList();
    }
    public void HideRandomWords( int numberToHide)
    {
        Random random = new Random();
        List<Word> visibleWords = _words.Where(word => ! word.IsHidden()).ToList();
        List<Word> wordsToHide = visibleWords.OrderBy(x => random.Next()).Take(numberToHide).ToList();
        foreach (Word word in wordsToHide)
        {
            word.Hide();
        }
    }
    public string GetDisplayText()
    {   
        return $"{_reference.GetDisplayText()} {string.Join(" ", _words.Select(word => word.GetDisplayText()))}";
    }
    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}