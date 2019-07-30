namespace BookStudyRoom
{
    partial class UserHistory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserHistory));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label10 = new System.Windows.Forms.Label();
            this.btnFind = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.dropFields = new Bunifu.Framework.UI.BunifuDropdown();
            this.txtValue = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.dataGrid1 = new Bunifu.UI.WinForms.BunifuDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(618, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 20);
            this.label10.TabIndex = 48;
            this.label10.Text = "Find";
            // 
            // btnFind
            // 
            this.btnFind.ActiveImage = null;
            this.btnFind.AllowAnimations = true;
            this.btnFind.AllowZooming = true;
            this.btnFind.BackColor = System.Drawing.Color.Transparent;
            this.btnFind.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnFind.ErrorImage")));
            this.btnFind.FadeWhenInactive = false;
            this.btnFind.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.ImageActive = null;
            this.btnFind.ImageLocation = null;
            this.btnFind.ImageMargin = 40;
            this.btnFind.ImageSize = new System.Drawing.Size(45, 44);
            this.btnFind.ImageZoomSize = new System.Drawing.Size(85, 84);
            this.btnFind.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnFind.InitialImage")));
            this.btnFind.Location = new System.Drawing.Point(595, 4);
            this.btnFind.Name = "btnFind";
            this.btnFind.Rotation = 0;
            this.btnFind.ShowActiveImage = true;
            this.btnFind.ShowCursorChanges = true;
            this.btnFind.ShowImageBorders = true;
            this.btnFind.ShowSizeMarkers = false;
            this.btnFind.Size = new System.Drawing.Size(85, 84);
            this.btnFind.TabIndex = 44;
            this.btnFind.TabStop = false;
            this.btnFind.ToolTipText = "Find";
            this.btnFind.WaitOnLoad = false;
            this.btnFind.Zoom = 40;
            this.btnFind.ZoomSpeed = 10;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.bunifuLabel2.Location = new System.Drawing.Point(302, 17);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(127, 26);
            this.bunifuLabel2.TabIndex = 47;
            this.bunifuLabel2.Text = "Type the value";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.bunifuLabel1.Location = new System.Drawing.Point(29, 17);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(102, 26);
            this.bunifuLabel1.TabIndex = 46;
            this.bunifuLabel1.Text = "Select Field";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // dropFields
            // 
            this.dropFields.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dropFields.BorderRadius = 3;
            this.dropFields.DisabledColor = System.Drawing.Color.Gray;
            this.dropFields.Font = new System.Drawing.Font("Segoe UI Semibold", 14F);
            this.dropFields.ForeColor = System.Drawing.Color.Black;
            this.dropFields.items = new string[] {
        "ID",
        "Room ID",
        "Date"};
            this.dropFields.Location = new System.Drawing.Point(29, 50);
            this.dropFields.Margin = new System.Windows.Forms.Padding(7);
            this.dropFields.Name = "dropFields";
            this.dropFields.NomalColor = System.Drawing.Color.White;
            this.dropFields.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dropFields.selectedIndex = -1;
            this.dropFields.Size = new System.Drawing.Size(263, 32);
            this.dropFields.TabIndex = 42;
            // 
            // txtValue
            // 
            this.txtValue.AcceptsReturn = false;
            this.txtValue.AcceptsTab = false;
            this.txtValue.AnimationSpeed = 200;
            this.txtValue.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtValue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtValue.BackColor = System.Drawing.Color.Transparent;
            this.txtValue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtValue.BackgroundImage")));
            this.txtValue.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtValue.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtValue.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtValue.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtValue.BorderRadius = 1;
            this.txtValue.BorderThickness = 1;
            this.txtValue.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtValue.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 14F);
            this.txtValue.DefaultText = "";
            this.txtValue.FillColor = System.Drawing.Color.White;
            this.txtValue.HideSelection = true;
            this.txtValue.IconLeft = null;
            this.txtValue.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtValue.IconPadding = 10;
            this.txtValue.IconRight = null;
            this.txtValue.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtValue.Lines = new string[0];
            this.txtValue.Location = new System.Drawing.Point(302, 47);
            this.txtValue.MaxLength = 32767;
            this.txtValue.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtValue.Modified = false;
            this.txtValue.Multiline = false;
            this.txtValue.Name = "txtValue";
            stateProperties9.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtValue.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.Empty;
            stateProperties10.FillColor = System.Drawing.Color.White;
            stateProperties10.ForeColor = System.Drawing.Color.Empty;
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtValue.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtValue.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Silver;
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.Empty;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtValue.OnIdleState = stateProperties12;
            this.txtValue.PasswordChar = '\0';
            this.txtValue.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtValue.PlaceholderText = "Enter text";
            this.txtValue.ReadOnly = false;
            this.txtValue.SelectedText = "";
            this.txtValue.SelectionLength = 0;
            this.txtValue.SelectionStart = 0;
            this.txtValue.ShortcutsEnabled = true;
            this.txtValue.Size = new System.Drawing.Size(259, 35);
            this.txtValue.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtValue.TabIndex = 43;
            this.txtValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtValue.TextMarginBottom = 0;
            this.txtValue.TextMarginLeft = 5;
            this.txtValue.TextMarginTop = 0;
            this.txtValue.TextPlaceholder = "Enter text";
            this.txtValue.UseSystemPasswordChar = false;
            this.txtValue.WordWrap = true;
            // 
            // dataGrid1
            // 
            this.dataGrid1.AllowCustomTheming = false;
            this.dataGrid1.AllowUserToAddRows = false;
            this.dataGrid1.AllowUserToDeleteRows = false;
            this.dataGrid1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.dataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGrid1.ColumnHeadersHeight = 40;
            this.dataGrid1.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dataGrid1.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGrid1.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGrid1.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGrid1.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGrid1.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dataGrid1.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGrid1.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dataGrid1.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dataGrid1.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGrid1.CurrentTheme.Name = null;
            this.dataGrid1.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGrid1.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGrid1.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGrid1.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGrid1.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid1.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGrid1.EnableHeadersVisualStyles = false;
            this.dataGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGrid1.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dataGrid1.HeaderBgColor = System.Drawing.Color.Empty;
            this.dataGrid1.HeaderForeColor = System.Drawing.Color.White;
            this.dataGrid1.Location = new System.Drawing.Point(12, 101);
            this.dataGrid1.MultiSelect = false;
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.ReadOnly = true;
            this.dataGrid1.RowHeadersVisible = false;
            this.dataGrid1.RowTemplate.Height = 40;
            this.dataGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid1.Size = new System.Drawing.Size(668, 433);
            this.dataGrid1.TabIndex = 45;
            this.dataGrid1.TabStop = false;
            this.dataGrid1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // UserHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(692, 539);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.dropFields);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.dataGrid1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserHistory";
            this.Text = "UserHistory";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private Bunifu.UI.WinForms.BunifuImageButton btnFind;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.Framework.UI.BunifuDropdown dropFields;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtValue;
        private Bunifu.UI.WinForms.BunifuDataGridView dataGrid1;
    }
}