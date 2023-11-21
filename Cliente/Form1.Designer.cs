namespace Cliente
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            comoFuncionaElProgramaToolStripMenuItem = new ToolStripMenuItem();
            button3 = new Button();
            button4 = new Button();
            Invitar = new Button();
            menuStrip1 = new MenuStrip();
            listaConectados = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(367, 125);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(142, 31);
            button1.TabIndex = 0;
            button1.Text = "Iniciar sesion";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(367, 164);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(142, 31);
            button2.TabIndex = 1;
            button2.Text = "Desconectarse";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(453, 76);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(97, 125);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(114, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(218, 125);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(114, 27);
            textBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 89);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 5;
            label2.Text = "Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(218, 89);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 6;
            label3.Text = "Contraseña";
            // 
            // timer1
            // 
            timer1.Interval = 3000;
            timer1.Tick += timer1_Tick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { comoFuncionaElProgramaToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(266, 28);
            contextMenuStrip1.Text = "Menu";
            // 
            // comoFuncionaElProgramaToolStripMenuItem
            // 
            comoFuncionaElProgramaToolStripMenuItem.Name = "comoFuncionaElProgramaToolStripMenuItem";
            comoFuncionaElProgramaToolStripMenuItem.Size = new Size(265, 24);
            comoFuncionaElProgramaToolStripMenuItem.Text = "Como funciona el programa";
            comoFuncionaElProgramaToolStripMenuItem.Click += comoFuncionaElProgramaToolStripMenuItem_Click;
            // 
            // button3
            // 
            button3.Location = new Point(367, 84);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(142, 31);
            button3.TabIndex = 8;
            button3.Text = "Conectarse";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(367, 203);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(142, 31);
            button4.TabIndex = 9;
            button4.Text = "registrarse";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Invitar
            // 
            Invitar.Location = new Point(367, 241);
            Invitar.Name = "Invitar";
            Invitar.Size = new Size(142, 38);
            Invitar.TabIndex = 11;
            Invitar.Text = "Invitar";
            Invitar.UseVisualStyleBackColor = true;
            Invitar.Click += Invitar_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { listaConectados });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(914, 28);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // listaConectados
            // 
            listaConectados.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem3, toolStripMenuItem4 });
            listaConectados.Name = "listaConectados";
            listaConectados.Size = new Size(137, 24);
            listaConectados.Text = "Gente Conectada";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(83, 26);
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(83, 26);
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(83, 26);
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(83, 26);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(menuStrip1);
            Controls.Add(Invitar);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            contextMenuStrip1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem comoFuncionaElProgramaToolStripMenuItem;
        private Button button3;
        private Button button4;
        private Button Invitar;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem listaConectados;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
    }
}