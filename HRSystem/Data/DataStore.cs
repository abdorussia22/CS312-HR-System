using System.Text.Json;
using HRSystem.Models;

namespace HRSystem.Data
{
    public static class DataStore
    {
        private static readonly string FilePath =
            Path.Combine(AppContext.BaseDirectory, "employees.json");

        public static List<Employee> Employees { get; private set; } = new();

        // قراءة الموظفين من الملف (لو الملف مش موجود تبدأ بقايمة فاضية)
        public static void Load()
        {
            try
            {
                if (File.Exists(FilePath))
                {
                    string json = File.ReadAllText(FilePath);
                    Employees = JsonSerializer.Deserialize<List<Employee>>(json) ?? new();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
                Employees = new();
            }
        }

        // حفظ الموظفين في الملف
        public static void Save()
        {
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                File.WriteAllText(FilePath, JsonSerializer.Serialize(Employees, options));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message);
            }
        }

        // رقم جديد لكل موظف
        public static int NextId()
        {
            return Employees.Count == 0 ? 1 : Employees.Max(e => e.Id) + 1;
        }
    }
}