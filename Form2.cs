using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Form2 : Form
    {
        private bool isForm1Shown = false;

        public Form2()
        {
            InitializeComponent();
            this.Load += Form2_Load;
            this.timer1.Tick += timer1_Tick;

            // Enable double buffering to reduce flicker.
            this.DoubleBuffered = true;
            panel2.DoubleBuffered(true);
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                // Increment the width in smaller steps and reduce timer interval for smoother animation
                panel2.Width += 2; // Smaller increment for smoother effect
                if (panel2.Width >= 575 && !isForm1Shown)
                {
                    timer1.Stop();
                    isForm1Shown = true;
                    await ShowForm1Async();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                timer1.Stop(); // Stop the timer on error to prevent further issues
            }
        }

        private async Task ShowForm1Async()
        {
            // If you had a long-running operation or a need to delay, you would place it here.
            // For example, let's simulate a delay for demonstration (which you normally wouldn't do just to delay UI):
            await Task.Delay(100);  // Simulate some asynchronous work

            // Now, update the UI thread after the async work is done
            this.Invoke(new Action(() =>
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }));
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Interval = 10; // Shorter intervals for a smoother animation experience
            timer1.Start(); // Explicitly start the timer
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {}
    }
}

public static class ControlExtensions
{
    public static void DoubleBuffered(this Control control, bool enable)
    {
        var doubleBufferPropertyInfo = control.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
        doubleBufferPropertyInfo.SetValue(control, enable, null);
    }
}
