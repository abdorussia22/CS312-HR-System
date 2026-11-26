using System.Drawing.Drawing2D;
using HRSystem.Data;

namespace HRSystem.Forms
{
    public partial class ChartsForm : Form
    {
        // ألوان نستخدمها في الرسم
        private readonly Color[] palette =
        {
            Color.SteelBlue, Color.SeaGreen, Color.Orange,
            Color.IndianRed, Color.MediumPurple, Color.Goldenrod
        };

        public ChartsForm()
        {
            InitializeComponent();
        }

        private void ChartsForm_Load(object sender, EventArgs e)
        {
            DataStore.Load();
        }

        // زرار Refresh: يقرا البيانات ويعيد الرسم
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataStore.Load();
            pnlBar.Invalidate();
            pnlPie.Invalidate();
        }

        // ===== Bar Chart: عدد الموظفين في كل قسم =====
        private void pnlBar_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            var data = DataStore.Employees
                .GroupBy(x => x.Department)
                .Select(grp => new { Name = grp.Key, Count = grp.Count() })
                .ToList();

            using var titleFont = new Font("Segoe UI", 12, FontStyle.Bold);
            using var textFont = new Font("Segoe UI", 9);

            g.DrawString("Employees per Department", titleFont, Brushes.Black, 10, 8);

            if (data.Count == 0)
            {
                g.DrawString("No data yet", textFont, Brushes.Gray, 10, 50);
                return;
            }

            int w = pnlBar.Width, h = pnlBar.Height;
            int left = 30, right = 20, top = 50, bottom = 40;
            int chartH = h - top - bottom;
            int slot = (w - left - right) / data.Count;
            int barW = slot - 20;
            int max = data.Max(d => d.Count);

            // المحور الأفقي
            g.DrawLine(Pens.Black, left, h - bottom, w - right, h - bottom);

            for (int i = 0; i < data.Count; i++)
            {
                int barH = (int)(chartH * (double)data[i].Count / max);
                int x = left + i * slot + 10;
                int y = h - bottom - barH;

                using var brush = new SolidBrush(palette[i % palette.Length]);
                g.FillRectangle(brush, x, y, barW, barH);

                // الرقم فوق العمود
                g.DrawString(data[i].Count.ToString(), textFont, Brushes.Black, x + barW / 2 - 6, y - 18);
                // اسم القسم تحت العمود
                g.DrawString(data[i].Name, textFont, Brushes.Black, x, h - bottom + 5);
            }
        }

        // ===== Pie Chart: إجمالي المرتبات لكل قسم =====
        private void pnlPie_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            var data = DataStore.Employees
                .GroupBy(x => x.Department)
                .Select(grp => new { Name = grp.Key, Total = grp.Sum(x => x.Salary) })
                .ToList();

            using var titleFont = new Font("Segoe UI", 12, FontStyle.Bold);
            using var textFont = new Font("Segoe UI", 9);

            g.DrawString("Salary Share per Department", titleFont, Brushes.Black, 10, 8);

            decimal total = data.Sum(d => d.Total);
            if (total == 0)
            {
                g.DrawString("No data yet", textFont, Brushes.Gray, 10, 50);
                return;
            }

            var rect = new Rectangle(20, 60, 260, 260);
            float start = -90;

            for (int i = 0; i < data.Count; i++)
            {
                float sweep = 360f * (float)(data[i].Total / total);
                using var brush = new SolidBrush(palette[i % palette.Length]);
                g.FillPie(brush, rect, start, sweep);
                g.DrawPie(Pens.White, rect, start, sweep);
                start += sweep;

                // الليجند (مفتاح الألوان) على اليمين
                int ly = 70 + i * 28;
                g.FillRectangle(brush, 300, ly, 16, 16);
                int percent = (int)Math.Round(data[i].Total / total * 100);
                g.DrawString($"{data[i].Name} ({percent}%)", textFont, Brushes.Black, 322, ly);
            }
        }
    }
}