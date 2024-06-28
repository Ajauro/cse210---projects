using System;

//Os comportamentos-chave para a Wordclasse são ocultar 
//e mostrar uma palavra e verificar se uma palavra está oculta ou não
//rastreia uma única palavra e se ela é mostrada ou ocultada.
public class Word
{
    private string _text; //armazena a palavra
    private bool _isHidden; //indica se a palavra esta oculta

    public Word( string text)
    {
        _text = text;
        _isHidden = false;
    }
    public void Hide() //hide oculta a palavra
    {
        _isHidden = true;
    }
    public void Show() //show mostra a palavra
    {
        _isHidden = false;
    }
    public string GetDisplayText() // retorna a palavra ou underscore se estiver oculta
    {
        return _isHidden ? "____" : _text;
    }
    public bool IsHidden() //verifica se a palavra está oculta
    {
        return _isHidden;
    }

}