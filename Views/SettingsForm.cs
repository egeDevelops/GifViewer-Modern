using GIF_Viewer.Utils;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GIF_Viewer.Views
{
    /// <summary>
    /// Represents a form where the user can change the settings of the program
    /// </summary>
    public partial class SettingsForm : Form
    {
        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        private void ApplyDarkMode()
        {
            // Try attribute 20 (Windows 11 and Win 10 20H1+)
            int useDarkMode = 1;
            if (DwmSetWindowAttribute(this.Handle, 20, ref useDarkMode, sizeof(int)) != 0)
            {
                // If 20 fails, try attribute 19 (Older Windows 10)
                DwmSetWindowAttribute(this.Handle, 19, ref useDarkMode, sizeof(int));
            }
        }
        /// <summary>
        /// Temporary buffer memory variable reference
        /// </summary>
        private int _bufferMemory;
        /// <summary>
        /// Temporary keyframe memory variable reference
        /// </summary>
        private int _keyframeMemory;
        /// <summary>
        /// Temporary keyframe reach variable reference
        /// </summary>
        private int _keyframeReach;

        /// <summary>
        /// Initializes a new instance of the SettingsForm class
        /// </summary>
        public SettingsForm()
        {
            InitializeComponent();
            ApplyDarkMode();
            _bufferMemory = Settings.Instance.MaxBufferMemory;
            _keyframeMemory = Settings.Instance.MaxKeyframeMemory;
            _keyframeReach = Settings.Instance.MaxKeyframeReach;

            SetTrackbarValueRelative(tb_bufferMemory, _bufferMemory, 5, 512);
            SetTrackbarValueRelative(tb_keyframeMemory, _keyframeMemory, 5, 512);
            SetTrackbarValueRelative(tb_keyframeReach, _keyframeReach, 0, 100);

            lbl_bufferMemory.Text = Settings.Instance.MaxBufferMemory + @" MB";
            lbl_keyframeMemory.Text = Settings.Instance.MaxKeyframeMemory + @" MB";
            lbl_keyframeReach.Text = Settings.Instance.MaxKeyframeReach + "";

            cb_allowMultipleInstances.Checked = !Settings.Instance.SingleInstance;

            cb_setMinimumDelay.Checked = Settings.Instance.SetMinimumDelayOnStartup;
            nud_minimumFrameDelay.Value = Settings.Instance.MinimumFrameDelay;
        }

        // 
        // Ok button click
        // 
        private void btn_ok_Click(object sender, EventArgs e)
        {
            Settings.Instance.SingleInstance = !cb_allowMultipleInstances.Checked;

            Settings.Instance.SetMinimumDelayOnStartup = cb_setMinimumDelay.Checked;
            Settings.Instance.MinimumFrameDelay = (int)nud_minimumFrameDelay.Value;

            Settings.Instance.MaxBufferMemory = _bufferMemory;
            Settings.Instance.MaxKeyframeMemory = _keyframeMemory;
            Settings.Instance.MaxKeyframeReach = _keyframeReach;

            Settings.Instance.SaveSettings();

            DialogResult = DialogResult.OK;
            Close();
        }

        // 
        // Maximum Buffer Memory trackbar scroll
        // 
        private void tb_bufferMemory_Scroll(object sender, EventArgs e)
        {
            _bufferMemory = GetTrackbarValueRelative(tb_bufferMemory, 5, 512);
            lbl_bufferMemory.Text = _bufferMemory + @" MB";
        }

        // 
        // Maximum Buffer Memory trackbar scroll
        // 
        private void tb_keyframeMemory_Scroll(object sender, EventArgs e)
        {
            _keyframeMemory = GetTrackbarValueRelative(tb_keyframeMemory, 5, 512);
            lbl_keyframeMemory.Text = _keyframeMemory + @" MB";
        }

        // 
        // Maximum Buffer Memory trackbar scroll
        // 
        private void tb_keyframeReach_Scroll(object sender, EventArgs e)
        {
            _keyframeReach = GetTrackbarValueRelative(tb_keyframeReach, 0, 100);
            lbl_keyframeReach.Text = _keyframeReach + "";
        }

        /// <summary>
        /// Updates the value of the given trackbar utilizing the given range of values
        /// </summary>
        /// <param name="bar">The trackbar to update</param>
        /// <param name="value">The value to set on the trackbar</param>
        /// <param name="minValue">The minimum value to scale to</param>
        /// <param name="maxValue">The maximum value to scale to</param>
        private void SetTrackbarValueRelative(TrackBar bar, int value, int minValue, int maxValue)
        {
            float realValue = (float)(value - minValue) / (maxValue - minValue);

            bar.Value = (int)(bar.Minimum + (bar.Maximum - bar.Minimum) * realValue);
        }

        /// <summary>
        /// Gets a value that is the value of the given trackbar scaled to the given range
        /// </summary>
        /// <param name="bar">The trackbar to get the value from</param>
        /// <param name="minValue">The minimum value to scale to</param>
        /// <param name="maxValue">The maximum value to scale to</param>
        /// <returns>A value that ranges from minValue - maxValue based on the given trackbar's progress</returns>
        private int GetTrackbarValueRelative(TrackBar bar, int minValue, int maxValue)
        {
            float realValue = (float)(bar.Value - bar.Minimum) / (bar.Maximum - bar.Minimum);

            return (int)(minValue + (maxValue - minValue) * realValue);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_bufferMemory_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lbl_keyframeMemory_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void lbl_keyframeReach_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void cb_setMinimumDelay_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb_allowMultipleInstances_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {

        }
    }
}