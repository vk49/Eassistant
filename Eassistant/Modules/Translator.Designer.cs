namespace Eassistant.Modules
{
    partial class Translator
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Translator));
            this.tableLayoutPanelTranslatorTopMenu = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxFlagFrom = new System.Windows.Forms.PictureBox();
            this.pictureBoxFlagTo = new System.Windows.Forms.PictureBox();
            this.pictureBoxChangeLanguage = new System.Windows.Forms.PictureBox();
            this.buttonTranslate = new System.Windows.Forms.Button();
            this.splitContainerTextFields = new System.Windows.Forms.SplitContainer();
            this.richTextBoxSourceText = new System.Windows.Forms.RichTextBox();
            this.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.panelTextFields = new System.Windows.Forms.Panel();
            this.tableLayoutPanelActionButtons = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSpeak = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.tableLayoutPanelTranslatorTopMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlagFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlagTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChangeLanguage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTextFields)).BeginInit();
            this.splitContainerTextFields.Panel1.SuspendLayout();
            this.splitContainerTextFields.Panel2.SuspendLayout();
            this.splitContainerTextFields.SuspendLayout();
            this.panelTextFields.SuspendLayout();
            this.tableLayoutPanelActionButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelTranslatorTopMenu
            // 
            this.tableLayoutPanelTranslatorTopMenu.ColumnCount = 3;
            this.tableLayoutPanelTranslatorTopMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelTranslatorTopMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelTranslatorTopMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelTranslatorTopMenu.Controls.Add(this.pictureBoxFlagFrom, 0, 0);
            this.tableLayoutPanelTranslatorTopMenu.Controls.Add(this.pictureBoxFlagTo, 2, 0);
            this.tableLayoutPanelTranslatorTopMenu.Controls.Add(this.pictureBoxChangeLanguage, 1, 0);
            this.tableLayoutPanelTranslatorTopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelTranslatorTopMenu.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelTranslatorTopMenu.Name = "tableLayoutPanelTranslatorTopMenu";
            this.tableLayoutPanelTranslatorTopMenu.RowCount = 1;
            this.tableLayoutPanelTranslatorTopMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTranslatorTopMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanelTranslatorTopMenu.Size = new System.Drawing.Size(602, 60);
            this.tableLayoutPanelTranslatorTopMenu.TabIndex = 0;
            // 
            // pictureBoxFlagFrom
            // 
            this.pictureBoxFlagFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxFlagFrom.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFlagFrom.Image")));
            this.pictureBoxFlagFrom.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxFlagFrom.Name = "pictureBoxFlagFrom";
            this.pictureBoxFlagFrom.Size = new System.Drawing.Size(194, 54);
            this.pictureBoxFlagFrom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFlagFrom.TabIndex = 0;
            this.pictureBoxFlagFrom.TabStop = false;
            // 
            // pictureBoxFlagTo
            // 
            this.pictureBoxFlagTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxFlagTo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFlagTo.Image")));
            this.pictureBoxFlagTo.Location = new System.Drawing.Point(403, 3);
            this.pictureBoxFlagTo.Name = "pictureBoxFlagTo";
            this.pictureBoxFlagTo.Size = new System.Drawing.Size(196, 54);
            this.pictureBoxFlagTo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFlagTo.TabIndex = 1;
            this.pictureBoxFlagTo.TabStop = false;
            // 
            // pictureBoxChangeLanguage
            // 
            this.pictureBoxChangeLanguage.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxChangeLanguage.Image")));
            this.pictureBoxChangeLanguage.Location = new System.Drawing.Point(203, 3);
            this.pictureBoxChangeLanguage.Name = "pictureBoxChangeLanguage";
            this.pictureBoxChangeLanguage.Size = new System.Drawing.Size(194, 54);
            this.pictureBoxChangeLanguage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxChangeLanguage.TabIndex = 2;
            this.pictureBoxChangeLanguage.TabStop = false;
            this.pictureBoxChangeLanguage.Click += new System.EventHandler(this.pictureBoxChangeLanguage_Click);
            // 
            // buttonTranslate
            // 
            this.buttonTranslate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonTranslate.Location = new System.Drawing.Point(81, 342);
            this.buttonTranslate.Name = "buttonTranslate";
            this.buttonTranslate.Size = new System.Drawing.Size(521, 23);
            this.buttonTranslate.TabIndex = 1;
            this.buttonTranslate.Text = "Перевести";
            this.buttonTranslate.UseVisualStyleBackColor = true;
            // 
            // splitContainerTextFields
            // 
            this.splitContainerTextFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerTextFields.Location = new System.Drawing.Point(0, 0);
            this.splitContainerTextFields.Name = "splitContainerTextFields";
            this.splitContainerTextFields.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerTextFields.Panel1
            // 
            this.splitContainerTextFields.Panel1.Controls.Add(this.richTextBoxSourceText);
            // 
            // splitContainerTextFields.Panel2
            // 
            this.splitContainerTextFields.Panel2.Controls.Add(this.richTextBoxOutput);
            this.splitContainerTextFields.Size = new System.Drawing.Size(521, 282);
            this.splitContainerTextFields.SplitterDistance = 153;
            this.splitContainerTextFields.TabIndex = 2;
            // 
            // richTextBoxSourceText
            // 
            this.richTextBoxSourceText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxSourceText.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxSourceText.Name = "richTextBoxSourceText";
            this.richTextBoxSourceText.Size = new System.Drawing.Size(521, 153);
            this.richTextBoxSourceText.TabIndex = 0;
            this.richTextBoxSourceText.Text = "";
            // 
            // richTextBoxOutput
            // 
            this.richTextBoxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxOutput.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxOutput.Name = "richTextBoxOutput";
            this.richTextBoxOutput.ReadOnly = true;
            this.richTextBoxOutput.Size = new System.Drawing.Size(521, 125);
            this.richTextBoxOutput.TabIndex = 0;
            this.richTextBoxOutput.Text = "";
            // 
            // panelTextFields
            // 
            this.panelTextFields.Controls.Add(this.splitContainerTextFields);
            this.panelTextFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTextFields.Location = new System.Drawing.Point(81, 60);
            this.panelTextFields.Name = "panelTextFields";
            this.panelTextFields.Size = new System.Drawing.Size(521, 282);
            this.panelTextFields.TabIndex = 4;
            // 
            // tableLayoutPanelActionButtons
            // 
            this.tableLayoutPanelActionButtons.ColumnCount = 1;
            this.tableLayoutPanelActionButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelActionButtons.Controls.Add(this.buttonClear, 0, 1);
            this.tableLayoutPanelActionButtons.Controls.Add(this.buttonSpeak, 0, 0);
            this.tableLayoutPanelActionButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanelActionButtons.Location = new System.Drawing.Point(0, 60);
            this.tableLayoutPanelActionButtons.Name = "tableLayoutPanelActionButtons";
            this.tableLayoutPanelActionButtons.RowCount = 2;
            this.tableLayoutPanelActionButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelActionButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelActionButtons.Size = new System.Drawing.Size(81, 305);
            this.tableLayoutPanelActionButtons.TabIndex = 5;
            // 
            // buttonSpeak
            // 
            this.buttonSpeak.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSpeak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSpeak.Image = ((System.Drawing.Image)(resources.GetObject("buttonSpeak.Image")));
            this.buttonSpeak.Location = new System.Drawing.Point(3, 3);
            this.buttonSpeak.Name = "buttonSpeak";
            this.buttonSpeak.Size = new System.Drawing.Size(75, 146);
            this.buttonSpeak.TabIndex = 0;
            this.buttonSpeak.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            this.buttonClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Image = ((System.Drawing.Image)(resources.GetObject("buttonClear.Image")));
            this.buttonClear.Location = new System.Drawing.Point(3, 155);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 147);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // Translator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.Controls.Add(this.panelTextFields);
            this.Controls.Add(this.buttonTranslate);
            this.Controls.Add(this.tableLayoutPanelActionButtons);
            this.Controls.Add(this.tableLayoutPanelTranslatorTopMenu);
            this.Name = "Translator";
            this.Size = new System.Drawing.Size(602, 365);
            this.tableLayoutPanelTranslatorTopMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlagFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlagTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChangeLanguage)).EndInit();
            this.splitContainerTextFields.Panel1.ResumeLayout(false);
            this.splitContainerTextFields.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTextFields)).EndInit();
            this.splitContainerTextFields.ResumeLayout(false);
            this.panelTextFields.ResumeLayout(false);
            this.tableLayoutPanelActionButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTranslatorTopMenu;
        private System.Windows.Forms.PictureBox pictureBoxFlagFrom;
        private System.Windows.Forms.PictureBox pictureBoxFlagTo;
        private System.Windows.Forms.PictureBox pictureBoxChangeLanguage;
        private System.Windows.Forms.Button buttonTranslate;
        private System.Windows.Forms.SplitContainer splitContainerTextFields;
        private System.Windows.Forms.RichTextBox richTextBoxSourceText;
        private System.Windows.Forms.RichTextBox richTextBoxOutput;
        private System.Windows.Forms.Panel panelTextFields;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelActionButtons;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSpeak;
    }
}
