

// public class Journal
// {
//     private List<Entry> _entries;
//     _entries = new List<Entry>(); 

//     public void AddEntry(Entry newEntry)
//     {
//         _entries.Add(newEntry);
//     }

//     public void Display()
//     {
//         foreach (var entry in _entries)
//         {
//             entry.Display();
//         }
//     }

//     public void SaveToFile(string file) 
//     {
//         using (var workbook = new ClosedXML.Excel.XLWorkbook())
//         {
//             var sheets = workbook.Sheets.Add("Entries");

//             //cabeçalho das colunas
//             sheets.Cell(1, 1).Value = "Date:";
//             sheets.Cell(1, 2).Value = "Prompt:";
//             sheets.Cell(1, 3).Value = "Entry: ";
//             //escreve as entradas 
//             int row = 2;
//             foreach (var entry in _entries)
//             {
//                 sheets.Cell(row, 1).Value = entry._date;
//                 sheets.Cell(row, 2).Value = entry._prompt;
//                 sheets.Cell(row, 3).Value = entry._entryText;
//                 row++;
//             }
//             //salva o arquivo excel
//             workbook.SaveAs("journal.xlsx");
//         }
//     }

//     public void LoadFromFile (string file)
//     {
//         if (File.Exists(file))
//         {
//             using (var workbook = new XLWorkbook(file))
//             {
//                 var sheets = workbook.Sheets(1);

//                 foreach (var row in sheets.RowsUsed().Skip(1))
//                 {
//                     string _date = row.Cell(1).Value.ToString();
//                     string _prompt = row.Cell(2).Value.ToString();
//                     string _entryText = row.Cell(3).Value.ToString();

//                     AddEntry (new Entry {Date = _date, Prompt = _prompt, EntryText = _entryText});
//                 }
//             }
//         }
//     }
// }