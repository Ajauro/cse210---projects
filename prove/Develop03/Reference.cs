using System;

//Deve ter a capacidade de obter o texto de exibição da referência, 
//que é apenas uma string combinando o livro, capítulo e versículo (ou versículos).
//Mantém o controle das informações do livro, capítulo e versículo.
public class Reference 
{
    //_book, _chapter, _verse, _endVerse armazenam os detalhes da referencia
    private string _book {get; set;}
    private int _chapter {get; set;}
    private int _verse {get; set;}
    private int _endVerse {get; set;}

    //public Reference() {}
    //dois contrutores são criados para lidar com casos de versículo unico e versiculos compostos
    public Reference (string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = verse;
    }
    public Reference (string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    public string GetDisplayText() //retorna a referencia formatada
    {
        if (_verse == _endVerse)
        {
            return $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
    }
}