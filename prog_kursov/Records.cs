using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace prog_kursov
{
    public class Record
    {
        public string PlayerName { get; set; } 
        public int Seconds { get; set; }
        public DateTime Date { get; set; }

        public override string ToString()
        {
            return $"{PlayerName} - {Seconds} сек - {Date.ToShortDateString()}";
        }
    }

    public static class Records
    {
        private static string filePath = "records.txt";

        // Сохранить рекорд
        public static void SaveRecord(string playerName, int seconds)
        {
            List<Record> records = LoadRecords();

            records.Add(new Record
            {
                PlayerName = playerName,
                Seconds = seconds,
                Date = DateTime.Now
            });

            // Сортируем по времени
            records = records.OrderBy(r => r.Seconds).Take(5).ToList();

            // Сохраняем в файл
            SaveToFile(records);
        }

        // Загрузить рекорды
        public static List<Record> LoadRecords()
        {
            List<Record> records = new List<Record>();

            if (!File.Exists(filePath))
                return records;

            try
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 3)
                    {
                        records.Add(new Record
                        {
                            PlayerName = parts[0],
                            Seconds = int.Parse(parts[1]),                      
                            Date = DateTime.Parse(parts[2])
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки рекордов: {ex.Message}");
            }

            return records.OrderBy(r => r.Seconds).Take(5).ToList();
        }

        // Сохранить в файл
        private static void SaveToFile(List<Record> records)
        {
            try
            {
                List<string> lines = new List<string>();
                foreach (var record in records)
                {
                    lines.Add($"{record.PlayerName}|{record.Seconds}|{record.Date}");
                }
                File.WriteAllLines(filePath, lines);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения рекорда: {ex.Message}");
            }
        }

        // Получить текст для отображения рейтинга
        public static string GetRecordsText()
        {
            var records = LoadRecords(); 
            if (records.Count == 0)
                return "Пока нет рекордов";

            string text = "";
            for (int i = 0; i < records.Count; i++)
            {
                text += $"{i + 1}. {records[i]}\n";
            }
            return text;
        }
    }
}