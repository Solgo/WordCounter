using System;
using System.Collections.Generic;

namespace Repeat.Objects
{
  public class RepeatCounter
  {
    private string _userWord;
    private string _userSentence;
    private string[] _userSentenceArray;
    private int _instances = 0;

    public RepeatCounter(string UserWord, string UserSentence)
    {
    _userWord = UserWord;
    _userSentence = UserSentence;
    }

    public int RepeatCounts()
    {
      _userWord = _userWord.ToLower();
      _userSentence = _userSentence.ToLower();
      _userSentenceArray = _userSentence.Split(' ' , ',' , '.' , '?' , '!');
      for(int i = 0; i <= _userSentenceArray.Length -1; i++)
      {
        if(_userWord == _userSentenceArray[i])
        {
          _instances += 1;
        }
      }
      return _instances;
    }
  }
}
