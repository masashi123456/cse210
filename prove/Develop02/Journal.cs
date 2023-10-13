using System;

public class Journal{

    public List<Entry>_entries = new List<Entry>();
    public string _userName;
    public int _points;

    public void AddEntry(Entry entry){
        _entries.Add(entry);
    }

    public void DisplayJournal(){
        foreach(Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }

    public void AddPoints(int points){
        _points += points;
    }
}