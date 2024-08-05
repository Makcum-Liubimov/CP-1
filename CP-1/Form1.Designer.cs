namespace CP_1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button showScheduleButton;
        private System.Windows.Forms.ListBox scheduleListBox;
        private System.Windows.Forms.Button buyTicketButton;
        private System.Windows.Forms.Button myTicketsButton;
        private System.Windows.Forms.ListBox ticketsListBox;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.showScheduleButton = new System.Windows.Forms.Button();
            this.scheduleListBox = new System.Windows.Forms.ListBox();
            this.buyTicketButton = new System.Windows.Forms.Button();
            this.myTicketsButton = new System.Windows.Forms.Button();
            this.ticketsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // showScheduleButton
            // 
            this.showScheduleButton.Location = new System.Drawing.Point(12, 12);
            this.showScheduleButton.Name = "showScheduleButton";
            this.showScheduleButton.Size = new System.Drawing.Size(150, 23);
            this.showScheduleButton.TabIndex = 0;
            this.showScheduleButton.Text = "Показати розклад";
            this.showScheduleButton.UseVisualStyleBackColor = true;
            this.showScheduleButton.Click += new System.EventHandler(this.showScheduleButton_Click);
            // 
            // scheduleListBox
            // 
            this.scheduleListBox.FormattingEnabled = true;
            this.scheduleListBox.ItemHeight = 16;
            this.scheduleListBox.Location = new System.Drawing.Point(12, 41);
            this.scheduleListBox.Name = "scheduleListBox";
            this.scheduleListBox.Size = new System.Drawing.Size(360, 132);
            this.scheduleListBox.TabIndex = 1;
            // 
            // buyTicketButton
            // 
            this.buyTicketButton.Location = new System.Drawing.Point(12, 179);
            this.buyTicketButton.Name = "buyTicketButton";
            this.buyTicketButton.Size = new System.Drawing.Size(150, 23);
            this.buyTicketButton.TabIndex = 2;
            this.buyTicketButton.Text = "Придбати квиток";
            this.buyTicketButton.UseVisualStyleBackColor = true;
            this.buyTicketButton.Click += new System.EventHandler(this.buyTicketButton_Click);
            // 
            // myTicketsButton
            // 
            this.myTicketsButton.Location = new System.Drawing.Point(168, 179);
            this.myTicketsButton.Name = "myTicketsButton";
            this.myTicketsButton.Size = new System.Drawing.Size(150, 23);
            this.myTicketsButton.TabIndex = 3;
            this.myTicketsButton.Text = "Мої квитки";
            this.myTicketsButton.UseVisualStyleBackColor = true;
            this.myTicketsButton.Visible = false;
            this.myTicketsButton.Click += new System.EventHandler(this.myTicketsButton_Click);
            // 
            // ticketsListBox
            // 
            this.ticketsListBox.FormattingEnabled = true;
            this.ticketsListBox.ItemHeight = 16;
            this.ticketsListBox.Location = new System.Drawing.Point(12, 208);
            this.ticketsListBox.Name = "ticketsListBox";
            this.ticketsListBox.Size = new System.Drawing.Size(360, 132);
            this.ticketsListBox.TabIndex = 4;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.ticketsListBox);
            this.Controls.Add(this.myTicketsButton);
            this.Controls.Add(this.buyTicketButton);
            this.Controls.Add(this.scheduleListBox);
            this.Controls.Add(this.showScheduleButton);
            this.Name = "MainForm";
            this.Text = "Головна";
            this.ResumeLayout(false);
        }
    }
}
