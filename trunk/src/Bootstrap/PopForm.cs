using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bootstrap
{
   public partial class PopForm : Form
   {
      private readonly string url;

      public PopForm()
      {
         InitializeComponent();
      }

      public PopForm(string url): this()
      {
         this.url = url;
      }

      private void PopForm_Load( object sender, EventArgs e )
      {
         browser.Navigate( url );
      }
   }
}