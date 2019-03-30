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
            this.tableLayoutPanelLeftButtons = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelRightButtons = new System.Windows.Forms.TableLayoutPanel();
            this.panelMainMenu = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // tableLayoutPanelLeftButtons
            // 
            this.tableLayoutPanelLeftButtons.ColumnCount = 1;
            this.tableLayoutPanelLeftButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelLeftButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
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
            // tableLayoutPanelRightButtons
            // 
            this.tableLayoutPanelRightButtons.ColumnCount = 1;
            this.tableLayoutPanelRightButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelRightButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
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
            // panelMainMenu
            // 
            this.panelMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainMenu.Location = new System.Drawing.Point(100, 0);
            this.panelMainMenu.Name = "panelMainMenu";
            this.panelMainMenu.Size = new System.Drawing.Size(870, 535);
            this.panelMainMenu.TabIndex = 2;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLeftButtons;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRightButtons;
        private System.Windows.Forms.Panel panelMainMenu;
    }
}

