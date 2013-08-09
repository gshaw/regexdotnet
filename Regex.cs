using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using RE = System.Text.RegularExpressions;

namespace Regex {
    /// <summary>
    /// Summary description for RegexForm.
    /// </summary>
    public class RegexForm : System.Windows.Forms.Form {
        private System.Windows.Forms.StatusBar statusBar;
        private System.Windows.Forms.Panel expressionPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel inputPanel;
        private System.Windows.Forms.Splitter splitter;
        private System.Windows.Forms.Panel outputPanel;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.TextBox expression;
        private System.Windows.Forms.LinkLabel linkLabel;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public RegexForm() {
            // Required for Windows Form Designer support
            InitializeComponent();

            // TODO: Add any constructor code after InitializeComponent call
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose( bool disposing ) {
            if (disposing) {
                if (components != null) {
                    components.Dispose();
                }
            }
            base.Dispose( disposing );
        }

		#region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.inputPanel = new System.Windows.Forms.Panel();
            this.input = new System.Windows.Forms.TextBox();
            this.outputPanel = new System.Windows.Forms.Panel();
            this.output = new System.Windows.Forms.TextBox();
            this.splitter = new System.Windows.Forms.Splitter();
            this.expressionPanel = new System.Windows.Forms.Panel();
            this.expression = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.statusBar = new System.Windows.Forms.StatusBar();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.inputPanel.SuspendLayout();
            this.outputPanel.SuspendLayout();
            this.expressionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Expression:";
            // 
            // inputPanel
            // 
            this.inputPanel.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                                     this.input});
            this.inputPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.inputPanel.Location = new System.Drawing.Point(0, 56);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(384, 72);
            this.inputPanel.TabIndex = 6;
            // 
            // input
            // 
            this.input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.input.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.input.MaxLength = 16777216;
            this.input.Multiline = true;
            this.input.Name = "input";
            this.input.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.input.Size = new System.Drawing.Size(384, 72);
            this.input.TabIndex = 3;
            this.input.Text = "Enter text to match against here.";
            this.input.WordWrap = false;
            this.input.TextChanged += new System.EventHandler(this.input_TextChanged);
            // 
            // outputPanel
            // 
            this.outputPanel.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                                      this.output});
            this.outputPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputPanel.Location = new System.Drawing.Point(0, 132);
            this.outputPanel.Name = "outputPanel";
            this.outputPanel.Size = new System.Drawing.Size(384, 125);
            this.outputPanel.TabIndex = 8;
            // 
            // output
            // 
            this.output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.output.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.output.Size = new System.Drawing.Size(384, 125);
            this.output.TabIndex = 0;
            this.output.Text = "Match results are displayed here.";
            this.output.WordWrap = false;
            // 
            // splitter
            // 
            this.splitter.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter.Location = new System.Drawing.Point(0, 128);
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(384, 4);
            this.splitter.TabIndex = 7;
            this.splitter.TabStop = false;
            // 
            // expressionPanel
            // 
            this.expressionPanel.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                                          this.expression,
                                                                                          this.result,
                                                                                          this.label2,
                                                                                          this.label1});
            this.expressionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.expressionPanel.Name = "expressionPanel";
            this.expressionPanel.Size = new System.Drawing.Size(384, 56);
            this.expressionPanel.TabIndex = 5;
            // 
            // expression
            // 
            this.expression.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
                | System.Windows.Forms.AnchorStyles.Right);
            this.expression.Location = new System.Drawing.Point(72, 8);
            this.expression.Name = "expression";
            this.expression.Size = new System.Drawing.Size(312, 21);
            this.expression.TabIndex = 1;
            this.expression.Text = "(\\w+) (\\w+) (?<foo>\\w+)";
            this.expression.TextChanged += new System.EventHandler(this.expression_TextChanged);
            // 
            // result
            // 
            this.result.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
                | System.Windows.Forms.AnchorStyles.Right);
            this.result.Location = new System.Drawing.Point(72, 30);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(312, 21);
            this.result.TabIndex = 2;
            this.result.Text = "$2 $1 ${foo}";
            this.result.TextChanged += new System.EventHandler(this.result_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Result:";
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(0, 257);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(384, 20);
            this.statusBar.TabIndex = 2;
            // 
            // linkLabel
            // 
            this.linkLabel.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
                | System.Windows.Forms.AnchorStyles.Right);
            this.linkLabel.Location = new System.Drawing.Point(0, 260);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(360, 16);
            this.linkLabel.TabIndex = 9;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "http://www.organicbit.com/regex/";
            this.linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // RegexForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
            this.ClientSize = new System.Drawing.Size(384, 277);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                          this.linkLabel,
                                                                          this.outputPanel,
                                                                          this.splitter,
                                                                          this.inputPanel,
                                                                          this.expressionPanel,
                                                                          this.statusBar});
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.MinimumSize = new System.Drawing.Size(264, 256);
            this.Name = "RegexForm";
            this.Text = "Regex";
            this.inputPanel.ResumeLayout(false);
            this.outputPanel.ResumeLayout(false);
            this.expressionPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }
		#endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.Run(new RegexForm());
        }

        private void expression_TextChanged(object sender, System.EventArgs e) {
            UpdateOutput();
        }

        private void result_TextChanged(object sender, System.EventArgs e) {
            UpdateOutput();
        }

        private void input_TextChanged(object sender, System.EventArgs e) {
            UpdateOutput();
        }

        public void UpdateOutput() {
            try {
                RE.Match match = RE.Regex.Match(input.Text, expression.Text);
                if (match.Success) {
                    output.Text = match.Result(result.Text);
                } else {
                    output.Text = "No match";
                }
            } catch (Exception e) {
                output.Text = e.Message;
            }
        }

        private void linkLabel_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start(linkLabel.Text);
        }

    }
}
