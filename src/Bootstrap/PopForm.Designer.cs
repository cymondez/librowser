﻿namespace Bootstrap
{
   partial class PopForm
   {
      /// <summary>
      /// 必需的设计器变量。
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// 清理所有正在使用的资源。
      /// </summary>
      /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
      protected override void Dispose( bool disposing )
      {
         if ( disposing && ( components != null ) )
         {
            components.Dispose();
         }
         base.Dispose( disposing );
      }

      #region Windows 窗体设计器生成的代码

      /// <summary>
      /// 设计器支持所需的方法 - 不要
      /// 使用代码编辑器修改此方法的内容。
      /// </summary>
      private void InitializeComponent()
      {
         this.browser = new Skybound.Gecko.GeckoWebBrowser();
         this.SuspendLayout();
         // 
         // browser
         // 
         this.browser.Dock = System.Windows.Forms.DockStyle.Fill;
         this.browser.Location = new System.Drawing.Point( 0, 0 );
         this.browser.Name = "browser";
         this.browser.Size = new System.Drawing.Size( 663, 461 );
         this.browser.TabIndex = 0;
         // 
         // PopForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF( 8F, 15F );
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size( 663, 461 );
         this.Controls.Add( this.browser );
         this.Name = "PopForm";
         this.Text = "PopForm";
         this.Load += new System.EventHandler( this.PopForm_Load );
         this.ResumeLayout( false );

      }

      #endregion

      private Skybound.Gecko.GeckoWebBrowser browser;
   }
}