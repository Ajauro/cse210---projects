using System;
//Os principais comportamentos da Scriptureclasse são ocultar palavras aleatórias 
//e também obter o texto exibido como uma string. 
//Mantém o controle tanto da referência quanto 
//do texto da escritura. Pode ocultar palavras e obter a exibição renderizada do texto.
public class Scripture
{
    private Reference _reference; //armazena a referencia
    private List<Word> _words; //armazena a lista de objetos Word
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(" ").Select(word => new Word(word)).ToList();
    }
    public void HideRandomWords( int numberToHide) //oculta um conjunto aleatório de palavra visíveis
    {
        Random random = new Random();
        List<Word> visibleWords = _words.Where(word => ! word.IsHidden()).ToList();
        List<Word> wordsToHide = visibleWords.OrderBy(x => random.Next()).Take(numberToHide).ToList();

        foreach (Word word in wordsToHide)
        {
            word.Hide();
        }
    }

    public string GetFullText()
    {
        return $"{_reference.GetDisplayText()}\n{string.Join(" ", _words.Select(word => word.GetDisplayText()))}\n";
    }
    public string GetDisplayText() //retorna o texto da escritura com palavras ocultas
    {   
        return $"{_reference.GetDisplayText()}\n{string.Join(" ", _words.Select(word => word.GetDisplayText()))}\n";
    }
    public bool IsCompletelyHidden() //verifica se todas as palavras estão ocultas
    {
        return _words.All(word => word.IsHidden());
    }
}