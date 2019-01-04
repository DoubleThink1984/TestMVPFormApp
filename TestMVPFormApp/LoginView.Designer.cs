namespace TestMVPFormApp
{
    partial class LoginView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtBoxSearchInput = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.inputTextErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.inputTextErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxSearchInput
            // 
            this.txtBoxSearchInput.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBoxSearchInput.Location = new System.Drawing.Point(23, 22);
            this.txtBoxSearchInput.Name = "txtBoxSearchInput";
            this.txtBoxSearchInput.Size = new System.Drawing.Size(403, 22);
            this.txtBoxSearchInput.TabIndex = 1;
            this.txtBoxSearchInput.Text = "Enter Text Here";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(350, 72);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // inputTextErrorProvider
            // 
            this.inputTextErrorProvider.ContainerControl = this;
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.txtBoxSearchInput);
            this.Name = "LoginView";
            this.Size = new System.Drawing.Size(452, 380);
            ((System.ComponentModel.ISupportInitialize)(this.inputTextErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxSearchInput;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ErrorProvider inputTextErrorProvider;
    }
}
