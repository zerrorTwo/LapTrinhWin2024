namespace WindowsFormsApp1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.pnLogin = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.tbComfimPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLogin = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnRegister = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnCofirm = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.lbBackk = new System.Windows.Forms.LinkLabel();
            this.pnLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnLogin
            // 
            this.pnLogin.BackColor = System.Drawing.Color.Transparent;
            this.pnLogin.Controls.Add(this.tbComfimPass);
            this.pnLogin.Controls.Add(this.tbPassword);
            this.pnLogin.Controls.Add(this.tbUserName);
            this.pnLogin.FillColor = System.Drawing.Color.White;
            this.pnLogin.Location = new System.Drawing.Point(304, 148);
            this.pnLogin.Name = "pnLogin";
            this.pnLogin.Radius = 20;
            this.pnLogin.ShadowColor = System.Drawing.Color.Black;
            this.pnLogin.Size = new System.Drawing.Size(409, 234);
            this.pnLogin.TabIndex = 0;
            this.pnLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.pnLogin_Paint);
            // 
            // tbComfimPass
            // 
            this.tbComfimPass.BorderRadius = 20;
            this.tbComfimPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbComfimPass.DefaultText = "";
            this.tbComfimPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbComfimPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbComfimPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbComfimPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbComfimPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbComfimPass.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbComfimPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbComfimPass.Location = new System.Drawing.Point(50, 212);
            this.tbComfimPass.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbComfimPass.Name = "tbComfimPass";
            this.tbComfimPass.PasswordChar = '*';
            this.tbComfimPass.PlaceholderText = "Nhập lại mật khẩu";
            this.tbComfimPass.SelectedText = "";
            this.tbComfimPass.Size = new System.Drawing.Size(307, 48);
            this.tbComfimPass.TabIndex = 2;
            this.tbComfimPass.Visible = false;
            // 
            // tbPassword
            // 
            this.tbPassword.BorderRadius = 20;
            this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.DefaultText = "";
            this.tbPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPassword.Location = new System.Drawing.Point(50, 128);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.PlaceholderText = "Mật khẩu";
            this.tbPassword.SelectedText = "";
            this.tbPassword.Size = new System.Drawing.Size(307, 48);
            this.tbPassword.TabIndex = 1;
            // 
            // tbUserName
            // 
            this.tbUserName.BorderRadius = 20;
            this.tbUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUserName.DefaultText = "";
            this.tbUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbUserName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbUserName.Location = new System.Drawing.Point(50, 42);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.PasswordChar = '\0';
            this.tbUserName.PlaceholderText = "Tên tài khoản";
            this.tbUserName.SelectedText = "";
            this.tbUserName.Size = new System.Drawing.Size(307, 48);
            this.tbUserName.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.AllowAnimations = true;
            this.btnLogin.AllowMouseEffects = true;
            this.btnLogin.AllowToggling = false;
            this.btnLogin.AnimationSpeed = 200;
            this.btnLogin.AutoGenerateColors = false;
            this.btnLogin.AutoRoundBorders = false;
            this.btnLogin.AutoSizeLeftIcon = true;
            this.btnLogin.AutoSizeRightIcon = true;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogin.ButtonText = "Đăng nhập";
            this.btnLogin.ButtonTextMarginLeft = 0;
            this.btnLogin.ColorContrastOnClick = 45;
            this.btnLogin.ColorContrastOnHover = 45;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnLogin.CustomizableEdges = borderEdges1;
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogin.DisabledBorderColor = System.Drawing.Color.Green;
            this.btnLogin.DisabledFillColor = System.Drawing.Color.Green;
            this.btnLogin.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnLogin.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnLogin.IconMarginLeft = 11;
            this.btnLogin.IconPadding = 10;
            this.btnLogin.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogin.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnLogin.IconSize = 25;
            this.btnLogin.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLogin.IdleBorderRadius = 50;
            this.btnLogin.IdleBorderThickness = 1;
            this.btnLogin.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLogin.IdleIconLeftImage = null;
            this.btnLogin.IdleIconRightImage = null;
            this.btnLogin.IndicateFocus = false;
            this.btnLogin.Location = new System.Drawing.Point(311, 461);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.OnDisabledState.BorderColor = System.Drawing.Color.Green;
            this.btnLogin.OnDisabledState.BorderRadius = 50;
            this.btnLogin.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogin.OnDisabledState.BorderThickness = 1;
            this.btnLogin.OnDisabledState.FillColor = System.Drawing.Color.Green;
            this.btnLogin.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnLogin.OnDisabledState.IconLeftImage = null;
            this.btnLogin.OnDisabledState.IconRightImage = null;
            this.btnLogin.onHoverState.BorderColor = System.Drawing.Color.Green;
            this.btnLogin.onHoverState.BorderRadius = 50;
            this.btnLogin.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogin.onHoverState.BorderThickness = 1;
            this.btnLogin.onHoverState.FillColor = System.Drawing.Color.Green;
            this.btnLogin.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnLogin.onHoverState.IconLeftImage = null;
            this.btnLogin.onHoverState.IconRightImage = null;
            this.btnLogin.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLogin.OnIdleState.BorderRadius = 50;
            this.btnLogin.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogin.OnIdleState.BorderThickness = 1;
            this.btnLogin.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLogin.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnLogin.OnIdleState.IconLeftImage = null;
            this.btnLogin.OnIdleState.IconRightImage = null;
            this.btnLogin.OnPressedState.BorderColor = System.Drawing.Color.Green;
            this.btnLogin.OnPressedState.BorderRadius = 50;
            this.btnLogin.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogin.OnPressedState.BorderThickness = 1;
            this.btnLogin.OnPressedState.FillColor = System.Drawing.Color.Green;
            this.btnLogin.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnLogin.OnPressedState.IconLeftImage = null;
            this.btnLogin.OnPressedState.IconRightImage = null;
            this.btnLogin.Size = new System.Drawing.Size(172, 74);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogin.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLogin.TextMarginLeft = 0;
            this.btnLogin.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnLogin.UseDefaultRadiusAndThickness = true;
            this.btnLogin.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.AllowAnimations = true;
            this.btnRegister.AllowMouseEffects = true;
            this.btnRegister.AllowToggling = false;
            this.btnRegister.AnimationSpeed = 200;
            this.btnRegister.AutoGenerateColors = false;
            this.btnRegister.AutoRoundBorders = false;
            this.btnRegister.AutoSizeLeftIcon = true;
            this.btnRegister.AutoSizeRightIcon = true;
            this.btnRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnRegister.BackColor1 = System.Drawing.Color.Silver;
            this.btnRegister.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegister.BackgroundImage")));
            this.btnRegister.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRegister.ButtonText = "Đăng kí";
            this.btnRegister.ButtonTextMarginLeft = 0;
            this.btnRegister.ColorContrastOnClick = 45;
            this.btnRegister.ColorContrastOnHover = 45;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnRegister.CustomizableEdges = borderEdges2;
            this.btnRegister.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRegister.DisabledBorderColor = System.Drawing.Color.Gray;
            this.btnRegister.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnRegister.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnRegister.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegister.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnRegister.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnRegister.IconMarginLeft = 11;
            this.btnRegister.IconPadding = 10;
            this.btnRegister.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegister.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnRegister.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnRegister.IconSize = 25;
            this.btnRegister.IdleBorderColor = System.Drawing.Color.Silver;
            this.btnRegister.IdleBorderRadius = 50;
            this.btnRegister.IdleBorderThickness = 1;
            this.btnRegister.IdleFillColor = System.Drawing.Color.Silver;
            this.btnRegister.IdleIconLeftImage = null;
            this.btnRegister.IdleIconRightImage = null;
            this.btnRegister.IndicateFocus = false;
            this.btnRegister.Location = new System.Drawing.Point(541, 461);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.OnDisabledState.BorderColor = System.Drawing.Color.Gray;
            this.btnRegister.OnDisabledState.BorderRadius = 50;
            this.btnRegister.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRegister.OnDisabledState.BorderThickness = 1;
            this.btnRegister.OnDisabledState.FillColor = System.Drawing.Color.Gray;
            this.btnRegister.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnRegister.OnDisabledState.IconLeftImage = null;
            this.btnRegister.OnDisabledState.IconRightImage = null;
            this.btnRegister.onHoverState.BorderColor = System.Drawing.Color.Gray;
            this.btnRegister.onHoverState.BorderRadius = 50;
            this.btnRegister.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRegister.onHoverState.BorderThickness = 1;
            this.btnRegister.onHoverState.FillColor = System.Drawing.Color.Gray;
            this.btnRegister.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnRegister.onHoverState.IconLeftImage = null;
            this.btnRegister.onHoverState.IconRightImage = null;
            this.btnRegister.OnIdleState.BorderColor = System.Drawing.Color.Silver;
            this.btnRegister.OnIdleState.BorderRadius = 50;
            this.btnRegister.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRegister.OnIdleState.BorderThickness = 1;
            this.btnRegister.OnIdleState.FillColor = System.Drawing.Color.Silver;
            this.btnRegister.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnRegister.OnIdleState.IconLeftImage = null;
            this.btnRegister.OnIdleState.IconRightImage = null;
            this.btnRegister.OnPressedState.BorderColor = System.Drawing.Color.Gray;
            this.btnRegister.OnPressedState.BorderRadius = 50;
            this.btnRegister.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRegister.OnPressedState.BorderThickness = 1;
            this.btnRegister.OnPressedState.FillColor = System.Drawing.Color.Gray;
            this.btnRegister.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnRegister.OnPressedState.IconLeftImage = null;
            this.btnRegister.OnPressedState.IconRightImage = null;
            this.btnRegister.Size = new System.Drawing.Size(172, 74);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegister.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRegister.TextMarginLeft = 0;
            this.btnRegister.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnRegister.UseDefaultRadiusAndThickness = true;
            this.btnRegister.Click += new System.EventHandler(this.bunifuButton1_Click_1);
            // 
            // btnCofirm
            // 
            this.btnCofirm.AllowAnimations = true;
            this.btnCofirm.AllowMouseEffects = true;
            this.btnCofirm.AllowToggling = false;
            this.btnCofirm.AnimationSpeed = 200;
            this.btnCofirm.AutoGenerateColors = false;
            this.btnCofirm.AutoRoundBorders = false;
            this.btnCofirm.AutoSizeLeftIcon = true;
            this.btnCofirm.AutoSizeRightIcon = true;
            this.btnCofirm.BackColor = System.Drawing.Color.Transparent;
            this.btnCofirm.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCofirm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCofirm.BackgroundImage")));
            this.btnCofirm.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCofirm.ButtonText = "Đăng kí";
            this.btnCofirm.ButtonTextMarginLeft = 0;
            this.btnCofirm.ColorContrastOnClick = 45;
            this.btnCofirm.ColorContrastOnHover = 45;
            this.btnCofirm.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnCofirm.CustomizableEdges = borderEdges3;
            this.btnCofirm.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCofirm.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCofirm.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCofirm.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCofirm.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnCofirm.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCofirm.ForeColor = System.Drawing.Color.White;
            this.btnCofirm.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCofirm.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnCofirm.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnCofirm.IconMarginLeft = 11;
            this.btnCofirm.IconPadding = 10;
            this.btnCofirm.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCofirm.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnCofirm.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnCofirm.IconSize = 25;
            this.btnCofirm.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCofirm.IdleBorderRadius = 50;
            this.btnCofirm.IdleBorderThickness = 1;
            this.btnCofirm.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCofirm.IdleIconLeftImage = null;
            this.btnCofirm.IdleIconRightImage = null;
            this.btnCofirm.IndicateFocus = false;
            this.btnCofirm.Location = new System.Drawing.Point(421, 461);
            this.btnCofirm.Name = "btnCofirm";
            this.btnCofirm.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCofirm.OnDisabledState.BorderRadius = 50;
            this.btnCofirm.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCofirm.OnDisabledState.BorderThickness = 1;
            this.btnCofirm.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCofirm.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCofirm.OnDisabledState.IconLeftImage = null;
            this.btnCofirm.OnDisabledState.IconRightImage = null;
            this.btnCofirm.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCofirm.onHoverState.BorderRadius = 50;
            this.btnCofirm.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCofirm.onHoverState.BorderThickness = 1;
            this.btnCofirm.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCofirm.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnCofirm.onHoverState.IconLeftImage = null;
            this.btnCofirm.onHoverState.IconRightImage = null;
            this.btnCofirm.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCofirm.OnIdleState.BorderRadius = 50;
            this.btnCofirm.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCofirm.OnIdleState.BorderThickness = 1;
            this.btnCofirm.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCofirm.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnCofirm.OnIdleState.IconLeftImage = null;
            this.btnCofirm.OnIdleState.IconRightImage = null;
            this.btnCofirm.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCofirm.OnPressedState.BorderRadius = 50;
            this.btnCofirm.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCofirm.OnPressedState.BorderThickness = 1;
            this.btnCofirm.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCofirm.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnCofirm.OnPressedState.IconLeftImage = null;
            this.btnCofirm.OnPressedState.IconRightImage = null;
            this.btnCofirm.Size = new System.Drawing.Size(172, 74);
            this.btnCofirm.TabIndex = 3;
            this.btnCofirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCofirm.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCofirm.TextMarginLeft = 0;
            this.btnCofirm.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnCofirm.UseDefaultRadiusAndThickness = true;
            this.btnCofirm.Visible = false;
            // 
            // lbBackk
            // 
            this.lbBackk.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbBackk.AutoSize = true;
            this.lbBackk.BackColor = System.Drawing.Color.Transparent;
            this.lbBackk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbBackk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBackk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbBackk.Location = new System.Drawing.Point(636, 585);
            this.lbBackk.Name = "lbBackk";
            this.lbBackk.Size = new System.Drawing.Size(289, 25);
            this.lbBackk.TabIndex = 5;
            this.lbBackk.TabStop = true;
            this.lbBackk.Text = "Đã có tài khoản. Nhấn vào đây !";
            this.lbBackk.Visible = false;
            this.lbBackk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbBackk_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.AnyConv1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(999, 649);
            this.Controls.Add(this.lbBackk);
            this.Controls.Add(this.btnCofirm);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pnLogin);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnLogin.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel pnLogin;
        private Guna.UI2.WinForms.Guna2TextBox tbPassword;
        private Guna.UI2.WinForms.Guna2TextBox tbUserName;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnLogin;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnRegister;
        private Guna.UI2.WinForms.Guna2TextBox tbComfimPass;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCofirm;
        private System.Windows.Forms.LinkLabel lbBackk;
    }
}

