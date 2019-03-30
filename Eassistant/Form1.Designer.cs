namespace Eassistant
{
    partial class MainMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.tableLayoutPanelLeftButtons = new System.Windows.Forms.TableLayoutPanel();
            this.buttonTranslator = new System.Windows.Forms.Button();
            this.buttonHomePage = new System.Windows.Forms.Button();
            this.buttonTextEditor = new System.Windows.Forms.Button();
            this.tableLayoutPanelRightButtons = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.panelMainMenu = new System.Windows.Forms.Panel();
            this.buttonSpellChecker = new System.Windows.Forms.Button();
            this.buttonVoiceRecorder = new System.Windows.Forms.Button();
            this.tableLayoutPanelLeftButtons.SuspendLayout();
            this.tableLayoutPanelRightButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelLeftButtons
            // 
            this.tableLayoutPanelLeftButtons.ColumnCount = 1;
            this.tableLayoutPanelLeftButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelLeftButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelLeftButtons.Controls.Add(this.buttonTranslator, 0, 2);
            this.tableLayoutPanelLeftButtons.Controls.Add(this.buttonHomePage, 0, 0);
            this.tableLayoutPanelLeftButtons.Controls.Add(this.buttonTextEditor, 0, 1);
            this.tableLayoutPanelLeftButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanelLeftButtons.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelLeftButtons.Name = "tableLayoutPanelLeftButtons";
            this.tableLayoutPanelLeftButtons.RowCount = 3;
            this.tableLayoutPanelLeftButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelLeftButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelLeftButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelLeftButtons.Size = new System.Drawing.Size(100, 535);
            this.tableLayoutPanelLeftButtons.TabIndex = 0;
            // 
            // buttonTranslator
            // 
            this.buttonTranslator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonTranslator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTranslator.Image = ((System.Drawing.Image)(resources.GetObject("buttonTranslator.Image")));
            this.buttonTranslator.Location = new System.Drawing.Point(3, 359);
            this.buttonTranslator.Name = "buttonTranslator";
            this.buttonTranslator.Size = new System.Drawing.Size(94, 173);
            this.buttonTranslator.TabIndex = 0;
            this.buttonTranslator.UseVisualStyleBackColor = true;
            // 
            // buttonHomePage
            // 
            this.buttonHomePage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonHomePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHomePage.Image = ((System.Drawing.Image)(resources.GetObject("buttonHomePage.Image")));
            this.buttonHomePage.Location = new System.Drawing.Point(3, 3);
            this.buttonHomePage.Name = "buttonHomePage";
            this.buttonHomePage.Size = new System.Drawing.Size(94, 172);
            this.buttonHomePage.TabIndex = 1;
            this.buttonHomePage.UseVisualStyleBackColor = true;
            // 
            // buttonTextEditor
            // 
            this.buttonTextEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonTextEditor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTextEditor.Image = ((System.Drawing.Image)(resources.GetObject("buttonTextEditor.Image")));
            this.buttonTextEditor.Location = new System.Drawing.Point(3, 181);
            this.buttonTextEditor.Name = "buttonTextEditor";
            this.buttonTextEditor.Size = new System.Drawing.Size(94, 172);
            this.buttonTextEditor.TabIndex = 2;
            this.buttonTextEditor.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelRightButtons
            // 
            this.tableLayoutPanelRightButtons.ColumnCount = 1;
            this.tableLayoutPanelRightButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelRightButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelRightButtons.Controls.Add(this.buttonVoiceRecorder, 0, 2);
            this.tableLayoutPanelRightButtons.Controls.Add(this.buttonAbout, 0, 0);
            this.tableLayoutPanelRightButtons.Controls.Add(this.buttonSpellChecker, 0, 1);
            this.tableLayoutPanelRightButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanelRightButtons.Location = new System.Drawing.Point(970, 0);
            this.tableLayoutPanelRightButtons.Name = "tableLayoutPanelRightButtons";
            this.tableLayoutPanelRightButtons.RowCount = 3;
            this.tableLayoutPanelRightButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelRightButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelRightButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelRightButtons.Size = new System.Drawing.Size(100, 535);
            this.tableLayoutPanelRightButtons.TabIndex = 1;
            // 
            // buttonAbout
            // 
            this.buttonAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbout.Image = ((System.Drawing.Image)(resources.GetObject("buttonAbout.Image")));
            this.buttonAbout.Location = new System.Drawing.Point(3, 3);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(94, 172);
            this.buttonAbout.TabIndex = 0;
            this.buttonAbout.UseVisualStyleBackColor = true;
            // 
            // panelMainMenu
            // 
            this.panelMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainMenu.Location = new System.Drawing.Point(100, 0);
            this.panelMainMenu.Name = "panelMainMenu";
            this.panelMainMenu.Size = new System.Drawing.Size(870, 535);
            this.panelMainMenu.TabIndex = 2;
            // 
            // buttonSpellChecker
            // 
            this.buttonSpellChecker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSpellChecker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSpellChecker.Image = ((System.Drawing.Image)(resources.GetObject("buttonSpellChecker.Image")));
            this.buttonSpellChecker.Location = new System.Drawing.Point(3, 181);
            this.buttonSpellChecker.Name = "buttonSpellChecker";
            this.buttonSpellChecker.Size = new System.Drawing.Size(94, 172);
            this.buttonSpellChecker.TabIndex = 1;
            this.buttonSpellChecker.UseVisualStyleBackColor = true;
            // 
            // buttonVoiceRecorder
            // 
            this.buttonVoiceRecorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonVoiceRecorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVoiceRecorder.Image = ((System.Drawing.Image)(resources.GetObject("buttonVoiceRecorder.Image")));
            this.buttonVoiceRecorder.Location = new System.Drawing.Point(3, 359);
            this.buttonVoiceRecorder.Name = "buttonVoiceRecorder";
            this.buttonVoiceRecorder.Size = new System.Drawing.Size(94, 173);
            this.buttonVoiceRecorder.TabIndex = 2;
            this.buttonVoiceRecorder.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1070, 535);
            this.Controls.Add(this.panelMainMenu);
            this.Controls.Add(this.tableLayoutPanelRightButtons);
            this.Controls.Add(this.tableLayoutPanelLeftButtons);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.tableLayoutPanelLeftButtons.ResumeLayout(false);
            this.tableLayoutPanelRightButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLeftButtons;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRightButtons;
        private System.Windows.Forms.Panel panelMainMenu;
        private System.Windows.Forms.Button buttonTranslator;
        private System.Windows.Forms.Button buttonHomePage;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonTextEditor;
        private System.Windows.Forms.Button buttonSpellChecker;
        private System.Windows.Forms.Button buttonVoiceRecorder;
    }
}

