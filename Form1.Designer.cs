
namespace BinaryRelations
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelTextBoxes = new System.Windows.Forms.Panel();
            this.oblTxt = new System.Windows.Forms.RichTextBox();
            this.inputTxt = new System.Windows.Forms.RichTextBox();
            this.analyzeBtn = new System.Windows.Forms.Button();
            this.inputLabel = new System.Windows.Forms.Label();
            this.matrixDgv = new System.Windows.Forms.DataGridView();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.ArefLbl = new System.Windows.Forms.Label();
            this.SymLbl = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.AsymLbl = new System.Windows.Forms.Label();
            this.RefLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.AntisLbl = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.TrLbl = new System.Windows.Forms.Label();
            this.panelBv = new System.Windows.Forms.Panel();
            this.panelDgv = new System.Windows.Forms.Panel();
            this.squareDgv = new System.Windows.Forms.DataGridView();
            this.panelVlast = new System.Windows.Forms.Panel();
            this.vlastLbl = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelTextBoxes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matrixDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panelBv.SuspendLayout();
            this.panelDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.squareDgv)).BeginInit();
            this.panelVlast.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTextBoxes
            // 
            this.panelTextBoxes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTextBoxes.BackColor = System.Drawing.Color.White;
            this.panelTextBoxes.Controls.Add(this.oblTxt);
            this.panelTextBoxes.Controls.Add(this.inputTxt);
            this.panelTextBoxes.Location = new System.Drawing.Point(5, 30);
            this.panelTextBoxes.Name = "panelTextBoxes";
            this.panelTextBoxes.Size = new System.Drawing.Size(726, 159);
            this.panelTextBoxes.TabIndex = 0;
            // 
            // oblTxt
            // 
            this.oblTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oblTxt.BackColor = System.Drawing.Color.White;
            this.oblTxt.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oblTxt.Location = new System.Drawing.Point(0, 69);
            this.oblTxt.Name = "oblTxt";
            this.oblTxt.ReadOnly = true;
            this.oblTxt.Size = new System.Drawing.Size(723, 90);
            this.oblTxt.TabIndex = 22;
            this.oblTxt.Text = "";
            // 
            // inputTxt
            // 
            this.inputTxt.BackColor = System.Drawing.Color.White;
            this.inputTxt.Dock = System.Windows.Forms.DockStyle.Top;
            this.inputTxt.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputTxt.Location = new System.Drawing.Point(0, 0);
            this.inputTxt.Name = "inputTxt";
            this.inputTxt.Size = new System.Drawing.Size(726, 70);
            this.inputTxt.TabIndex = 23;
            this.inputTxt.Text = "R = (1 2) (3 1) (1 4) (2 1)";
            this.inputTxt.TextChanged += new System.EventHandler(this.RefLbl_MouseLeave);
            // 
            // analyzeBtn
            // 
            this.analyzeBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.analyzeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(224)))), ((int)(((byte)(252)))));
            this.analyzeBtn.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.analyzeBtn.Location = new System.Drawing.Point(112, 540);
            this.analyzeBtn.Name = "analyzeBtn";
            this.analyzeBtn.Size = new System.Drawing.Size(124, 30);
            this.analyzeBtn.TabIndex = 21;
            this.analyzeBtn.Text = "Анализ";
            this.analyzeBtn.UseVisualStyleBackColor = false;
            this.analyzeBtn.Click += new System.EventHandler(this.analyzeBtn_Click);
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.BackColor = System.Drawing.Color.Transparent;
            this.inputLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.inputLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputLabel.Location = new System.Drawing.Point(0, 0);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(346, 27);
            this.inputLabel.TabIndex = 20;
            this.inputLabel.Text = "Введите бинарное отношение R:";
            // 
            // matrixDgv
            // 
            this.matrixDgv.AllowUserToAddRows = false;
            this.matrixDgv.AllowUserToDeleteRows = false;
            this.matrixDgv.AllowUserToResizeColumns = false;
            this.matrixDgv.AllowUserToResizeRows = false;
            this.matrixDgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matrixDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.matrixDgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.matrixDgv.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.matrixDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrixDgv.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.matrixDgv.DefaultCellStyle = dataGridViewCellStyle1;
            this.matrixDgv.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.matrixDgv.Location = new System.Drawing.Point(22, 44);
            this.matrixDgv.Name = "matrixDgv";
            this.matrixDgv.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.matrixDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.matrixDgv.RowHeadersVisible = false;
            this.matrixDgv.RowHeadersWidth = 50;
            this.matrixDgv.RowTemplate.Height = 24;
            this.matrixDgv.Size = new System.Drawing.Size(326, 303);
            this.matrixDgv.TabIndex = 43;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(267, 295);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(25, 23);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 42;
            this.pictureBox6.TabStop = false;
            // 
            // ArefLbl
            // 
            this.ArefLbl.AutoSize = true;
            this.ArefLbl.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ArefLbl.Location = new System.Drawing.Point(25, 122);
            this.ArefLbl.Name = "ArefLbl";
            this.ArefLbl.Size = new System.Drawing.Size(213, 25);
            this.ArefLbl.TabIndex = 32;
            this.ArefLbl.Text = "Антирефлексивность";
            this.ArefLbl.MouseHover += new System.EventHandler(this.ArefLbl_MouseHover);
            // 
            // SymLbl
            // 
            this.SymLbl.AutoSize = true;
            this.SymLbl.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SymLbl.Location = new System.Drawing.Point(25, 165);
            this.SymLbl.Name = "SymLbl";
            this.SymLbl.Size = new System.Drawing.Size(175, 25);
            this.SymLbl.TabIndex = 33;
            this.SymLbl.Text = "Симметричность";
            this.SymLbl.MouseHover += new System.EventHandler(this.SymLbl_MouseHover);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(267, 121);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(267, 164);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 23);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 39;
            this.pictureBox3.TabStop = false;
            // 
            // AsymLbl
            // 
            this.AsymLbl.AutoSize = true;
            this.AsymLbl.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AsymLbl.Location = new System.Drawing.Point(26, 250);
            this.AsymLbl.Name = "AsymLbl";
            this.AsymLbl.Size = new System.Drawing.Size(185, 25);
            this.AsymLbl.TabIndex = 35;
            this.AsymLbl.Text = "Асимметричность";
            this.AsymLbl.MouseHover += new System.EventHandler(this.AsymLbl_MouseHover);
            // 
            // RefLbl
            // 
            this.RefLbl.AutoSize = true;
            this.RefLbl.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RefLbl.Location = new System.Drawing.Point(25, 76);
            this.RefLbl.Name = "RefLbl";
            this.RefLbl.Size = new System.Drawing.Size(164, 25);
            this.RefLbl.TabIndex = 31;
            this.RefLbl.Text = "Рефлексивность";
            this.RefLbl.MouseLeave += new System.EventHandler(this.RefLbl_MouseLeave);
            this.RefLbl.MouseHover += new System.EventHandler(this.RefLbl_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(267, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(267, 208);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 23);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 40;
            this.pictureBox4.TabStop = false;
            // 
            // AntisLbl
            // 
            this.AntisLbl.AutoSize = true;
            this.AntisLbl.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AntisLbl.Location = new System.Drawing.Point(25, 208);
            this.AntisLbl.Name = "AntisLbl";
            this.AntisLbl.Size = new System.Drawing.Size(220, 25);
            this.AntisLbl.TabIndex = 34;
            this.AntisLbl.Text = "Антисимметричность";
            this.AntisLbl.MouseHover += new System.EventHandler(this.AntisLbl_MouseHover);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(267, 250);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(25, 23);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 41;
            this.pictureBox5.TabStop = false;
            // 
            // TrLbl
            // 
            this.TrLbl.AutoSize = true;
            this.TrLbl.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TrLbl.Location = new System.Drawing.Point(26, 293);
            this.TrLbl.Name = "TrLbl";
            this.TrLbl.Size = new System.Drawing.Size(165, 25);
            this.TrLbl.TabIndex = 36;
            this.TrLbl.Text = "Транзитивность";
            this.TrLbl.MouseHover += new System.EventHandler(this.TrLbl_MouseHover);
            // 
            // panelBv
            // 
            this.panelBv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBv.Controls.Add(this.inputLabel);
            this.panelBv.Controls.Add(this.panelTextBoxes);
            this.panelBv.Location = new System.Drawing.Point(0, 2);
            this.panelBv.Name = "panelBv";
            this.panelBv.Size = new System.Drawing.Size(742, 189);
            this.panelBv.TabIndex = 2;
            // 
            // panelDgv
            // 
            this.panelDgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDgv.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelDgv.Controls.Add(this.label2);
            this.panelDgv.Controls.Add(this.label1);
            this.panelDgv.Controls.Add(this.matrixDgv);
            this.panelDgv.Controls.Add(this.squareDgv);
            this.panelDgv.Location = new System.Drawing.Point(3, 190);
            this.panelDgv.Name = "panelDgv";
            this.panelDgv.Size = new System.Drawing.Size(739, 414);
            this.panelDgv.TabIndex = 3;
            // 
            // squareDgv
            // 
            this.squareDgv.AllowUserToAddRows = false;
            this.squareDgv.AllowUserToDeleteRows = false;
            this.squareDgv.AllowUserToResizeColumns = false;
            this.squareDgv.AllowUserToResizeRows = false;
            this.squareDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.squareDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.squareDgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.squareDgv.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.squareDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.squareDgv.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.squareDgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.squareDgv.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.squareDgv.Location = new System.Drawing.Point(383, 44);
            this.squareDgv.Name = "squareDgv";
            this.squareDgv.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.squareDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.squareDgv.RowHeadersVisible = false;
            this.squareDgv.RowHeadersWidth = 50;
            this.squareDgv.RowTemplate.Height = 24;
            this.squareDgv.Size = new System.Drawing.Size(326, 303);
            this.squareDgv.TabIndex = 44;
            // 
            // panelVlast
            // 
            this.panelVlast.BackColor = System.Drawing.Color.White;
            this.panelVlast.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelVlast.Controls.Add(this.vlastLbl);
            this.panelVlast.Controls.Add(this.analyzeBtn);
            this.panelVlast.Controls.Add(this.RefLbl);
            this.panelVlast.Controls.Add(this.AntisLbl);
            this.panelVlast.Controls.Add(this.AsymLbl);
            this.panelVlast.Controls.Add(this.ArefLbl);
            this.panelVlast.Controls.Add(this.pictureBox3);
            this.panelVlast.Controls.Add(this.pictureBox5);
            this.panelVlast.Controls.Add(this.pictureBox2);
            this.panelVlast.Controls.Add(this.pictureBox4);
            this.panelVlast.Controls.Add(this.pictureBox6);
            this.panelVlast.Controls.Add(this.SymLbl);
            this.panelVlast.Controls.Add(this.pictureBox1);
            this.panelVlast.Controls.Add(this.TrLbl);
            this.panelVlast.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelVlast.Location = new System.Drawing.Point(746, 0);
            this.panelVlast.Name = "panelVlast";
            this.panelVlast.Size = new System.Drawing.Size(329, 593);
            this.panelVlast.TabIndex = 4;
            // 
            // vlastLbl
            // 
            this.vlastLbl.AutoSize = true;
            this.vlastLbl.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vlastLbl.Location = new System.Drawing.Point(76, 31);
            this.vlastLbl.Name = "vlastLbl";
            this.vlastLbl.Size = new System.Drawing.Size(135, 25);
            this.vlastLbl.TabIndex = 43;
            this.vlastLbl.Text = "Свойства БО";
            // 
            // panelLeft
            // 
            this.panelLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLeft.Controls.Add(this.panelDgv);
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(742, 607);
            this.panelLeft.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(102, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 45;
            this.label1.Text = "Матрица БО B:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(409, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 25);
            this.label2.TabIndex = 46;
            this.label2.Text = "Матрица-квадрат K = В*В:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1075, 593);
            this.Controls.Add(this.panelVlast);
            this.Controls.Add(this.panelBv);
            this.Controls.Add(this.panelLeft);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1030, 610);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelTextBoxes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.matrixDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panelBv.ResumeLayout(false);
            this.panelBv.PerformLayout();
            this.panelDgv.ResumeLayout(false);
            this.panelDgv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.squareDgv)).EndInit();
            this.panelVlast.ResumeLayout(false);
            this.panelVlast.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTextBoxes;
        private System.Windows.Forms.Button analyzeBtn;
        private System.Windows.Forms.RichTextBox oblTxt;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.RichTextBox inputTxt;
        private System.Windows.Forms.DataGridView matrixDgv;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label ArefLbl;
        private System.Windows.Forms.Label SymLbl;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label AsymLbl;
        private System.Windows.Forms.Label RefLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label AntisLbl;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label TrLbl;
        private System.Windows.Forms.Panel panelBv;
        private System.Windows.Forms.Panel panelDgv;
        private System.Windows.Forms.Panel panelVlast;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label vlastLbl;
        public System.Windows.Forms.DataGridView squareDgv;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

