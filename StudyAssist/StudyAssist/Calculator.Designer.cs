namespace StudyAssist
{
    partial class Calculator
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
            textBox1 = new TextBox();
            backBtn = new Button();
            delBtn = new Button();
            clrBtn = new Button();
            signBtn = new Button();
            seven = new Button();
            eight = new Button();
            nine = new Button();
            addBtn = new Button();
            four = new Button();
            five = new Button();
            six = new Button();
            minBtn = new Button();
            one = new Button();
            two = new Button();
            three = new Button();
            mulBtn = new Button();
            zero = new Button();
            decBtn = new Button();
            eqlBtn = new Button();
            divBtn = new Button();
            pi = new Button();
            log = new Button();
            sqrt = new Button();
            sq = new Button();
            cub = new Button();
            dec = new Button();
            sin = new Button();
            sinh = new Button();
            frac = new Button();
            bin = new Button();
            cos = new Button();
            cosh = new Button();
            ln = new Button();
            hex = new Button();
            tan = new Button();
            tanh = new Button();
            perBten = new Button();
            oct = new Button();
            mod = new Button();
            exp = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Agency FB", 40.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.WindowText;
            textBox1.Location = new Point(61, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(785, 87);
            textBox1.TabIndex = 0;
            textBox1.Text = "0";
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.PowderBlue;
            backBtn.Font = new Font("Wingdings", 25.2F, FontStyle.Bold, GraphicsUnit.Point, 2);
            backBtn.ForeColor = Color.FromArgb(0, 0, 64);
            backBtn.Location = new Point(61, 140);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(90, 90);
            backBtn.TabIndex = 1;
            backBtn.Text = "";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // delBtn
            // 
            delBtn.BackColor = Color.PowderBlue;
            delBtn.Font = new Font("Agency FB", 25.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delBtn.ForeColor = Color.FromArgb(0, 0, 64);
            delBtn.Location = new Point(157, 140);
            delBtn.Name = "delBtn";
            delBtn.Size = new Size(90, 90);
            delBtn.TabIndex = 2;
            delBtn.Text = "AC";
            delBtn.UseVisualStyleBackColor = false;
            delBtn.Click += delBtn_Click;
            // 
            // clrBtn
            // 
            clrBtn.BackColor = Color.PowderBlue;
            clrBtn.Font = new Font("Agency FB", 25.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clrBtn.ForeColor = Color.FromArgb(0, 0, 64);
            clrBtn.Location = new Point(253, 140);
            clrBtn.Name = "clrBtn";
            clrBtn.Size = new Size(90, 90);
            clrBtn.TabIndex = 3;
            clrBtn.Text = "C";
            clrBtn.UseVisualStyleBackColor = false;
            clrBtn.Click += clrBtn_Click;
            // 
            // signBtn
            // 
            signBtn.BackColor = Color.PowderBlue;
            signBtn.Font = new Font("Agency FB", 25.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signBtn.ForeColor = Color.FromArgb(0, 0, 64);
            signBtn.Location = new Point(349, 140);
            signBtn.Name = "signBtn";
            signBtn.Size = new Size(90, 90);
            signBtn.TabIndex = 4;
            signBtn.Text = "±";
            signBtn.UseVisualStyleBackColor = false;
            signBtn.Click += signBtn_Click;
            // 
            // seven
            // 
            seven.BackColor = Color.PowderBlue;
            seven.Font = new Font("Agency FB", 25.2F, FontStyle.Bold);
            seven.ForeColor = Color.FromArgb(0, 0, 64);
            seven.Location = new Point(61, 236);
            seven.Name = "seven";
            seven.Size = new Size(90, 90);
            seven.TabIndex = 5;
            seven.Text = "7";
            seven.UseVisualStyleBackColor = false;
            seven.Click += EnterNumbers;
            // 
            // eight
            // 
            eight.BackColor = Color.PowderBlue;
            eight.Font = new Font("Agency FB", 25.2F, FontStyle.Bold);
            eight.ForeColor = Color.FromArgb(0, 0, 64);
            eight.Location = new Point(157, 236);
            eight.Name = "eight";
            eight.Size = new Size(90, 90);
            eight.TabIndex = 6;
            eight.Text = "8";
            eight.UseVisualStyleBackColor = false;
            eight.Click += EnterNumbers;
            // 
            // nine
            // 
            nine.BackColor = Color.PowderBlue;
            nine.Font = new Font("Agency FB", 25.2F, FontStyle.Bold);
            nine.ForeColor = Color.FromArgb(0, 0, 64);
            nine.Location = new Point(253, 236);
            nine.Name = "nine";
            nine.Size = new Size(90, 90);
            nine.TabIndex = 7;
            nine.Text = "9";
            nine.UseVisualStyleBackColor = false;
            nine.Click += EnterNumbers;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.PowderBlue;
            addBtn.Font = new Font("Agency FB", 25.2F, FontStyle.Bold);
            addBtn.ForeColor = Color.FromArgb(0, 0, 64);
            addBtn.Location = new Point(349, 236);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(90, 90);
            addBtn.TabIndex = 8;
            addBtn.Text = "+";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += Operators;
            // 
            // four
            // 
            four.BackColor = Color.PowderBlue;
            four.Font = new Font("Agency FB", 25.2F, FontStyle.Bold);
            four.ForeColor = Color.FromArgb(0, 0, 64);
            four.Location = new Point(61, 332);
            four.Name = "four";
            four.Size = new Size(90, 90);
            four.TabIndex = 9;
            four.Text = "4";
            four.UseVisualStyleBackColor = false;
            four.Click += EnterNumbers;
            // 
            // five
            // 
            five.BackColor = Color.PowderBlue;
            five.Font = new Font("Agency FB", 25.2F, FontStyle.Bold);
            five.ForeColor = Color.FromArgb(0, 0, 64);
            five.Location = new Point(157, 332);
            five.Name = "five";
            five.Size = new Size(90, 90);
            five.TabIndex = 10;
            five.Text = "5";
            five.UseVisualStyleBackColor = false;
            five.Click += EnterNumbers;
            // 
            // six
            // 
            six.BackColor = Color.PowderBlue;
            six.Font = new Font("Agency FB", 25.2F, FontStyle.Bold);
            six.ForeColor = Color.FromArgb(0, 0, 64);
            six.Location = new Point(253, 332);
            six.Name = "six";
            six.Size = new Size(90, 90);
            six.TabIndex = 11;
            six.Text = "6";
            six.UseVisualStyleBackColor = false;
            six.Click += EnterNumbers;
            // 
            // minBtn
            // 
            minBtn.BackColor = Color.PowderBlue;
            minBtn.Font = new Font("Agency FB", 25.2F, FontStyle.Bold);
            minBtn.ForeColor = Color.FromArgb(0, 0, 64);
            minBtn.Location = new Point(349, 332);
            minBtn.Name = "minBtn";
            minBtn.Size = new Size(90, 90);
            minBtn.TabIndex = 12;
            minBtn.Text = "-";
            minBtn.UseVisualStyleBackColor = false;
            minBtn.Click += Operators;
            // 
            // one
            // 
            one.BackColor = Color.PowderBlue;
            one.Font = new Font("Agency FB", 25.2F, FontStyle.Bold);
            one.ForeColor = Color.FromArgb(0, 0, 64);
            one.Location = new Point(61, 428);
            one.Name = "one";
            one.Size = new Size(90, 90);
            one.TabIndex = 13;
            one.Text = "1";
            one.UseVisualStyleBackColor = false;
            one.Click += EnterNumbers;
            // 
            // two
            // 
            two.BackColor = Color.PowderBlue;
            two.Font = new Font("Agency FB", 25.2F, FontStyle.Bold);
            two.ForeColor = Color.FromArgb(0, 0, 64);
            two.Location = new Point(157, 428);
            two.Name = "two";
            two.Size = new Size(90, 90);
            two.TabIndex = 14;
            two.Text = "2";
            two.UseVisualStyleBackColor = false;
            two.Click += EnterNumbers;
            // 
            // three
            // 
            three.BackColor = Color.PowderBlue;
            three.Font = new Font("Agency FB", 25.2F, FontStyle.Bold);
            three.ForeColor = Color.FromArgb(0, 0, 64);
            three.Location = new Point(253, 428);
            three.Name = "three";
            three.Size = new Size(90, 90);
            three.TabIndex = 15;
            three.Text = "3";
            three.UseVisualStyleBackColor = false;
            three.Click += EnterNumbers;
            // 
            // mulBtn
            // 
            mulBtn.BackColor = Color.PowderBlue;
            mulBtn.Font = new Font("Agency FB", 25.2F, FontStyle.Bold);
            mulBtn.ForeColor = Color.FromArgb(0, 0, 64);
            mulBtn.Location = new Point(349, 428);
            mulBtn.Name = "mulBtn";
            mulBtn.Size = new Size(90, 90);
            mulBtn.TabIndex = 16;
            mulBtn.Text = "*";
            mulBtn.UseVisualStyleBackColor = false;
            mulBtn.Click += Operators;
            // 
            // zero
            // 
            zero.BackColor = Color.PowderBlue;
            zero.Font = new Font("Agency FB", 25.2F, FontStyle.Bold);
            zero.ForeColor = Color.FromArgb(0, 0, 64);
            zero.Location = new Point(61, 524);
            zero.Name = "zero";
            zero.Size = new Size(90, 90);
            zero.TabIndex = 17;
            zero.Text = "0";
            zero.UseVisualStyleBackColor = false;
            zero.Click += EnterNumbers;
            // 
            // decBtn
            // 
            decBtn.BackColor = Color.PowderBlue;
            decBtn.Font = new Font("Agency FB", 25.2F, FontStyle.Bold);
            decBtn.ForeColor = Color.FromArgb(0, 0, 64);
            decBtn.Location = new Point(157, 524);
            decBtn.Name = "decBtn";
            decBtn.Size = new Size(90, 90);
            decBtn.TabIndex = 18;
            decBtn.Text = ".";
            decBtn.UseVisualStyleBackColor = false;
            decBtn.Click += EnterNumbers;
            // 
            // eqlBtn
            // 
            eqlBtn.BackColor = Color.PowderBlue;
            eqlBtn.Font = new Font("Agency FB", 25.2F, FontStyle.Bold);
            eqlBtn.ForeColor = Color.FromArgb(0, 0, 64);
            eqlBtn.Location = new Point(253, 524);
            eqlBtn.Name = "eqlBtn";
            eqlBtn.Size = new Size(90, 90);
            eqlBtn.TabIndex = 19;
            eqlBtn.Text = "=";
            eqlBtn.UseVisualStyleBackColor = false;
            eqlBtn.Click += eqlBtn_Click;
            // 
            // divBtn
            // 
            divBtn.BackColor = Color.PowderBlue;
            divBtn.Font = new Font("Agency FB", 25.2F, FontStyle.Bold);
            divBtn.ForeColor = Color.FromArgb(0, 0, 64);
            divBtn.Location = new Point(349, 524);
            divBtn.Name = "divBtn";
            divBtn.Size = new Size(90, 90);
            divBtn.TabIndex = 20;
            divBtn.Text = "/";
            divBtn.UseVisualStyleBackColor = false;
            divBtn.Click += Operators;
            // 
            // pi
            // 
            pi.BackColor = Color.PowderBlue;
            pi.Font = new Font("Agency FB", 25.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pi.ForeColor = Color.FromArgb(0, 0, 64);
            pi.Location = new Point(468, 140);
            pi.Name = "pi";
            pi.Size = new Size(90, 90);
            pi.TabIndex = 21;
            pi.Text = "π";
            pi.UseVisualStyleBackColor = false;
            pi.Click += pi_Click;
            // 
            // log
            // 
            log.BackColor = Color.PowderBlue;
            log.Font = new Font("Agency FB", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            log.ForeColor = Color.FromArgb(0, 0, 64);
            log.Location = new Point(564, 140);
            log.Name = "log";
            log.Size = new Size(90, 90);
            log.TabIndex = 22;
            log.Text = "Log";
            log.UseVisualStyleBackColor = false;
            log.Click += log_Click;
            // 
            // sqrt
            // 
            sqrt.BackColor = Color.PowderBlue;
            sqrt.Font = new Font("Agency FB", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sqrt.ForeColor = Color.FromArgb(0, 0, 64);
            sqrt.Location = new Point(660, 140);
            sqrt.Name = "sqrt";
            sqrt.Size = new Size(90, 90);
            sqrt.TabIndex = 23;
            sqrt.Text = "√sqrt";
            sqrt.UseVisualStyleBackColor = false;
            sqrt.Click += sqrt_Click;
            // 
            // sq
            // 
            sq.BackColor = Color.PowderBlue;
            sq.Font = new Font("Agency FB", 19.8000011F, FontStyle.Bold);
            sq.ForeColor = Color.FromArgb(0, 0, 64);
            sq.Location = new Point(756, 140);
            sq.Name = "sq";
            sq.Size = new Size(90, 90);
            sq.TabIndex = 24;
            sq.Text = "x^2";
            sq.UseVisualStyleBackColor = false;
            sq.Click += sq_Click;
            // 
            // cub
            // 
            cub.BackColor = Color.PowderBlue;
            cub.Font = new Font("Agency FB", 19.8000011F, FontStyle.Bold);
            cub.ForeColor = Color.FromArgb(0, 0, 64);
            cub.Location = new Point(756, 236);
            cub.Name = "cub";
            cub.Size = new Size(90, 90);
            cub.TabIndex = 28;
            cub.Text = "x^3";
            cub.UseVisualStyleBackColor = false;
            cub.Click += cub_Click;
            // 
            // dec
            // 
            dec.BackColor = Color.PowderBlue;
            dec.Font = new Font("Agency FB", 19.8000011F, FontStyle.Bold);
            dec.ForeColor = Color.FromArgb(0, 0, 64);
            dec.Location = new Point(660, 236);
            dec.Name = "dec";
            dec.Size = new Size(90, 90);
            dec.TabIndex = 27;
            dec.Text = "Dec";
            dec.UseVisualStyleBackColor = false;
            dec.Click += dec_Click;
            // 
            // sin
            // 
            sin.BackColor = Color.PowderBlue;
            sin.Font = new Font("Agency FB", 19.8000011F, FontStyle.Bold);
            sin.ForeColor = Color.FromArgb(0, 0, 64);
            sin.Location = new Point(564, 236);
            sin.Name = "sin";
            sin.Size = new Size(90, 90);
            sin.TabIndex = 26;
            sin.Text = "sin";
            sin.UseVisualStyleBackColor = false;
            sin.Click += sin_Click;
            // 
            // sinh
            // 
            sinh.BackColor = Color.PowderBlue;
            sinh.Font = new Font("Agency FB", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sinh.ForeColor = Color.FromArgb(0, 0, 64);
            sinh.Location = new Point(468, 236);
            sinh.Name = "sinh";
            sinh.Size = new Size(90, 90);
            sinh.TabIndex = 25;
            sinh.Text = "sinh";
            sinh.UseVisualStyleBackColor = false;
            sinh.Click += sinh_Click;
            // 
            // frac
            // 
            frac.BackColor = Color.PowderBlue;
            frac.Font = new Font("Agency FB", 19.8000011F, FontStyle.Bold);
            frac.ForeColor = Color.FromArgb(0, 0, 64);
            frac.Location = new Point(756, 332);
            frac.Name = "frac";
            frac.Size = new Size(90, 90);
            frac.TabIndex = 32;
            frac.Text = "1/x";
            frac.UseVisualStyleBackColor = false;
            frac.Click += frac_Click;
            // 
            // bin
            // 
            bin.BackColor = Color.PowderBlue;
            bin.Font = new Font("Agency FB", 19.8000011F, FontStyle.Bold);
            bin.ForeColor = Color.FromArgb(0, 0, 64);
            bin.Location = new Point(660, 332);
            bin.Name = "bin";
            bin.Size = new Size(90, 90);
            bin.TabIndex = 31;
            bin.Text = "Bin";
            bin.UseVisualStyleBackColor = false;
            bin.Click += bin_Click;
            // 
            // cos
            // 
            cos.BackColor = Color.PowderBlue;
            cos.Font = new Font("Agency FB", 19.8000011F, FontStyle.Bold);
            cos.ForeColor = Color.FromArgb(0, 0, 64);
            cos.Location = new Point(564, 332);
            cos.Name = "cos";
            cos.Size = new Size(90, 90);
            cos.TabIndex = 30;
            cos.Text = "cos";
            cos.UseVisualStyleBackColor = false;
            cos.Click += cos_Click;
            // 
            // cosh
            // 
            cosh.BackColor = Color.PowderBlue;
            cosh.Font = new Font("Agency FB", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cosh.ForeColor = Color.FromArgb(0, 0, 64);
            cosh.Location = new Point(468, 332);
            cosh.Name = "cosh";
            cosh.Size = new Size(90, 90);
            cosh.TabIndex = 29;
            cosh.Text = "cosh";
            cosh.UseVisualStyleBackColor = false;
            cosh.Click += cosh_Click;
            // 
            // ln
            // 
            ln.BackColor = Color.PowderBlue;
            ln.Font = new Font("Agency FB", 19.8000011F, FontStyle.Bold);
            ln.ForeColor = Color.FromArgb(0, 0, 64);
            ln.Location = new Point(756, 428);
            ln.Name = "ln";
            ln.Size = new Size(90, 90);
            ln.TabIndex = 36;
            ln.Text = "ln x";
            ln.UseVisualStyleBackColor = false;
            ln.Click += ln_Click;
            // 
            // hex
            // 
            hex.BackColor = Color.PowderBlue;
            hex.Font = new Font("Agency FB", 19.8000011F, FontStyle.Bold);
            hex.ForeColor = Color.FromArgb(0, 0, 64);
            hex.Location = new Point(660, 428);
            hex.Name = "hex";
            hex.Size = new Size(90, 90);
            hex.TabIndex = 35;
            hex.Text = "Hex";
            hex.UseVisualStyleBackColor = false;
            hex.Click += hex_Click;
            // 
            // tan
            // 
            tan.BackColor = Color.PowderBlue;
            tan.Font = new Font("Agency FB", 19.8000011F, FontStyle.Bold);
            tan.ForeColor = Color.FromArgb(0, 0, 64);
            tan.Location = new Point(564, 428);
            tan.Name = "tan";
            tan.Size = new Size(90, 90);
            tan.TabIndex = 34;
            tan.Text = "tan";
            tan.UseVisualStyleBackColor = false;
            tan.Click += tan_Click;
            // 
            // tanh
            // 
            tanh.BackColor = Color.PowderBlue;
            tanh.Font = new Font("Agency FB", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tanh.ForeColor = Color.FromArgb(0, 0, 64);
            tanh.Location = new Point(468, 428);
            tanh.Name = "tanh";
            tanh.Size = new Size(90, 90);
            tanh.TabIndex = 33;
            tanh.Text = "tanh";
            tanh.UseVisualStyleBackColor = false;
            tanh.Click += tanh_Click;
            // 
            // perBten
            // 
            perBten.BackColor = Color.PowderBlue;
            perBten.Font = new Font("Agency FB", 19.8000011F, FontStyle.Bold);
            perBten.ForeColor = Color.FromArgb(0, 0, 64);
            perBten.Location = new Point(756, 524);
            perBten.Name = "perBten";
            perBten.Size = new Size(90, 90);
            perBten.TabIndex = 40;
            perBten.Text = "%";
            perBten.UseVisualStyleBackColor = false;
            perBten.Click += perBten_Click;
            // 
            // oct
            // 
            oct.BackColor = Color.PowderBlue;
            oct.Font = new Font("Agency FB", 19.8000011F, FontStyle.Bold);
            oct.ForeColor = Color.FromArgb(0, 0, 64);
            oct.Location = new Point(660, 524);
            oct.Name = "oct";
            oct.Size = new Size(90, 90);
            oct.TabIndex = 39;
            oct.Text = "Oct";
            oct.UseVisualStyleBackColor = false;
            oct.Click += oct_Click;
            // 
            // mod
            // 
            mod.BackColor = Color.PowderBlue;
            mod.Font = new Font("Agency FB", 19.8000011F, FontStyle.Bold);
            mod.ForeColor = Color.FromArgb(0, 0, 64);
            mod.Location = new Point(564, 524);
            mod.Name = "mod";
            mod.Size = new Size(90, 90);
            mod.TabIndex = 38;
            mod.Text = "mod";
            mod.UseVisualStyleBackColor = false;
            mod.Click += Operators;
            // 
            // exp
            // 
            exp.BackColor = Color.PowderBlue;
            exp.Font = new Font("Agency FB", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exp.ForeColor = Color.FromArgb(0, 0, 64);
            exp.Location = new Point(468, 524);
            exp.Name = "exp";
            exp.Size = new Size(90, 90);
            exp.TabIndex = 37;
            exp.Text = "exp";
            exp.UseVisualStyleBackColor = false;
            exp.Click += Operators;
            // 
            // button1
            // 
            button1.BackColor = Color.PowderBlue;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(1171, 596);
            button1.Name = "button1";
            button1.Size = new Size(87, 35);
            button1.TabIndex = 41;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1282, 653);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(perBten);
            Controls.Add(oct);
            Controls.Add(mod);
            Controls.Add(exp);
            Controls.Add(ln);
            Controls.Add(hex);
            Controls.Add(tan);
            Controls.Add(tanh);
            Controls.Add(frac);
            Controls.Add(bin);
            Controls.Add(cos);
            Controls.Add(cosh);
            Controls.Add(cub);
            Controls.Add(dec);
            Controls.Add(sin);
            Controls.Add(sinh);
            Controls.Add(sq);
            Controls.Add(sqrt);
            Controls.Add(log);
            Controls.Add(pi);
            Controls.Add(divBtn);
            Controls.Add(eqlBtn);
            Controls.Add(decBtn);
            Controls.Add(zero);
            Controls.Add(mulBtn);
            Controls.Add(three);
            Controls.Add(two);
            Controls.Add(one);
            Controls.Add(minBtn);
            Controls.Add(six);
            Controls.Add(five);
            Controls.Add(four);
            Controls.Add(addBtn);
            Controls.Add(nine);
            Controls.Add(eight);
            Controls.Add(seven);
            Controls.Add(signBtn);
            Controls.Add(clrBtn);
            Controls.Add(delBtn);
            Controls.Add(backBtn);
            Controls.Add(textBox1);
            Name = "Calculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            Load += Calculator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button backBtn;
        private Button delBtn;
        private Button clrBtn;
        private Button signBtn;
        private Button seven;
        private Button eight;
        private Button nine;
        private Button addBtn;
        private Button four;
        private Button five;
        private Button six;
        private Button minBtn;
        private Button one;
        private Button two;
        private Button three;
        private Button mulBtn;
        private Button zero;
        private Button decBtn;
        private Button eqlBtn;
        private Button divBtn;
        private Button pi;
        private Button log;
        private Button sqrt;
        private Button sq;
        private Button cub;
        private Button dec;
        private Button sin;
        private Button sinh;
        private Button frac;
        private Button bin;
        private Button cos;
        private Button cosh;
        private Button ln;
        private Button hex;
        private Button tan;
        private Button tanh;
        private Button perBten;
        private Button oct;
        private Button mod;
        private Button exp;
        private Button button1;
    }
}