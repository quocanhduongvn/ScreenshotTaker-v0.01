﻿using DevExpress.Utils;
using DevExpress.XtraPrinting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static DevExpress.Data.Helpers.FindSearchRichParser;

namespace ScreenshotTaker_v0._01
{
    public partial class Screenshot: Form
    {
        private String logPicDirectory = "";
        private bool isRunning = false;
        private List<CancellationTokenSource> ctsList = new List<CancellationTokenSource>();
        // Đường dẫn đến file CSV
        string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "settime.csv");

        
        public Screenshot()
        {
            InitializeComponent();
            logPicDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Screenshots");

            labelLogPath.Text = logPicDirectory;
            this.KeyPreview = true; // Đảm bảo Form nhận sự kiện phím
            btnLoadTime_Click(this, EventArgs.Empty);//Load file
            //run khi mo ct
           // btnStartStop_Click(this, EventArgs.Empty);
            // Lấy đường dẫn thư mục chứa ứng dụng

           
          
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLoadTime_Click(object sender, EventArgs e)
        {
           

            if (File.Exists(filePath))
            {
                // Đọc dữ liệu từ file CSV
                string[] lines = File.ReadAllLines(filePath);
                listBoxTime.Items.Clear(); // Xóa các mục cũ trong ListBox

                foreach (string line in lines)
                {
                    listBoxTime.Items.Add(line); // Thêm từng dòng vào ListBox
                }
            }
            else
            {
                MessageBox.Show("File không tồn tại.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (    listBoxTime.SelectedItem != null)
            {
                string selectedItem = listBoxTime.SelectedItem.ToString();
                listBoxTime.Items.Remove(selectedItem);
                UpdateFile(selectedItem); 
                btnLoadTime_Click(this, EventArgs.Empty); // Tự động gọi sự kiện Click
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mục để xóa.");
            }
        }
        private void UpdateFile(string itemToRemove = null)
        {
            // Lấy tất cả các mục hiện có từ ListBox
            var currentItems = listBoxTime.Items.Cast<string>().ToList();

            // Nếu có item cần xóa, loại bỏ nó khỏi danh sách
            if (itemToRemove != null)
            {
                currentItems.Remove(itemToRemove);
            }

            // Xóa các giá trị trùng lặp
            var distinctItems = currentItems.Distinct().ToList();

            // Sắp xếp danh sách theo thứ tự
            distinctItems.Sort();

            // Ghi lại toàn bộ nội dung vào file
            File.WriteAllLines(filePath, distinctItems);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            int hour = (int)numericUpDownHour.Value;
            int minute = (int)numericUpDownMin.Value;
            String inPut ;
            inPut = hour.ToString("D2") + ":" + minute.ToString("D2");

            if (!string.IsNullOrWhiteSpace(inPut))
            {
                listBoxTime.Items.Add(inPut);
                UpdateFile();

                btnLoadTime_Click(this, EventArgs.Empty); // Tự động gọi sự kiện Click
            }
            else
            {
                MessageBox.Show("Vui lòng nhập nội dung.");
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show(); // Hiện lại form
            this.WindowState = FormWindowState.Normal; // Đảm bảo trạng thái form
            notifyIcon1.Visible = false;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.Hide();
            notifyIcon1.Visible = true;
        }
       

        

        private void btnStartStop_Click(object sender, EventArgs e)
        {   
            try
            {
                List<TimeSpan> schedules = ReadSchedulesFromCsv(filePath);
                foreach (var timeOfDay in schedules)
                {
                    var cts = new CancellationTokenSource();
                    ctsList.Add(cts);
                    _ = ScreenshotLoop(timeOfDay, cts.Token);
                }

                btnStartStop.Enabled = false; // Vô hiệu hóa nút Start
                btnStop.Enabled = true; // Kích hoạt nút Stop

                statusLabel.Text = "Đang Tự Chụp Màn Hình ...";
                statusLabel.ForeColor = Color.Green;
                BackColor = Color.Green;
                panelAdd.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            foreach (var cts in ctsList)
            {
                cts.Cancel();
            }
            ctsList.Clear();

            btnStartStop.Enabled = true; // Kích hoạt nút Start
            btnStop.Enabled = false; // Vô hiệu hóa nút Stop

            // Hành động dừng
            statusLabel.Text = "Đang Chờ";
            statusLabel.ForeColor = Color.Gray;
            BackColor = Color.Gray;
            panelAdd.Enabled = true;
        }
        private  void btnScreenshotNow_Click(object sender, EventArgs e)
        {

            ScreenshotHideForm(1000); // delay 1000ms

        }

        private async void ScreenshotHideForm(int delay)
        {
            this.Hide();
             await Task.Delay(1000); // 1000 ms = 1 giây
            ScreenShotAndSaveTo(logPicDirectory);

            this.Show();
        }
        private void ScreenShotAndSaveTo(string logPicDirectoryNew)
        {
            // Lấy thời gian hiện tại
            DateTime timestamp = DateTime.Now;
           // string logPicDirectoryNew = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ScreenshotsNew");

            // Tạo thư mục "Screenshots" nếu chưa tồn tại
            string dateFolder = timestamp.ToString("yyyy-MM-dd");
            string dailyDirectory = Path.Combine(logPicDirectoryNew, dateFolder);

            Directory.CreateDirectory(dailyDirectory);

            // Đặt tên file cho ảnh chụp
            string filename = $"screenshot_{timestamp:yyyyMMdd_HHmmss}.png";
           string fullPath = Path.Combine(dailyDirectory, filename);

            // Chụp ảnh màn hình
            using (Bitmap bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height))
            {
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.CopyFromScreen(0, 0, 0, 0, Screen.PrimaryScreen.Bounds.Size);
                }

                // Lưu ảnh vào file
                try
                {
                    bmp.Save(fullPath, System.Drawing.Imaging.ImageFormat.Png);
                  
                } catch (Exception ex)
                {
                    MessageBox.Show($"Không thể lưu ảnh chụp màn hình. Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
        }


        
        private List<TimeSpan> ReadSchedulesFromCsv(string csvPath)
        {
            List<TimeSpan> schedules = new List<TimeSpan>();
            string[] lines = File.ReadAllLines(csvPath);
            for (int i = 1; i < lines.Length; i++) // Bỏ qua dòng tiêu đề
            {
                string line = lines[i].Trim();
                if (TimeSpan.TryParse(line, out TimeSpan ts))
                {
                    schedules.Add(ts);
                }
            }
            return schedules;
        }

        private async Task ScreenshotLoop(TimeSpan timeOfDay, CancellationToken ct)
        {
           // MessageBox.Show("Vong lap bat dau");

            while (!ct.IsCancellationRequested)
          
            {
                // Chờ cho đến thời gian đã chỉ định
                DateTime now = DateTime.Now;
                DateTime nextRun = DateTime.Today.Add(timeOfDay);

                if (nextRun < now)
                {
                    nextRun = nextRun.AddDays(1); // Nếu thời gian đã qua, lên lịch cho ngày tiếp theo
                }

                TimeSpan waitTime = nextRun - now;
               labelTimeCount.Text = waitTime.ToString();
                await Task.Delay(waitTime); // Chờ đến thời gian đã chỉ định

                if (!ct.IsCancellationRequested)
                {
                   
                    btnScreenshotNow_Click(this, EventArgs.Empty);
                }
            }


        }

       

        private void numericUpDownMin_ValueChanged(object sender, EventArgs e)
        {
            // Kiểm tra nếu giá trị vượt quá Maximum
            if (numericUpDownMin.Value > 59)
            {
                numericUpDownMin.Value = 0; // Đặt lại về Minimum
            }
            // Kiểm tra nếu giá trị dưới Minimum
            else if (numericUpDownMin.Value < 0)
            {
                numericUpDownMin.Value = 59; // Đặt lại về Maximum
            }
        }

        private void numericUpDownHour_ValueChanged(object sender, EventArgs e)
        {
            // Kiểm tra nếu giá trị vượt quá Maximum
            if (numericUpDownHour.Value > 23)
            {
                numericUpDownHour.Value = 0; // Đặt lại về Minimum
            }
            // Kiểm tra nếu giá trị dưới Minimum
            else if (numericUpDownHour.Value < 0)
            {
                numericUpDownHour.Value = 23; // Đặt lại về Maximum
            }
        }

        private void btnFolderPath_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Chọn thư mục"; // Mô tả cho hộp thoại

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string folderPath = folderBrowserDialog.SelectedPath; // Lấy đường dẫn thư mục
                    labelLogPath.Text = folderPath; // Hiển thị đường dẫn trong TextBox
                    logPicDirectory = folderPath;
                }
            }
        }

        private  void KeyScreenShot(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.P)
            {
                btnScreenshotNow_Click(this, EventArgs.Empty);
            }
        }

       
    }
}
