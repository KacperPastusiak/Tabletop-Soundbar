namespace Tabletop_Soundbar
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PlayBtn = new Button();
            SongPathTextBox = new TextBox();
            PauseBtn = new Button();
            SetSongPathBtn = new Button();
            CurrentSongLbl = new Label();
            SongPathLbl = new Label();
            SuspendLayout();
            // 
            // PlayBtn
            // 
            PlayBtn.Location = new Point(15, 212);
            PlayBtn.Margin = new Padding(6, 4, 6, 4);
            PlayBtn.Name = "PlayBtn";
            PlayBtn.Size = new Size(240, 36);
            PlayBtn.TabIndex = 0;
            PlayBtn.Text = "Play";
            PlayBtn.UseVisualStyleBackColor = true;
            PlayBtn.Click += PlayBtn_Click;
            // 
            // SongPathTextBox
            // 
            SongPathTextBox.Location = new Point(15, 37);
            SongPathTextBox.Margin = new Padding(6, 4, 6, 4);
            SongPathTextBox.Name = "SongPathTextBox";
            SongPathTextBox.Size = new Size(754, 32);
            SongPathTextBox.TabIndex = 1;
            // 
            // PauseBtn
            // 
            PauseBtn.Location = new Point(267, 212);
            PauseBtn.Margin = new Padding(6, 4, 6, 4);
            PauseBtn.Name = "PauseBtn";
            PauseBtn.Size = new Size(240, 36);
            PauseBtn.TabIndex = 3;
            PauseBtn.Text = "Pause";
            PauseBtn.UseVisualStyleBackColor = true;
            PauseBtn.Click += PauseBtn_Click;
            // 
            // SetSongPathBtn
            // 
            SetSongPathBtn.Location = new Point(15, 77);
            SetSongPathBtn.Margin = new Padding(6, 4, 6, 4);
            SetSongPathBtn.Name = "SetSongPathBtn";
            SetSongPathBtn.Size = new Size(406, 36);
            SetSongPathBtn.TabIndex = 5;
            SetSongPathBtn.Text = "Set song";
            SetSongPathBtn.UseVisualStyleBackColor = true;
            SetSongPathBtn.Click += SetSongPathBtn_Click;
            // 
            // CurrentSongLbl
            // 
            CurrentSongLbl.AutoSize = true;
            CurrentSongLbl.Location = new Point(15, 167);
            CurrentSongLbl.Name = "CurrentSongLbl";
            CurrentSongLbl.Size = new Size(178, 24);
            CurrentSongLbl.TabIndex = 6;
            CurrentSongLbl.Text = "Current song: ";
            // 
            // SongPathLbl
            // 
            SongPathLbl.AutoSize = true;
            SongPathLbl.Location = new Point(15, 9);
            SongPathLbl.Name = "SongPathLbl";
            SongPathLbl.Size = new Size(238, 24);
            SongPathLbl.TabIndex = 7;
            SongPathLbl.Text = "Put song path here:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 261);
            Controls.Add(SongPathLbl);
            Controls.Add(CurrentSongLbl);
            Controls.Add(SetSongPathBtn);
            Controls.Add(PauseBtn);
            Controls.Add(SongPathTextBox);
            Controls.Add(PlayBtn);
            Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Margin = new Padding(6, 4, 6, 4);
            Name = "MainForm";
            Text = "Tabletop Soundbar";
            FormClosed += MainForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button PlayBtn;
        private TextBox SongPathTextBox;
        private Button PauseBtn;
        private Button SetSongPathBtn;
        private Label CurrentSongLbl;
        private Label SongPathLbl;
    }
}
