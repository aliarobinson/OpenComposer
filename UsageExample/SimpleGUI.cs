using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using AliaRobinson.OpenComposer.Tracks;

namespace UsageExample
{
    public class SimpleGUI : Form
    {
        private Button startButton;
        private Button stopButton;

        private TrackSynchronizer ts;

        public SimpleGUI()
        {
            startButton = new Button();
            stopButton = new Button();
            startButton.Text = "Start";
            stopButton.Text = "Stop";

            startButton.Location = new Point(20, 20);
            stopButton.Location = new Point(180, 20);
            
            startButton.Click += new EventHandler(StartButtonClick);
            stopButton.Click += new EventHandler(StopButtonClick);
            
            this.Controls.Add(startButton);
            this.Controls.Add(stopButton);
        }

        public void SetTrackSynchronizer(TrackSynchronizer ts)
        {
            this.ts = ts;
        }

        void StartButtonClick(object sender, EventArgs e)
        {
            if (ts != null)
            {
                Console.WriteLine("Starting");
                ts.Start();
                
            }

        }
        
        void StopButtonClick(object sender, EventArgs e)
        {
            if (ts != null)
            {
                Console.WriteLine("Stopping");
                ts.Stop();
            }
        }
    }
}