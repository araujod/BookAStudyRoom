﻿namespace BookStudyRoom
{
    partial class ShowHistory
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowHistory));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties15 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties16 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label10 = new System.Windows.Forms.Label();
            this.btnFind = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.dropFields = new Bunifu.Framework.UI.BunifuDropdown();
            this.txtValue = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.dataGrid1 = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datebookedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timestartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membersqttDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookedRoomtableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roombookingDataSet = new BookStudyRoom.roombookingDataSet();
            this.bookedRoom_tableTableAdapter = new BookStudyRoom.roombookingDataSetTableAdapters.BookedRoom_tableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookedRoomtableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roombookingDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(618, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 20);
            this.label10.TabIndex = 41;
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
            this.btnFind.Location = new System.Drawing.Point(595, 8);
            this.btnFind.Name = "btnFind";
            this.btnFind.Rotation = 0;
            this.btnFind.ShowActiveImage = true;
            this.btnFind.ShowCursorChanges = true;
            this.btnFind.ShowImageBorders = true;
            this.btnFind.ShowSizeMarkers = false;
            this.btnFind.Size = new System.Drawing.Size(85, 84);
            this.btnFind.TabIndex = 3;
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
            this.bunifuLabel2.Location = new System.Drawing.Point(302, 21);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(127, 26);
            this.bunifuLabel2.TabIndex = 40;
            this.bunifuLabel2.Text = "Type the value";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.bunifuLabel1.Location = new System.Drawing.Point(29, 21);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(102, 26);
            this.bunifuLabel1.TabIndex = 39;
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
        "User ID",
        "Room ID",
        "Date"};
            this.dropFields.Location = new System.Drawing.Point(29, 54);
            this.dropFields.Margin = new System.Windows.Forms.Padding(7);
            this.dropFields.Name = "dropFields";
            this.dropFields.NomalColor = System.Drawing.Color.White;
            this.dropFields.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dropFields.selectedIndex = -1;
            this.dropFields.Size = new System.Drawing.Size(263, 32);
            this.dropFields.TabIndex = 0;
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
            this.txtValue.Location = new System.Drawing.Point(302, 51);
            this.txtValue.MaxLength = 32767;
            this.txtValue.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtValue.Modified = false;
            this.txtValue.Multiline = false;
            this.txtValue.Name = "txtValue";
            stateProperties13.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties13.FillColor = System.Drawing.Color.Empty;
            stateProperties13.ForeColor = System.Drawing.Color.Empty;
            stateProperties13.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtValue.OnActiveState = stateProperties13;
            stateProperties14.BorderColor = System.Drawing.Color.Empty;
            stateProperties14.FillColor = System.Drawing.Color.White;
            stateProperties14.ForeColor = System.Drawing.Color.Empty;
            stateProperties14.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtValue.OnDisabledState = stateProperties14;
            stateProperties15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties15.FillColor = System.Drawing.Color.Empty;
            stateProperties15.ForeColor = System.Drawing.Color.Empty;
            stateProperties15.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtValue.OnHoverState = stateProperties15;
            stateProperties16.BorderColor = System.Drawing.Color.Silver;
            stateProperties16.FillColor = System.Drawing.Color.White;
            stateProperties16.ForeColor = System.Drawing.Color.Empty;
            stateProperties16.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtValue.OnIdleState = stateProperties16;
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
            this.txtValue.TabIndex = 2;
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
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.dataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGrid1.AutoGenerateColumns = false;
            this.dataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGrid1.ColumnHeadersHeight = 40;
            this.dataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.useridDataGridViewTextBoxColumn,
            this.roomidDataGridViewTextBoxColumn,
            this.datebookedDataGridViewTextBoxColumn,
            this.timestartDataGridViewTextBoxColumn,
            this.timeendDataGridViewTextBoxColumn,
            this.membersqttDataGridViewTextBoxColumn});
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
            this.dataGrid1.DataSource = this.bookedRoomtableBindingSource;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid1.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGrid1.EnableHeadersVisualStyles = false;
            this.dataGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGrid1.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dataGrid1.HeaderBgColor = System.Drawing.Color.Empty;
            this.dataGrid1.HeaderForeColor = System.Drawing.Color.White;
            this.dataGrid1.Location = new System.Drawing.Point(12, 105);
            this.dataGrid1.MultiSelect = false;
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.ReadOnly = true;
            this.dataGrid1.RowHeadersVisible = false;
            this.dataGrid1.RowTemplate.Height = 40;
            this.dataGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid1.Size = new System.Drawing.Size(668, 433);
            this.dataGrid1.TabIndex = 4;
            this.dataGrid1.TabStop = false;
            this.dataGrid1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.FillWeight = 50F;
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "user_id";
            this.useridDataGridViewTextBoxColumn.HeaderText = "User ID";
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            this.useridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomidDataGridViewTextBoxColumn
            // 
            this.roomidDataGridViewTextBoxColumn.DataPropertyName = "room_id";
            this.roomidDataGridViewTextBoxColumn.HeaderText = "Room ID";
            this.roomidDataGridViewTextBoxColumn.Name = "roomidDataGridViewTextBoxColumn";
            this.roomidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datebookedDataGridViewTextBoxColumn
            // 
            this.datebookedDataGridViewTextBoxColumn.DataPropertyName = "date_booked";
            this.datebookedDataGridViewTextBoxColumn.HeaderText = "Date";
            this.datebookedDataGridViewTextBoxColumn.Name = "datebookedDataGridViewTextBoxColumn";
            this.datebookedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timestartDataGridViewTextBoxColumn
            // 
            this.timestartDataGridViewTextBoxColumn.DataPropertyName = "time_start";
            this.timestartDataGridViewTextBoxColumn.HeaderText = "Time Start";
            this.timestartDataGridViewTextBoxColumn.Name = "timestartDataGridViewTextBoxColumn";
            this.timestartDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeendDataGridViewTextBoxColumn
            // 
            this.timeendDataGridViewTextBoxColumn.DataPropertyName = "time_end";
            this.timeendDataGridViewTextBoxColumn.HeaderText = "Time End";
            this.timeendDataGridViewTextBoxColumn.Name = "timeendDataGridViewTextBoxColumn";
            this.timeendDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // membersqttDataGridViewTextBoxColumn
            // 
            this.membersqttDataGridViewTextBoxColumn.DataPropertyName = "members_qtt";
            this.membersqttDataGridViewTextBoxColumn.HeaderText = "Members";
            this.membersqttDataGridViewTextBoxColumn.Name = "membersqttDataGridViewTextBoxColumn";
            this.membersqttDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookedRoomtableBindingSource
            // 
            this.bookedRoomtableBindingSource.DataMember = "BookedRoom_table";
            this.bookedRoomtableBindingSource.DataSource = this.roombookingDataSet;
            // 
            // roombookingDataSet
            // 
            this.roombookingDataSet.DataSetName = "roombookingDataSet";
            this.roombookingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookedRoom_tableTableAdapter
            // 
            this.bookedRoom_tableTableAdapter.ClearBeforeFill = true;
            // 
            // ShowHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 539);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.dropFields);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.dataGrid1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowHistory";
            this.Text = "ShowHistory";
            this.Load += new System.EventHandler(this.ShowHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookedRoomtableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roombookingDataSet)).EndInit();
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
        private roombookingDataSet roombookingDataSet;
        private System.Windows.Forms.BindingSource bookedRoomtableBindingSource;
        private roombookingDataSetTableAdapters.BookedRoom_tableTableAdapter bookedRoom_tableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datebookedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timestartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn membersqttDataGridViewTextBoxColumn;
    }
}