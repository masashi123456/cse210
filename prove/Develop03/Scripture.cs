public class Scripture{

    private string _scriptureText; // declare a variable 
    public Reference _reference;
    List<Word>_words = new  List<Word>();




    // List<int>numbers = new List<int>();

    public Scripture()
    {
        this._reference = new Reference("Proverbs", "2", "5");
        this._scriptureText = "And it came to pass that when my father had heard these words he was exceedingly glad, for he knew that I had been blessed of the Lord.";
        
        String[] Rword = _scriptureText.Split(" ");
        foreach (string word in Rword ){
        _words.Add(new Word(word));
        };
    }

    // Hide a random word in the scripture.
    // Check if all the words have already been hidden before calling this function
    public void ScriptureRandom(){
        if (AllWordsHidden()) return; // Check if all the words are already hidden
        Random rd = new Random();
        int Rindex;
        // Check if the word we selected is already hidden. If it is, then 
        // keep selecting a different word until we find one which is not 
        // hidden.
        do{
            Rindex = rd.Next(_words.Count);
        } while (this._words[Rindex]._isHidden);

        // Hide the word
        this._words[Rindex]._isHidden = true;
    }

    public void DisplayScripture(){
        // Display the whole scripture, but only display words 
        // which are NOT hidden.
        foreach (Word word in this._words){ // Loop through all the words
            // Check if the word is hidden
            if (word._isHidden == true){
                // Print an underscore for each character in the word
                foreach(char character in word._wstring){
                    Console.Write("_");
                } 
                Console.Write(" ");
            }
            // If the word is not hidden, then just display the word as normal.
            else{
                Console.Write($"{word._wstring} ");
            }
        }
    }
    public bool AllWordsHidden(){
        // Look through the entire list of words for a visible word.
        // Once we find a visible word, return false because that means
        // all the words are NOT hidden.
        foreach(Word word in this._words){
            if (! word._isHidden)
                return false;
        }
        // If we manage to exit this loop without returning false, that means
        // that there is not a single visible word in the list.
        return true;
    }
}