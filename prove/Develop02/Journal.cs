public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    //add a new entry to the journal
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    //display all entries in the journal
    public void Display()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }
    //save the entries to a file

    //Showing Creativity and Exceeding Requirements
    //Improve the process of saving and loading to save as a .csv 
    //file that could be opened in Excel (make sure to account for quotation 
    //marks and commas correctly in your content.
    public void SaveToFile(string file)
    {
        bool fileExists = File.Exists(file);

        using (StreamWriter writer = new StreamWriter(file, true))
        {   
            //write header if the file doesn't exist
            if (!fileExists)
            {
                writer.WriteLine("Date,Prompt,Entry");
            }
            //write each entry to the file
            foreach (var entry in _entries)
            {
                writer.WriteLine($"{entry._date},{entry._prompt},{entry._entryText}");
            }
        }
        //clear the entries after saving
        //_entries.Clear();
    }
    //load journal entries from a file
    public void LoadFromFile(string file)
    {
        if (File.Exists(file))
        {
            _entries.Clear();

            using (StreamReader reader = new StreamReader(file))
            {
                //ignora a linha de cabeçalho
                reader.ReadLine();
                string line;
                while ((line = reader.ReadLine()) != null)
                {   
                    //split the line into parts and add a new entry
                    var parts = line.Split(new[] { ',' }, 3);
                    if (parts.Length == 3)
                    {
                        AddEntry(new Entry { _date = parts[0], _prompt = parts[1], _entryText = parts[2] });
                    }
                }
            }
        }
    }
}