namespace Eassistant.Modules
{
    partial class Index
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
            this.components = new System.ComponentModel.Container();
            this.buttonGrammarExercises = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.tableLayoutPanelDateTime = new System.Windows.Forms.TableLayoutPanel();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.panelIndexControls = new System.Windows.Forms.Panel();
            this.timerDateTime = new System.Windows.Forms.Timer(this.components);
            this.buttonDuolingo = new System.Windows.Forms.Button();
            this.buttonDictionary = new System.Windows.Forms.Button();
            this.buttonLingualeo = new System.Windows.Forms.Button();
            this.buttonFeedback = new System.Windows.Forms.Button();
            this.tableLayoutPanelDateTime.SuspendLayout();
            this.panelIndexControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGrammarExercises
            // 
            this.buttonGrammarExercises.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonGrammarExercises.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGrammarExercises.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGrammarExercises.ForeColor = System.Drawing.Color.White;
            this.buttonGrammarExercises.Location = new System.Drawing.Point(48, 65);
            this.buttonGrammarExercises.Name = "buttonGrammarExercises";
            this.buttonGrammarExercises.Size = new System.Drawing.Size(135, 247);
            this.buttonGrammarExercises.TabIndex = 0;
            this.buttonGrammarExercises.Text = "Упражнения по грамматике";
            this.buttonGrammarExercises.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonGrammarExercises.UseVisualStyleBackColor = false;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(2, 2);
            this.monthCalendar1.Location = new System.Drawing.Point(485, 65);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // tableLayoutPanelDateTime
            // 
            this.tableLayoutPanelDateTime.ColumnCount = 2;
            this.tableLayoutPanelDateTime.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelDateTime.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelDateTime.Controls.Add(this.labelDate, 1, 0);
            this.tableLayoutPanelDateTime.Controls.Add(this.labelTime, 0, 0);
            this.tableLayoutPanelDateTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelDateTime.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelDateTime.Name = "tableLayoutPanelDateTime";
            this.tableLayoutPanelDateTime.RowCount = 1;
            this.tableLayoutPanelDateTime.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelDateTime.Size = new System.Drawing.Size(865, 90);
            this.tableLayoutPanelDateTime.TabIndex = 2;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(3, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(426, 90);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "label1";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate.Location = new System.Drawing.Point(435, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(427, 90);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "label2";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelIndexControls
            // 
            this.panelIndexControls.Controls.Add(this.buttonFeedback);
            this.panelIndexControls.Controls.Add(this.buttonLingualeo);
            this.panelIndexControls.Controls.Add(this.buttonDictionary);
            this.panelIndexControls.Controls.Add(this.buttonDuolingo);
            this.panelIndexControls.Controls.Add(this.monthCalendar1);
            this.panelIndexControls.Controls.Add(this.buttonGrammarExercises);
            this.panelIndexControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelIndexControls.Location = new System.Drawing.Point(0, 90);
            this.panelIndexControls.Name = "panelIndexControls";
            this.panelIndexControls.Size = new System.Drawing.Size(865, 440);
            this.panelIndexControls.TabIndex = 3;
            // 
            // timerDateTime
            // 
            this.timerDateTime.Interval = 1000;
            this.timerDateTime.Tick += new System.EventHandler(this.timerDateTime_Tick);
            // 
            // buttonDuolingo
            // 
            this.buttonDuolingo.BackColor = System.Drawing.Color.Magenta;
            this.buttonDuolingo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDuolingo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDuolingo.ForeColor = System.Drawing.Color.White;
            this.buttonDuolingo.Location = new System.Drawing.Point(48, 318);
            this.buttonDuolingo.Name = "buttonDuolingo";
            this.buttonDuolingo.Size = new System.Drawing.Size(135, 58);
            this.buttonDuolingo.TabIndex = 2;
            this.buttonDuolingo.Text = "Duolingo";
            this.buttonDuolingo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDuolingo.UseVisualStyleBackColor = false;
            // 
            // buttonDictionary
            // 
            this.buttonDictionary.BackColor = System.Drawing.Color.Crimson;
            this.buttonDictionary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDictionary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDictionary.ForeColor = System.Drawing.Color.White;
            this.buttonDictionary.Location = new System.Drawing.Point(189, 65);
            this.buttonDictionary.Name = "buttonDictionary";
            this.buttonDictionary.Size = new System.Drawing.Size(284, 85);
            this.buttonDictionary.TabIndex = 3;
            this.buttonDictionary.Text = "Краткий словарь";
            this.buttonDictionary.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDictionary.UseVisualStyleBackColor = false;
            // 
            // buttonLingualeo
            // 
            this.buttonLingualeo.BackColor = System.Drawing.Color.Orange;
            this.buttonLingualeo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLingualeo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLingualeo.ForeColor = System.Drawing.Color.White;
            this.buttonLingualeo.Location = new System.Drawing.Point(189, 156);
            this.buttonLingualeo.Name = "buttonLingualeo";
            this.buttonLingualeo.Size = new System.Drawing.Size(140, 220);
            this.buttonLingualeo.TabIndex = 4;
            this.buttonLingualeo.Text = "Lingualeo";
            this.buttonLingualeo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonLingualeo.UseVisualStyleBackColor = false;
            // 
            // buttonFeedback
            // 
            this.buttonFeedback.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFeedback.ForeColor = System.Drawing.Color.White;
            this.buttonFeedback.Location = new System.Drawing.Point(332, 156);
            this.buttonFeedback.Name = "buttonFeedback";
            this.buttonFeedback.Size = new System.Drawing.Size(140, 220);
            this.buttonFeedback.TabIndex = 5;
            this.buttonFeedback.Text = "Обратная связь";
            this.buttonFeedback.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonFeedback.UseVisualStyleBackColor = false;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.Controls.Add(this.panelIndexControls);
            this.Controls.Add(this.tableLayoutPanelDateTime);
            this.Name = "Index";
            this.Size = new System.Drawing.Size(865, 530);
            this.tableLayoutPanelDateTime.ResumeLayout(false);
            this.tableLayoutPanelDateTime.PerformLayout();
            this.panelIndexControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGrammarExercises;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDateTime;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Panel panelIndexControls;
        private System.Windows.Forms.Timer timerDateTime;
        private System.Windows.Forms.Button buttonFeedback;
        private System.Windows.Forms.Button buttonLingualeo;
        private System.Windows.Forms.Button buttonDictionary;
        private System.Windows.Forms.Button buttonDuolingo;
    }
}
